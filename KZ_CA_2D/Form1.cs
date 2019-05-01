using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KZ_CA_1D
{
    public partial class Form1 : Form
    {
        uint meshSizeX;
        uint meshSizeY;
        int maxTime;
        int currentTime;
        List<int[,]> timespace;
        int delayTime;
        private volatile bool stopThread = false;
        private Thread workThread;
        private Thread drawThread;
        bool flag = false;
        bool reset = false;
        int[,] currentUniverse;

        void initEvolution2D()
        {
            meshSizeX = (uint)numericUpDownMeshSizeX.Value;
            meshSizeY = (uint)numericUpDownMeshSizeY.Value;
            currentTime = 0;
            maxTime = 0;
            delayTime = 1000;

            //universe = new int[meshSizeX + 2, meshSizeY + 2];//+2 na warunki brzegowe //
            timespace = null;
            timespace = new List<int[,]>();
            currentUniverse = null; ;
            currentUniverse = new int[meshSizeX + 2, meshSizeY + 2];
            seed();
            //Początkowa wartośc universum
            timespace.Add((int[,])currentUniverse.Clone());
            System.Console.Write(2);
        }
        void resetEvolution()
        {

        }

        void seed()
        {
            Random random = new Random();
            int switch_on = comboBox1.SelectedIndex;
            int x = random.Next(2, (int)meshSizeX - 5);
            int y = random.Next(2, (int)meshSizeY - 5);
            switch (switch_on)
            {
                case 0://Random
                    for (int i = 1; i < meshSizeX+1; i++)
                    {
                        for (int j = 1; j < meshSizeY+2; j++)
                        {
                            currentUniverse[i,j] = random.Next(0, 2);
                        }
                    }
                    break;
                case 1://Empty
                    break;
                case 2://Niezmienny                
                    int l = 2;
                    currentUniverse[x, y] = 1;
                    currentUniverse[x, y + l + 1] = 1;
                    for (int i = 1; i <= l; i++)
                    {
                        currentUniverse[x-  1, y + i] = 1;
                        currentUniverse[x + 1, y + i] = 1;
                    }
                    break;
                case 3://Glider
                    currentUniverse[x - 1, y] = 1;
                    currentUniverse[x - 1, y + 1] = 1;
                    currentUniverse[x, y] = 1;//srodek
                    currentUniverse[x, y - 1] = 1;
                    currentUniverse[x + 1, y + 1] = 1;
                    break;
                case 4://Oscylator
                    if (x%2 == 0)
                    {
                        currentUniverse[x - 1, y] = 1;
                        currentUniverse[x, y] = 1;
                        currentUniverse[x + 1, y] = 1;
                    }
                    else
                    {
                        currentUniverse[x, y - 1] = 1;
                        currentUniverse[x, y] = 1;
                        currentUniverse[x, y + 1] = 1;
                    }
                    break;
                default:
                    break;
            }
        }


        void setDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            meshSizeX = (uint)numericUpDownMeshSizeX.Value;
            meshSizeY = (uint)numericUpDownMeshSizeY.Value;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.CurrentCell = null;
            dataGridView1.ReadOnly = true;//!!!!!!!!!

            dataGridView1.SuspendLayout();
            for (int i = 0; i < meshSizeY; i++)
            {
                dataGridView1.Columns.Add("", "");
                dataGridView1.Columns[i].Width = 10;
            }

            dataGridView1.Rows.Add((Int32)meshSizeX-1);

            for (int i = 0; i < meshSizeX; i++)
            {
                dataGridView1.Rows[i].Height = 10;
            }
            dataGridView1.ResumeLayout();

        }

        public Form1() // zmienić te wartości na jakieś żeby się mieściły w pictureBox
        {
            InitializeComponent();


            numericUpDownMeshSizeX.Minimum = 5;
            numericUpDownMeshSizeX.Maximum = 60;
            numericUpDownMeshSizeY.Minimum = 5;
            numericUpDownMeshSizeY.Maximum = 100;
            numericUpDownCurrentTime.Minimum = 0;
            numericUpDownCurrentTime.Maximum = int.MaxValue;
            numericUpDownCurrentTime.Enabled = false;
            trackBarCurrentTime.Minimum = 0;
            trackBarCurrentTime.Maximum = int.MaxValue;
            trackBarCurrentTime.Enabled = false;


            dataGridView1.Height = 600;
            dataGridView1.Width = 1000;

            meshSizeX = (uint)numericUpDownMeshSizeX.Value;
            meshSizeY = (uint)numericUpDownMeshSizeY.Value;

            setDataGridView();
            comboBox1.SelectedIndex = 0;
            initEvolution2D();
        }


        private int[,] setBoundaryCondition(int[,] universe)
        {
            int[,] tmpUniverse = new int[meshSizeX + 2, meshSizeY + 2];
            tmpUniverse = (int[,])universe.Clone();
            if (true)//meshSizeX == meshSizeY)//Dunno czy ten warunek jest potrzebny
            {
                //corners
                tmpUniverse[0, 0] = tmpUniverse[meshSizeX, meshSizeY];//left up
                tmpUniverse[0, meshSizeY + 1] = tmpUniverse[meshSizeX, 1];//right up
                tmpUniverse[meshSizeX + 1, 0] = tmpUniverse[1, meshSizeY];//left down
                tmpUniverse[meshSizeX + 1, meshSizeY + 1] = tmpUniverse[1, 1];//right down

                //walls
                //for (int i = 1; i < meshSizeX + 1; i++)
                //{
                //    tmpUniverse[0, i] = tmpUniverse[meshSizeX, i];//up wall
                //    tmpUniverse[meshSizeX + 1, i] = tmpUniverse[1, i];//down wall
                //}
                //for (int i = 1; i < meshSizeY+ 1 ; i++)
                //{
                //    tmpUniverse[i, 0] = tmpUniverse[i, meshSizeY]; //left wall
                //    tmpUniverse[i, meshSizeY + 1] = tmpUniverse[i, 0]; //right wall
                //}
                for (int i = 1; i < meshSizeX + 1; i++)
                {
                    tmpUniverse[i, 0] = tmpUniverse[i, meshSizeY]; //left wall
                    tmpUniverse[i, meshSizeY + 1] = tmpUniverse[i, 0]; //right wall
                }
                for (int i = 1; i < meshSizeY + 1; i++)
                {
                    tmpUniverse[0, i] = tmpUniverse[meshSizeX, i];//up wall
                    tmpUniverse[meshSizeX + 1, i] = tmpUniverse[1, i];//down wall
                }


            }
            else
            {

            }

            return tmpUniverse;
        }

        private int checkSurrounding(int[,] universe, int cellState,int x,int y)
        {
            int count = 0;
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (i == x && j == y)
                    {
                        continue;
                    }

                    if (universe[i,j] == 1)
                    {
                        count += 1;
                    }
                }
            }

            if (cellState == 0)
            {
                if (count == 3) return 1; //Sprawdzić czy ==3 czy >= 3
                else return 0;
            }
            else
            {
                if (count == 2 || count == 3) return 1;
                else if (count < 2) return 0;
                else if (count > 3) return 0;
                    
            }
            return 1;
        }
        

        private void grow(int time)//
        {
            
            timespace[time-1] = setBoundaryCondition(timespace[time - 1]);
            for (int i = 1; i < meshSizeX + 1; i++)
            {
                for (int j = 1; j < meshSizeY + 1; j++)
                {
                    timespace[time][i,j] = checkSurrounding(timespace[time - 1], timespace[time - 1][i, j], i, j); //sprawdza porzedni
                }
            }

        }

        private void evolution()
        {
            while (true)
            {
                maxTime++;
                currentTime++;
                //int[,] tmpUniverse = (int[,])timespace[currentTime].Clone();//Kopiuje obecny Może być tabula rasa?
                timespace.Add(new int[meshSizeX + 2, meshSizeY + 2]);
                grow(currentTime);
                //----
                currentUniverse = timespace[currentTime];
                drawUniverse();
                //dataGridView1.BeginInvoke((MethodInvoker)delegate
                //{
                //    drawUniverse();
                //});
                buttonStart.BeginInvoke((MethodInvoker)delegate
                {
                    buttonStart.Text = "Stop";
                });
                numericUpDownCurrentTime.BeginInvoke((MethodInvoker)delegate
                {
                    numericUpDownCurrentTime.Value = currentTime;
                });
                System.Threading.Thread.Sleep(delayTime);

                if (stopThread)
                {
                    return;
                }
            }

        }

        private void StartThreadEvolution()
        {
            if (workThread == null)
            {
                stopThread = false;
                workThread = new Thread(new ThreadStart(evolution));

                workThread.Start();
            }
        }

        private void StopThreadEvolution()
        {
            if (workThread != null)
            {
                stopThread = true;

                workThread.Join(); // This makes the code here pause until the Thread exits.

                workThread = null;
                
            }
        }

        void drawUniverse()//Zmienić żeby rysowało tylko dany czas
        {
            for (int x = 1; x < meshSizeX + 1; x++)
            {
                for (int y = 1; y < meshSizeY + 1; y++)
                {
                    
                    if (currentUniverse[x,y] == 1)
                    {
                        dataGridView1.Rows[x-1].Cells[y-1].Style.BackColor = Color.Black;
                    }
                    else
                    {
                        dataGridView1.Rows[x-1].Cells[y-1].Style.BackColor = Color.Yellow;
                       
                    }
                }
            }
        }


        private void buttonStart_Click(object sender, EventArgs e) // Trzeba to na nowych wątkach
        {
            if (reset == true)
            {
                initEvolution2D();
            }
            flag = !flag;
            if (flag == true)
            {
                numericUpDownCurrentTime.Maximum = int.MaxValue;
                trackBarCurrentTime.Maximum = int.MaxValue;
                trackBarCurrentTime.Enabled = false;
                numericUpDownCurrentTime.Enabled = false;
                reset = false;
                setDataGridView();
                StartThreadEvolution();

            }
            else
            {
                StopThreadEvolution();
                buttonStart.Text = "Start";
                trackBarCurrentTime.Enabled = true;
                numericUpDownCurrentTime.Enabled = true;
                numericUpDownCurrentTime.Maximum = maxTime;
                numericUpDownCurrentTime.Value = currentTime;
                trackBarCurrentTime.Maximum = maxTime;
                reset = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (workThread == null)
            {
                currentTime = trackBarCurrentTime.Value;
                numericUpDownCurrentTime.Value = currentTime;
                currentUniverse = timespace[currentTime];
                drawUniverse();
            }
        }

        private void numericUpDownCurrentTime_ValueChanged(object sender, EventArgs e)
        {
            if (workThread == null)
            {
                currentTime = (int)numericUpDownCurrentTime.Value;
                trackBarCurrentTime.Value = currentTime;
                currentUniverse = timespace[currentTime];
                drawUniverse();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (true)
            {
                int x = e.RowIndex;
                int y = e.ColumnIndex;
                currentUniverse[x + 1, y + 1] = 1;
                timespace[currentTime] = (int[,])currentUniverse.Clone();
                drawUniverse();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Zmiana tego resetuje
        {
            if (workThread == null)
            {
                numericUpDownCurrentTime.Maximum = int.MaxValue;
                trackBarCurrentTime.Maximum = int.MaxValue;
                trackBarCurrentTime.Enabled = false;
                numericUpDownCurrentTime.Enabled = false;
                setDataGridView();
                initEvolution2D();
                seed();
                reset = false;
                drawUniverse();
            }
        }

        private void buttonFaster_Click(object sender, EventArgs e)
        {
            delayTime = delayTime / 2;
        }

        private void buttonSlower_Click(object sender, EventArgs e)
        {
            delayTime = delayTime * 2;
        }

        private void numericUpDownMeshSizeX_ValueChanged(object sender, EventArgs e)
        {
            meshSizeX = (uint)numericUpDownMeshSizeX.Value;
            reset = true;
        }

        private void numericUpDownMeshSizeY_ValueChanged(object sender, EventArgs e)
        {
            meshSizeY = (uint)numericUpDownMeshSizeY.Value;
            reset = true;
        }
    }
}

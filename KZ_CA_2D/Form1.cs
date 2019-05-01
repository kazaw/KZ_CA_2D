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
        Bitmap image1;
        int meshSizeX;
        int meshSizeY;
        int maxTime;
        int currentTime;
        int[,] universe;
        List<int[,]> timespace;
        int delayTime;
        private volatile bool stopThread = false;
        private Thread workThread;
        bool flag = false;

        void initEvolution2D()
        {
            meshSizeX = (int)numericUpDownMeshSizeX.Value;
            meshSizeY = (int)numericUpDownMeshSizeY.Value;
            currentTime = 0;
            maxTime = 0;
            delayTime = 0;

            universe = new int[meshSizeX + 2, meshSizeY + 2];//+2 na warunki brzegowe
            


        }

        void checkRule(int time, int cell)//otrzymuje krok czasowy i numer komórki
        {

        }


        void startEvolution2D()//będzie tu jakieś warunki brzegowe etc
        {


        }

        public Form1() // zmienić te wartości na jakieś żeby się mieściły w pictureBox
        {
            InitializeComponent();
            pictureBox1.Size = new Size(1000,500);

            numericUpDownMeshSizeX.Minimum = 50;
            numericUpDownMeshSizeX.Maximum = 1000;
            numericUpDownMeshSizeY.Minimum = 50;
            numericUpDownMeshSizeY.Maximum = 1000;
        }

        private void evolution()
        {
            do
            {

            } while (stopThread);
            return;

            image1 = new Bitmap(meshSizeX, meshSizeY);
            drawUniverse(image1);
            pictureBox1.Image = image1;
            //buttonStart.Text = "Pulse";
            System.Threading.Thread.Sleep(delayTime);
            //buttonStart.Text = "Koniec";
            maxTime++;
            currentTime++;
            
            //if (stopThread)
            //{
            //    return;
            //}
        }

        private void StartThread()
        {
            if (workThread == null)
            {
                stopThread = false;
                workThread = new Thread(new ThreadStart(evolution));

                workThread.Start();
            }
        }

        private void StopThread()
        {
            if (workThread != null)
            {
                stopThread = true;

                workThread.Join(); // This makes the code here pause until the Thread exits.

                workThread = null;
            }
        }

        void drawUniverse(Bitmap universeImage)
        {
            for (int x = 1; x < meshSizeX + 1; x++)
            {
                for (int y = 1; y < meshSizeY + 1; y++)
                {
                    if (universe[x, y] == 1) universeImage.SetPixel(x - 1, y - 1, Color.Black);
                    else universeImage.SetPixel(x - 1, y - 1, Color.Yellow);
                }
            }
            image1 = universeImage;
        }


        private void buttonStart_Click(object sender, EventArgs e) // Trzeba to na nowych wątkach
        {
            flag = !flag;
            if (flag == true)
            {
                initEvolution2D();
                startEvolution2D();
                StartThread();
            }
            else StopThread();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentTime = trackBarCurrentTime.Value;
        }
    }
}

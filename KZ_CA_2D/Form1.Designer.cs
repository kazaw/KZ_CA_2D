namespace KZ_CA_1D
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownMeshSizeX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarCurrentTime = new System.Windows.Forms.TrackBar();
            this.numericUpDownMeshSizeY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCurrentTime = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonFaster = new System.Windows.Forms.Button();
            this.buttonSlower = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeshSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurrentTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeshSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(9, 29);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownMeshSizeX
            // 
            this.numericUpDownMeshSizeX.Location = new System.Drawing.Point(96, 30);
            this.numericUpDownMeshSizeX.Name = "numericUpDownMeshSizeX";
            this.numericUpDownMeshSizeX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMeshSizeX.TabIndex = 7;
            this.numericUpDownMeshSizeX.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownMeshSizeX.ValueChanged += new System.EventHandler(this.numericUpDownMeshSizeX_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "MeshSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time";
            // 
            // trackBarCurrentTime
            // 
            this.trackBarCurrentTime.Location = new System.Drawing.Point(268, 10);
            this.trackBarCurrentTime.Maximum = 100;
            this.trackBarCurrentTime.Name = "trackBarCurrentTime";
            this.trackBarCurrentTime.Size = new System.Drawing.Size(241, 56);
            this.trackBarCurrentTime.TabIndex = 11;
            this.trackBarCurrentTime.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // numericUpDownMeshSizeY
            // 
            this.numericUpDownMeshSizeY.Location = new System.Drawing.Point(96, 55);
            this.numericUpDownMeshSizeY.Name = "numericUpDownMeshSizeY";
            this.numericUpDownMeshSizeY.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMeshSizeY.TabIndex = 12;
            this.numericUpDownMeshSizeY.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownMeshSizeY.ValueChanged += new System.EventHandler(this.numericUpDownMeshSizeY_ValueChanged);
            // 
            // numericUpDownCurrentTime
            // 
            this.numericUpDownCurrentTime.Location = new System.Drawing.Point(516, 10);
            this.numericUpDownCurrentTime.Name = "numericUpDownCurrentTime";
            this.numericUpDownCurrentTime.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCurrentTime.TabIndex = 13;
            this.numericUpDownCurrentTime.ValueChanged += new System.EventHandler(this.numericUpDownCurrentTime_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 500);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Losowy",
            "Pusty",
            "Niezmienny",
            "Glider",
            "Oscylator"});
            this.comboBox1.Location = new System.Drawing.Point(643, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonFaster
            // 
            this.buttonFaster.Location = new System.Drawing.Point(771, 9);
            this.buttonFaster.Name = "buttonFaster";
            this.buttonFaster.Size = new System.Drawing.Size(75, 23);
            this.buttonFaster.TabIndex = 16;
            this.buttonFaster.Text = "Faster";
            this.buttonFaster.UseVisualStyleBackColor = true;
            this.buttonFaster.Click += new System.EventHandler(this.buttonFaster_Click);
            // 
            // buttonSlower
            // 
            this.buttonSlower.Location = new System.Drawing.Point(771, 39);
            this.buttonSlower.Name = "buttonSlower";
            this.buttonSlower.Size = new System.Drawing.Size(75, 23);
            this.buttonSlower.TabIndex = 17;
            this.buttonSlower.Text = "Slower";
            this.buttonSlower.UseVisualStyleBackColor = true;
            this.buttonSlower.Click += new System.EventHandler(this.buttonSlower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.buttonSlower);
            this.Controls.Add(this.buttonFaster);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDownCurrentTime);
            this.Controls.Add(this.numericUpDownMeshSizeY);
            this.Controls.Add(this.trackBarCurrentTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownMeshSizeX);
            this.Controls.Add(this.buttonStart);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeshSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurrentTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeshSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurrentTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownMeshSizeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarCurrentTime;
        private System.Windows.Forms.NumericUpDown numericUpDownMeshSizeY;
        private System.Windows.Forms.NumericUpDown numericUpDownCurrentTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonFaster;
        private System.Windows.Forms.Button buttonSlower;
    }
}


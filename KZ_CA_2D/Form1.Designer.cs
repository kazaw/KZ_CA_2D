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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDownMeshSizeX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarCurrentTime = new System.Windows.Forms.TrackBar();
            this.numericUpDownMeshSizeY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeshSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurrentTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeshSizeY)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(9, 82);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1000, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // numericUpDownMeshSizeX
            // 
            this.numericUpDownMeshSizeX.Location = new System.Drawing.Point(96, 30);
            this.numericUpDownMeshSizeX.Name = "numericUpDownMeshSizeX";
            this.numericUpDownMeshSizeX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMeshSizeX.TabIndex = 7;
            this.numericUpDownMeshSizeX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
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
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.numericUpDownMeshSizeY);
            this.Controls.Add(this.trackBarCurrentTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownMeshSizeX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonStart);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeshSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurrentTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeshSizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownMeshSizeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarCurrentTime;
        private System.Windows.Forms.NumericUpDown numericUpDownMeshSizeY;
    }
}


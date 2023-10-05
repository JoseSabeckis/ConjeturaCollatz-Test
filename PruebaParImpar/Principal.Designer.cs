
namespace PruebaParImpar
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.DgvGrilla = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDuda = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDuda = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.ckbIgual = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta:";
            // 
            // nudDesde
            // 
            this.nudDesde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudDesde.Location = new System.Drawing.Point(392, 65);
            this.nudDesde.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudDesde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(267, 35);
            this.nudDesde.TabIndex = 2;
            this.nudDesde.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudDesde_KeyPress);
            // 
            // nudHasta
            // 
            this.nudHasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nudHasta.Location = new System.Drawing.Point(392, 111);
            this.nudHasta.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudHasta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(267, 35);
            this.nudHasta.TabIndex = 3;
            this.nudHasta.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudHasta_KeyPress);
            // 
            // DgvGrilla
            // 
            this.DgvGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGrilla.Location = new System.Drawing.Point(0, 0);
            this.DgvGrilla.Name = "DgvGrilla";
            this.DgvGrilla.ReadOnly = true;
            this.DgvGrilla.Size = new System.Drawing.Size(852, 288);
            this.DgvGrilla.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(387, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "La Conjetura de Collatz";
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnControl.Location = new System.Drawing.Point(21, 92);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(132, 48);
            this.btnControl.TabIndex = 6;
            this.btnControl.Text = "Control";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PruebaParImpar.Properties.Resources.Figura3Collatz_kpvC__1248x698_abc;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTestResult);
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnDuda);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudHasta);
            this.panel1.Controls.Add(this.nudDesde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 172);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Se Recomienda Colocar El Mismo Num en Ambos\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Num Max:  8999999999999999999";
            // 
            // btnDuda
            // 
            this.btnDuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuda.Location = new System.Drawing.Point(284, 11);
            this.btnDuda.Name = "btnDuda";
            this.btnDuda.Size = new System.Drawing.Size(46, 36);
            this.btnDuda.TabIndex = 11;
            this.btnDuda.Text = "?";
            this.btnDuda.UseVisualStyleBackColor = true;
            this.btnDuda.Click += new System.EventHandler(this.btnDuda_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ckbIgual);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.lblDuda);
            this.panel3.Controls.Add(this.btnControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(676, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 170);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "\' ? \'";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Location = new System.Drawing.Point(21, 10);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(132, 48);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblDuda
            // 
            this.lblDuda.AutoSize = true;
            this.lblDuda.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuda.Location = new System.Drawing.Point(24, 148);
            this.lblDuda.Name = "lblDuda";
            this.lblDuda.Size = new System.Drawing.Size(99, 14);
            this.lblDuda.TabIndex = 10;
            this.lblDuda.Text = "Para Saber Tocar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DgvGrilla);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 290);
            this.panel2.TabIndex = 9;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(20, 19);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(17, 34);
            this.lblTest.TabIndex = 15;
            this.lblTest.Text = "-";
            this.lblTest.UseCompatibleTextRendering = true;
            // 
            // lblTestResult
            // 
            this.lblTestResult.AutoSize = true;
            this.lblTestResult.BackColor = System.Drawing.Color.Transparent;
            this.lblTestResult.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestResult.Location = new System.Drawing.Point(20, 47);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(17, 34);
            this.lblTestResult.TabIndex = 16;
            this.lblTestResult.Text = "-";
            this.lblTestResult.UseCompatibleTextRendering = true;
            // 
            // ckbIgual
            // 
            this.ckbIgual.AutoSize = true;
            this.ckbIgual.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIgual.Location = new System.Drawing.Point(51, 64);
            this.ckbIgual.Name = "ckbIgual";
            this.ckbIgual.Size = new System.Drawing.Size(82, 25);
            this.ckbIgual.TabIndex = 17;
            this.ckbIgual.Text = "Ambos";
            this.ckbIgual.UseVisualStyleBackColor = true;
            this.ckbIgual.CheckedChanged += new System.EventHandler(this.ckbIgual_CheckedChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(854, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(870, 501);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - Creador: Flores Jose Andres";
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.NumericUpDown nudHasta;
        public System.Windows.Forms.DataGridView DgvGrilla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDuda;
        private System.Windows.Forms.Button btnDuda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbIgual;
        public System.Windows.Forms.Label lblTestResult;
        public System.Windows.Forms.Label lblTest;
    }
}


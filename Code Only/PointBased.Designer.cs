namespace Project_Akhir_Computer_Vision
{
    partial class PointBased
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.radioGrayscale = new System.Windows.Forms.RadioButton();
            this.radioThreshold = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.processbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.cbthreshold = new System.Windows.Forms.ComboBox();
            this.HighValue = new System.Windows.Forms.NumericUpDown();
            this.lowValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.erorlabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowValue)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Akhir_Computer_Vision.Properties.Resources.KIC;
            this.pictureBox1.Location = new System.Drawing.Point(188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(120, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 211);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(15, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // browsebtn
            // 
            this.browsebtn.BackColor = System.Drawing.SystemColors.Control;
            this.browsebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsebtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.browsebtn.Location = new System.Drawing.Point(229, 288);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(82, 32);
            this.browsebtn.TabIndex = 7;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = false;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // radioGrayscale
            // 
            this.radioGrayscale.AutoSize = true;
            this.radioGrayscale.BackColor = System.Drawing.Color.Transparent;
            this.radioGrayscale.ForeColor = System.Drawing.Color.DarkKhaki;
            this.radioGrayscale.Location = new System.Drawing.Point(94, 330);
            this.radioGrayscale.Name = "radioGrayscale";
            this.radioGrayscale.Size = new System.Drawing.Size(72, 17);
            this.radioGrayscale.TabIndex = 8;
            this.radioGrayscale.TabStop = true;
            this.radioGrayscale.Text = "Grayscale";
            this.radioGrayscale.UseVisualStyleBackColor = false;
            // 
            // radioThreshold
            // 
            this.radioThreshold.AutoSize = true;
            this.radioThreshold.BackColor = System.Drawing.Color.Transparent;
            this.radioThreshold.ForeColor = System.Drawing.Color.DarkKhaki;
            this.radioThreshold.Location = new System.Drawing.Point(188, 330);
            this.radioThreshold.Name = "radioThreshold";
            this.radioThreshold.Size = new System.Drawing.Size(72, 17);
            this.radioThreshold.TabIndex = 9;
            this.radioThreshold.TabStop = true;
            this.radioThreshold.Text = "Threshold";
            this.radioThreshold.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label4.Location = new System.Drawing.Point(23, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(310, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Threshold";
            // 
            // processbtn
            // 
            this.processbtn.BackColor = System.Drawing.SystemColors.Control;
            this.processbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processbtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.processbtn.Location = new System.Drawing.Point(0, 3);
            this.processbtn.Name = "processbtn";
            this.processbtn.Size = new System.Drawing.Size(96, 32);
            this.processbtn.TabIndex = 14;
            this.processbtn.Text = "Process";
            this.processbtn.UseVisualStyleBackColor = false;
            this.processbtn.Click += new System.EventHandler(this.processbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.Control;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.savebtn.Location = new System.Drawing.Point(-3, 39);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(96, 32);
            this.savebtn.TabIndex = 15;
            this.savebtn.Text = "Save Image";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cbthreshold
            // 
            this.cbthreshold.FormattingEnabled = true;
            this.cbthreshold.Items.AddRange(new object[] {
            "Binary",
            "Binary Inverse",
            "To Zero",
            "To Zero Inverse",
            "Trunc"});
            this.cbthreshold.Location = new System.Drawing.Point(379, 368);
            this.cbthreshold.Name = "cbthreshold";
            this.cbthreshold.Size = new System.Drawing.Size(121, 21);
            this.cbthreshold.TabIndex = 16;
            // 
            // HighValue
            // 
            this.HighValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HighValue.Location = new System.Drawing.Point(379, 403);
            this.HighValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HighValue.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.HighValue.Name = "HighValue";
            this.HighValue.Size = new System.Drawing.Size(59, 20);
            this.HighValue.TabIndex = 17;
            this.HighValue.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // lowValue
            // 
            this.lowValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lowValue.Location = new System.Drawing.Point(379, 438);
            this.lowValue.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.lowValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.lowValue.Name = "lowValue";
            this.lowValue.Size = new System.Drawing.Size(59, 20);
            this.lowValue.TabIndex = 18;
            this.lowValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(310, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(314, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "High";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label5.Location = new System.Drawing.Point(314, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Low";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.processbtn);
            this.panel2.Controls.Add(this.savebtn);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(110, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 71);
            this.panel2.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // erorlabel
            // 
            this.erorlabel.AutoSize = true;
            this.erorlabel.ForeColor = System.Drawing.Color.Red;
            this.erorlabel.Location = new System.Drawing.Point(94, 452);
            this.erorlabel.Name = "erorlabel";
            this.erorlabel.Size = new System.Drawing.Size(0, 13);
            this.erorlabel.TabIndex = 23;
            // 
            // PointBased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Akhir_Computer_Vision.Properties.Resources.space05;
            this.ClientSize = new System.Drawing.Size(529, 491);
            this.Controls.Add(this.erorlabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowValue);
            this.Controls.Add(this.HighValue);
            this.Controls.Add(this.cbthreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioThreshold);
            this.Controls.Add(this.radioGrayscale);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PointBased";
            this.Text = "PointBased";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PointBased_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowValue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.RadioButton radioGrayscale;
        private System.Windows.Forms.RadioButton radioThreshold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button processbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ComboBox cbthreshold;
        private System.Windows.Forms.NumericUpDown HighValue;
        private System.Windows.Forms.NumericUpDown lowValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label erorlabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
namespace GlobalAddress
{
    partial class Form1
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
            this.txtTable1 = new System.Windows.Forms.TextBox();
            this.txtTable2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountryCodes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numErrorBounds = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.numSignif = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGS = new System.Windows.Forms.CheckBox();
            this.chkGE = new System.Windows.Forms.CheckBox();
            this.chkAV = new System.Windows.Forms.CheckBox();
            this.chkAE = new System.Windows.Forms.CheckBox();
            this.chkAC = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTable3 = new System.Windows.Forms.TextBox();
            this.txtTable4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTable5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTable6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numErrorBounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSignif)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTable1
            // 
            this.txtTable1.Location = new System.Drawing.Point(100, 64);
            this.txtTable1.Name = "txtTable1";
            this.txtTable1.Size = new System.Drawing.Size(150, 20);
            this.txtTable1.TabIndex = 0;
            this.txtTable1.Text = "ALLR1_DIST20180221";
            // 
            // txtTable2
            // 
            this.txtTable2.Location = new System.Drawing.Point(100, 101);
            this.txtTable2.Name = "txtTable2";
            this.txtTable2.Size = new System.Drawing.Size(150, 20);
            this.txtTable2.TabIndex = 1;
            this.txtTable2.Text = "ALLR1_DIST20180218Obj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Name 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table Name 2";
            // 
            // txtCountryCodes
            // 
            this.txtCountryCodes.Location = new System.Drawing.Point(100, 26);
            this.txtCountryCodes.Name = "txtCountryCodes";
            this.txtCountryCodes.Size = new System.Drawing.Size(503, 20);
            this.txtCountryCodes.TabIndex = 4;
            this.txtCountryCodes.Text = "AT,AU,CH,CL,CZ,DE,DK,FI,FR,GB,HR,IE,IS,LI,LT,MX,NL,NO,NZ,PL,SE,SG,ZA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Countries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Error Bounds";
            // 
            // numErrorBounds
            // 
            this.numErrorBounds.AccessibleName = "numErrorBounds";
            this.numErrorBounds.Location = new System.Drawing.Point(356, 64);
            this.numErrorBounds.Name = "numErrorBounds";
            this.numErrorBounds.Size = new System.Drawing.Size(89, 20);
            this.numErrorBounds.TabIndex = 8;
            this.numErrorBounds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(37, 394);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(166, 30);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // numSignif
            // 
            this.numSignif.Location = new System.Drawing.Point(356, 101);
            this.numSignif.Name = "numSignif";
            this.numSignif.Size = new System.Drawing.Size(89, 20);
            this.numSignif.TabIndex = 10;
            this.numSignif.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Significance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGS);
            this.groupBox1.Controls.Add(this.chkGE);
            this.groupBox1.Controls.Add(this.chkAV);
            this.groupBox1.Controls.Add(this.chkAE);
            this.groupBox1.Controls.Add(this.chkAC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(277, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 214);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkGS
            // 
            this.chkGS.AutoSize = true;
            this.chkGS.Location = new System.Drawing.Point(12, 147);
            this.chkGS.Name = "chkGS";
            this.chkGS.Size = new System.Drawing.Size(74, 17);
            this.chkGS.TabIndex = 5;
            this.chkGS.Text = "GS Codes";
            this.chkGS.UseVisualStyleBackColor = true;
            // 
            // chkGE
            // 
            this.chkGE.AutoSize = true;
            this.chkGE.Location = new System.Drawing.Point(12, 123);
            this.chkGE.Name = "chkGE";
            this.chkGE.Size = new System.Drawing.Size(74, 17);
            this.chkGE.TabIndex = 4;
            this.chkGE.Text = "GE Codes";
            this.chkGE.UseVisualStyleBackColor = true;
            // 
            // chkAV
            // 
            this.chkAV.AutoSize = true;
            this.chkAV.Location = new System.Drawing.Point(12, 99);
            this.chkAV.Name = "chkAV";
            this.chkAV.Size = new System.Drawing.Size(73, 17);
            this.chkAV.TabIndex = 3;
            this.chkAV.Text = "AV Codes";
            this.chkAV.UseVisualStyleBackColor = true;
            // 
            // chkAE
            // 
            this.chkAE.AutoSize = true;
            this.chkAE.Location = new System.Drawing.Point(12, 75);
            this.chkAE.Name = "chkAE";
            this.chkAE.Size = new System.Drawing.Size(73, 17);
            this.chkAE.TabIndex = 2;
            this.chkAE.Text = "AE Codes";
            this.chkAE.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            this.chkAC.AutoSize = true;
            this.chkAC.Location = new System.Drawing.Point(12, 51);
            this.chkAC.Name = "chkAC";
            this.chkAC.Size = new System.Drawing.Size(73, 17);
            this.chkAC.TabIndex = 1;
            this.chkAC.Text = "AC Codes";
            this.chkAC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Disable Result Codes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Table Name 3";
            // 
            // txtTable3
            // 
            this.txtTable3.Location = new System.Drawing.Point(100, 139);
            this.txtTable3.Name = "txtTable3";
            this.txtTable3.Size = new System.Drawing.Size(150, 20);
            this.txtTable3.TabIndex = 14;
            // 
            // txtTable4
            // 
            this.txtTable4.Location = new System.Drawing.Point(100, 178);
            this.txtTable4.Name = "txtTable4";
            this.txtTable4.Size = new System.Drawing.Size(150, 20);
            this.txtTable4.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Table Name 4";
            // 
            // txtTable5
            // 
            this.txtTable5.Location = new System.Drawing.Point(100, 214);
            this.txtTable5.Name = "txtTable5";
            this.txtTable5.Size = new System.Drawing.Size(150, 20);
            this.txtTable5.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Table Name 5";
            // 
            // txtTable6
            // 
            this.txtTable6.Location = new System.Drawing.Point(100, 250);
            this.txtTable6.Name = "txtTable6";
            this.txtTable6.Size = new System.Drawing.Size(150, 20);
            this.txtTable6.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Table Name 6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTable6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTable5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTable4);
            this.Controls.Add(this.txtTable3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSignif);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.numErrorBounds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCountryCodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTable2);
            this.Controls.Add(this.txtTable1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numErrorBounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSignif)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion 
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRun;
        public System.Windows.Forms.NumericUpDown numErrorBounds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTable1;
        public System.Windows.Forms.TextBox txtTable2;
        public System.Windows.Forms.TextBox txtCountryCodes;
        public System.Windows.Forms.NumericUpDown numSignif;
        public System.Windows.Forms.CheckBox chkGS;
        public System.Windows.Forms.CheckBox chkGE;
        public System.Windows.Forms.CheckBox chkAV;
        public System.Windows.Forms.CheckBox chkAE;
        public System.Windows.Forms.CheckBox chkAC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtTable3;
        public System.Windows.Forms.TextBox txtTable4;
        public System.Windows.Forms.TextBox txtTable5;
        public System.Windows.Forms.TextBox txtTable6;
    }
}


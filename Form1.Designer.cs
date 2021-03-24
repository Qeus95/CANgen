namespace CAN_GEN
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
            this.lineCTR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_intervalas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblByte1 = new System.Windows.Forms.Label();
            this.lblByte2 = new System.Windows.Forms.Label();
            this.lblByte3 = new System.Windows.Forms.Label();
            this.lblByte4 = new System.Windows.Forms.Label();
            this.lblByte5 = new System.Windows.Forms.Label();
            this.lblByte6 = new System.Windows.Forms.Label();
            this.lblByte7 = new System.Windows.Forms.Label();
            this.lblByte8 = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.tB4 = new System.Windows.Forms.TextBox();
            this.tB5 = new System.Windows.Forms.TextBox();
            this.tB6 = new System.Windows.Forms.TextBox();
            this.tB7 = new System.Windows.Forms.TextBox();
            this.tB8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCANID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLineCTR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lineCTR
            // 
            this.lineCTR.Location = new System.Drawing.Point(207, 126);
            this.lineCTR.MaxLength = 3;
            this.lineCTR.Name = "lineCTR";
            this.lineCTR.Size = new System.Drawing.Size(71, 20);
            this.lineCTR.TabIndex = 0;
            this.lineCTR.Text = "100";
            this.lineCTR.WordWrap = false;
            this.lineCTR.TextChanged += new System.EventHandler(this.lineCTR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 114);
            this.label1.TabIndex = 1;
            this.label1.Text = "Line generator";
            // 
            // lbl_intervalas
            // 
            this.lbl_intervalas.AutoSize = true;
            this.lbl_intervalas.Location = new System.Drawing.Point(41, 129);
            this.lbl_intervalas.Name = "lbl_intervalas";
            this.lbl_intervalas.Size = new System.Drawing.Size(160, 13);
            this.lbl_intervalas.TabIndex = 2;
            this.lbl_intervalas.Text = "Time interval between lines (ms):";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(788, 142);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblByte1
            // 
            this.lblByte1.AutoSize = true;
            this.lblByte1.Location = new System.Drawing.Point(295, 177);
            this.lblByte1.Name = "lblByte1";
            this.lblByte1.Size = new System.Drawing.Size(34, 13);
            this.lblByte1.TabIndex = 4;
            this.lblByte1.Text = "Byte1";
            this.lblByte1.Click += new System.EventHandler(this.lblByte1_Click);
            // 
            // lblByte2
            // 
            this.lblByte2.AutoSize = true;
            this.lblByte2.Location = new System.Drawing.Point(331, 177);
            this.lblByte2.Name = "lblByte2";
            this.lblByte2.Size = new System.Drawing.Size(34, 13);
            this.lblByte2.TabIndex = 5;
            this.lblByte2.Text = "Byte2";
            // 
            // lblByte3
            // 
            this.lblByte3.AutoSize = true;
            this.lblByte3.Location = new System.Drawing.Point(369, 177);
            this.lblByte3.Name = "lblByte3";
            this.lblByte3.Size = new System.Drawing.Size(34, 13);
            this.lblByte3.TabIndex = 6;
            this.lblByte3.Text = "Byte3";
            // 
            // lblByte4
            // 
            this.lblByte4.AutoSize = true;
            this.lblByte4.Location = new System.Drawing.Point(406, 177);
            this.lblByte4.Name = "lblByte4";
            this.lblByte4.Size = new System.Drawing.Size(34, 13);
            this.lblByte4.TabIndex = 7;
            this.lblByte4.Text = "Byte4";
            // 
            // lblByte5
            // 
            this.lblByte5.AutoSize = true;
            this.lblByte5.Location = new System.Drawing.Point(441, 177);
            this.lblByte5.Name = "lblByte5";
            this.lblByte5.Size = new System.Drawing.Size(34, 13);
            this.lblByte5.TabIndex = 8;
            this.lblByte5.Text = "Byte5";
            // 
            // lblByte6
            // 
            this.lblByte6.AutoSize = true;
            this.lblByte6.Location = new System.Drawing.Point(476, 177);
            this.lblByte6.Name = "lblByte6";
            this.lblByte6.Size = new System.Drawing.Size(34, 13);
            this.lblByte6.TabIndex = 9;
            this.lblByte6.Text = "Byte6";
            // 
            // lblByte7
            // 
            this.lblByte7.AutoSize = true;
            this.lblByte7.Location = new System.Drawing.Point(511, 177);
            this.lblByte7.Name = "lblByte7";
            this.lblByte7.Size = new System.Drawing.Size(34, 13);
            this.lblByte7.TabIndex = 10;
            this.lblByte7.Text = "Byte7";
            // 
            // lblByte8
            // 
            this.lblByte8.AutoSize = true;
            this.lblByte8.Location = new System.Drawing.Point(546, 177);
            this.lblByte8.Name = "lblByte8";
            this.lblByte8.Size = new System.Drawing.Size(34, 13);
            this.lblByte8.TabIndex = 11;
            this.lblByte8.Text = "Byte8";
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(298, 193);
            this.tB1.MaxLength = 2;
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(31, 20);
            this.tB1.TabIndex = 12;
            this.tB1.Text = "FF";
            this.tB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(335, 193);
            this.tB2.MaxLength = 2;
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(31, 20);
            this.tB2.TabIndex = 13;
            this.tB2.Text = "FF";
            this.tB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB3
            // 
            this.tB3.Location = new System.Drawing.Point(372, 193);
            this.tB3.MaxLength = 2;
            this.tB3.Name = "tB3";
            this.tB3.Size = new System.Drawing.Size(31, 20);
            this.tB3.TabIndex = 14;
            this.tB3.Text = "FF";
            this.tB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB4
            // 
            this.tB4.Location = new System.Drawing.Point(409, 193);
            this.tB4.MaxLength = 2;
            this.tB4.Name = "tB4";
            this.tB4.Size = new System.Drawing.Size(29, 20);
            this.tB4.TabIndex = 15;
            this.tB4.Text = "FF";
            this.tB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB5
            // 
            this.tB5.Location = new System.Drawing.Point(444, 193);
            this.tB5.MaxLength = 2;
            this.tB5.Name = "tB5";
            this.tB5.Size = new System.Drawing.Size(29, 20);
            this.tB5.TabIndex = 16;
            this.tB5.Text = "FF";
            this.tB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB6
            // 
            this.tB6.Location = new System.Drawing.Point(479, 193);
            this.tB6.MaxLength = 2;
            this.tB6.Name = "tB6";
            this.tB6.Size = new System.Drawing.Size(29, 20);
            this.tB6.TabIndex = 17;
            this.tB6.Text = "FF";
            this.tB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB7
            // 
            this.tB7.Location = new System.Drawing.Point(514, 193);
            this.tB7.MaxLength = 2;
            this.tB7.Name = "tB7";
            this.tB7.Size = new System.Drawing.Size(29, 20);
            this.tB7.TabIndex = 18;
            this.tB7.Text = "FF";
            this.tB7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB8
            // 
            this.tB8.Location = new System.Drawing.Point(549, 193);
            this.tB8.MaxLength = 2;
            this.tB8.Name = "tB8";
            this.tB8.Size = new System.Drawing.Size(29, 20);
            this.tB8.TabIndex = 19;
            this.tB8.Text = "FF";
            this.tB8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "CAN ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCANID
            // 
            this.tbCANID.Location = new System.Drawing.Point(207, 193);
            this.tbCANID.MaxLength = 8;
            this.tbCANID.Name = "tbCANID";
            this.tbCANID.Size = new System.Drawing.Size(71, 20);
            this.tbCANID.TabIndex = 21;
            this.tbCANID.Text = "1FFFFFFF";
            this.tbCANID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Line count:";
            // 
            // tbLineCTR
            // 
            this.tbLineCTR.Location = new System.Drawing.Point(207, 153);
            this.tbLineCTR.Name = "tbLineCTR";
            this.tbLineCTR.Size = new System.Drawing.Size(71, 20);
            this.tbLineCTR.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.tbLineCTR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCANID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB8);
            this.Controls.Add(this.tB7);
            this.Controls.Add(this.tB6);
            this.Controls.Add(this.tB5);
            this.Controls.Add(this.tB4);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.lblByte8);
            this.Controls.Add(this.lblByte7);
            this.Controls.Add(this.lblByte6);
            this.Controls.Add(this.lblByte5);
            this.Controls.Add(this.lblByte4);
            this.Controls.Add(this.lblByte3);
            this.Controls.Add(this.lblByte2);
            this.Controls.Add(this.lblByte1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_intervalas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineCTR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_intervalas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lineCTR;
        private System.Windows.Forms.Label lblByte1;
        private System.Windows.Forms.Label lblByte2;
        private System.Windows.Forms.Label lblByte3;
        private System.Windows.Forms.Label lblByte4;
        private System.Windows.Forms.Label lblByte5;
        private System.Windows.Forms.Label lblByte6;
        private System.Windows.Forms.Label lblByte7;
        private System.Windows.Forms.Label lblByte8;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.TextBox tB4;
        private System.Windows.Forms.TextBox tB5;
        private System.Windows.Forms.TextBox tB6;
        private System.Windows.Forms.TextBox tB7;
        private System.Windows.Forms.TextBox tB8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCANID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLineCTR;
    }
}


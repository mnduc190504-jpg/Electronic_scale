namespace calib_loadcell_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboBaud = new ComboBox();
            cboCOM = new ComboBox();
            btn_Con_Dis = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnSend = new Button();
            tboDATA = new TextBox();
            cboLEN = new ComboBox();
            cboCMD = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            tboDataSend = new TextBox();
            groupBox4 = new GroupBox();
            tboDataReceive = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 0;
            label1.Text = "Calib loadcell";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 51);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 1;
            label2.Text = "Chọn COM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 96);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 2;
            label3.Text = "Chọn Baudrate";
            // 
            // cboBaud
            // 
            cboBaud.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboBaud.FormattingEnabled = true;
            cboBaud.Location = new Point(176, 93);
            cboBaud.Name = "cboBaud";
            cboBaud.Size = new Size(151, 33);
            cboBaud.TabIndex = 3;
            // 
            // cboCOM
            // 
            cboCOM.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCOM.FormattingEnabled = true;
            cboCOM.Location = new Point(176, 48);
            cboCOM.Name = "cboCOM";
            cboCOM.Size = new Size(151, 33);
            cboCOM.TabIndex = 4;
            // 
            // btn_Con_Dis
            // 
            btn_Con_Dis.Location = new Point(11, 154);
            btn_Con_Dis.Name = "btn_Con_Dis";
            btn_Con_Dis.Size = new Size(155, 50);
            btn_Con_Dis.TabIndex = 5;
            btn_Con_Dis.Text = "Connect";
            btn_Con_Dis.UseVisualStyleBackColor = true;
            btn_Con_Dis.Click += btn_Con_Dis_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(189, 154);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(138, 50);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btn_Con_Dis);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboCOM);
            groupBox1.Controls.Add(cboBaud);
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 251);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Communicate";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSend);
            groupBox2.Controls.Add(tboDATA);
            groupBox2.Controls.Add(cboLEN);
            groupBox2.Controls.Add(cboCMD);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(380, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(596, 219);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Send_data";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(179, 156);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(114, 42);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tboDATA
            // 
            tboDATA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboDATA.Location = new Point(328, 88);
            tboDATA.Multiline = true;
            tboDATA.Name = "tboDATA";
            tboDATA.Size = new Size(114, 37);
            tboDATA.TabIndex = 9;
            // 
            // cboLEN
            // 
            cboLEN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLEN.FormattingEnabled = true;
            cboLEN.Location = new Point(179, 88);
            cboLEN.Name = "cboLEN";
            cboLEN.Size = new Size(114, 33);
            cboLEN.TabIndex = 6;
            // 
            // cboCMD
            // 
            cboCMD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCMD.FormattingEnabled = true;
            cboCMD.Location = new Point(26, 88);
            cboCMD.Name = "cboCMD";
            cboCMD.Size = new Size(114, 33);
            cboCMD.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(358, 46);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 4;
            label6.Text = "DATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(207, 46);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 3;
            label5.Text = "LEN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 46);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "CMD";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tboDataSend);
            groupBox3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 269);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 309);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "DataSend";
            // 
            // tboDataSend
            // 
            tboDataSend.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboDataSend.Location = new Point(11, 46);
            tboDataSend.Multiline = true;
            tboDataSend.Name = "tboDataSend";
            tboDataSend.Size = new Size(316, 257);
            tboDataSend.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tboDataReceive);
            groupBox4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(380, 269);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(596, 309);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "DataReceive";
            // 
            // tboDataReceive
            // 
            tboDataReceive.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboDataReceive.Location = new Point(16, 46);
            tboDataReceive.Multiline = true;
            tboDataReceive.Name = "tboDataReceive";
            tboDataReceive.Size = new Size(574, 257);
            tboDataReceive.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 590);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboBaud;
        private ComboBox cboCOM;
        private Button btn_Con_Dis;
        private Button btnExit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tboDATA;
        private ComboBox cboLEN;
        private ComboBox cboCMD;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnSend;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox tboDataSend;
        private TextBox tboDataReceive;
    }
}

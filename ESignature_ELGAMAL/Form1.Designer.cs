
namespace ESignature_ELGAMAL
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
            System.Windows.Forms.TabPage tab1;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreateKey = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBrowerSigned = new System.Windows.Forms.Button();
            this.btnBrowerUnsign = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtPathSignature = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.txtPathUnsign = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.openFileDialogToSign = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogToCheck = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            tab1 = new System.Windows.Forms.TabPage();
            tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            tab1.Controls.Add(this.splitContainer1);
            tab1.Location = new System.Drawing.Point(4, 29);
            tab1.Name = "tab1";
            tab1.Padding = new System.Windows.Forms.Padding(3);
            tab1.Size = new System.Drawing.Size(1295, 692);
            tab1.TabIndex = 0;
            tab1.Text = "Chữ kí số elgamal";
            tab1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateKey);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.btnBrowerSigned);
            this.splitContainer1.Panel2.Controls.Add(this.btnBrowerUnsign);
            this.splitContainer1.Panel2.Controls.Add(this.btnCheck);
            this.splitContainer1.Panel2.Controls.Add(this.txtPathSignature);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.btnSign);
            this.splitContainer1.Panel2.Controls.Add(this.txtShow);
            this.splitContainer1.Panel2.Controls.Add(this.txtPathUnsign);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.btnReset);
            this.splitContainer1.Panel2.Controls.Add(this.txtY);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtK);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitContainer1.Size = new System.Drawing.Size(1289, 686);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-1, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(427, 3);
            this.label10.TabIndex = 4;
            // 
            // btnCreateKey
            // 
            this.btnCreateKey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateKey.Location = new System.Drawing.Point(98, 463);
            this.btnCreateKey.Name = "btnCreateKey";
            this.btnCreateKey.Size = new System.Drawing.Size(232, 38);
            this.btnCreateKey.TabIndex = 3;
            this.btnCreateKey.Text = "Tạo khoá ngẫu nhiên";
            this.btnCreateKey.UseVisualStyleBackColor = true;
            this.btnCreateKey.Click += new System.EventHandler(this.BtnCreateKey_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.txtX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(27, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khoá bí mật (x)";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(241, 50);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(125, 30);
            this.txtX.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số nguyên x =";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.txtP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(27, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khoá công khai(p,a,d)";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(240, 115);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(125, 30);
            this.txtD.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(241, 74);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(125, 30);
            this.txtA.TabIndex = 4;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(241, 35);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(125, 30);
            this.txtP.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "(d = a ^ x mod p) số d =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số (alpha) a = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số nguyên tố ngẫu nhiên p =";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo khoá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(78, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Khóa công khai: (p, a, d)";
            // 
            // btnBrowerSigned
            // 
            this.btnBrowerSigned.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowerSigned.Location = new System.Drawing.Point(535, 546);
            this.btnBrowerSigned.Name = "btnBrowerSigned";
            this.btnBrowerSigned.Size = new System.Drawing.Size(82, 51);
            this.btnBrowerSigned.TabIndex = 19;
            this.btnBrowerSigned.Text = "Chọn tệp";
            this.btnBrowerSigned.UseVisualStyleBackColor = true;
            this.btnBrowerSigned.Click += new System.EventHandler(this.BtnBrowerSigned_Click);
            // 
            // btnBrowerUnsign
            // 
            this.btnBrowerUnsign.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowerUnsign.Location = new System.Drawing.Point(535, 136);
            this.btnBrowerUnsign.Name = "btnBrowerUnsign";
            this.btnBrowerUnsign.Size = new System.Drawing.Size(82, 51);
            this.btnBrowerUnsign.TabIndex = 18;
            this.btnBrowerUnsign.Text = "Chọn tệp";
            this.btnBrowerUnsign.UseVisualStyleBackColor = true;
            this.btnBrowerUnsign.Click += new System.EventHandler(this.BtnBrowerUnsign_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(660, 545);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(168, 48);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Kiểm tra chữ ký";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // txtPathSignature
            // 
            this.txtPathSignature.Enabled = false;
            this.txtPathSignature.Location = new System.Drawing.Point(78, 545);
            this.txtPathSignature.MaximumSize = new System.Drawing.Size(451, 50);
            this.txtPathSignature.MinimumSize = new System.Drawing.Size(451, 50);
            this.txtPathSignature.Multiline = true;
            this.txtPathSignature.Name = "txtPathSignature";
            this.txtPathSignature.Size = new System.Drawing.Size(451, 50);
            this.txtPathSignature.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(78, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(335, 23);
            this.label13.TabIndex = 13;
            this.label13.Text = "Chọn file thực hiện kiểm ra chữ ký số :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(78, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(344, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tệp chữ kí vào file văn bản được gửi đi:";
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSign.Location = new System.Drawing.Point(660, 139);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(168, 48);
            this.btnSign.TabIndex = 11;
            this.btnSign.Text = "Ký lên văn bản";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.BtnSign_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(78, 246);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShow.Size = new System.Drawing.Size(750, 224);
            this.txtShow.TabIndex = 10;
            // 
            // txtPathUnsign
            // 
            this.txtPathUnsign.Enabled = false;
            this.txtPathUnsign.Location = new System.Drawing.Point(78, 136);
            this.txtPathUnsign.Multiline = true;
            this.txtPathUnsign.Name = "txtPathUnsign";
            this.txtPathUnsign.Size = new System.Drawing.Size(451, 50);
            this.txtPathUnsign.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(3, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(855, 3);
            this.label11.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(78, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Chọn file thực hiện ký :";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(734, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Chọn lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(567, 49);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(121, 27);
            this.txtY.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(385, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "y = (a ^ k mod p) y =";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(231, 49);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(121, 27);
            this.txtK.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(78, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số ngẫu nhiên k =";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(855, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thực hiện ký";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tab1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1303, 725);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1295, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin tác giả";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1134, 489);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "29/05/2021";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1078, 460);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Được tạo bởi Phương Nam";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1295, 692);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Hướng dẫn sử dụng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // openFileDialogToSign
            // 
            this.openFileDialogToSign.FileName = "openFileDialog1";
            // 
            // openFileDialogToCheck
            // 
            this.openFileDialogToCheck.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 723);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            tab1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCreateKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox fileCheck;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.TextBox txtPathUnsign;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBrowerUnsign;
        private System.Windows.Forms.Button btnBrowerSigned;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBrowseUnsign;
        private System.Windows.Forms.Button btnBrowseSigned;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogToSign;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtPathSignature;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialogToCheck;
        private System.Windows.Forms.OpenFileDialog openFileDial2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
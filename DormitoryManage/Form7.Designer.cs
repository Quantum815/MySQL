namespace DormitoryManage
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelN2 = new System.Windows.Forms.Label();
            this.labelN1 = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonLiveInfo = new System.Windows.Forms.Button();
            this.ButtonMagInfo = new System.Windows.Forms.Button();
            this.ButtonStuInfo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonQuit.Location = new System.Drawing.Point(319, 419);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(200, 40);
            this.ButtonQuit.TabIndex = 6;
            this.ButtonQuit.Text = "退出";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelN);
            this.groupBox2.Controls.Add(this.labelN2);
            this.groupBox2.Controls.Add(this.labelN1);
            this.groupBox2.Controls.Add(this.ButtonOK);
            this.groupBox2.Controls.Add(this.TextBox);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(269, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 353);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "密码修改";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelN.ForeColor = System.Drawing.Color.Red;
            this.labelN.Location = new System.Drawing.Point(69, 148);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(55, 15);
            this.labelN.TabIndex = 26;
            this.labelN.Text = "      ";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelN2.ForeColor = System.Drawing.Color.Red;
            this.labelN2.Location = new System.Drawing.Point(97, 357);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(39, 15);
            this.labelN2.TabIndex = 25;
            this.labelN2.Text = "    ";
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelN1.ForeColor = System.Drawing.Color.Red;
            this.labelN1.Location = new System.Drawing.Point(324, 290);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(39, 15);
            this.labelN1.TabIndex = 24;
            this.labelN1.Text = "    ";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(103, 274);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(120, 40);
            this.ButtonOK.TabIndex = 18;
            this.ButtonOK.Text = "确认";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(73, 112);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 30);
            this.TextBox.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(18, 115);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 20);
            this.label.TabIndex = 8;
            this.label.Text = "密码";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonLiveInfo);
            this.groupBox1.Controls.Add(this.ButtonMagInfo);
            this.groupBox1.Controls.Add(this.ButtonStuInfo);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(36, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 353);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息管理";
            // 
            // ButtonLiveInfo
            // 
            this.ButtonLiveInfo.Location = new System.Drawing.Point(29, 148);
            this.ButtonLiveInfo.Name = "ButtonLiveInfo";
            this.ButtonLiveInfo.Size = new System.Drawing.Size(120, 60);
            this.ButtonLiveInfo.TabIndex = 2;
            this.ButtonLiveInfo.Text = "生活信息";
            this.ButtonLiveInfo.UseVisualStyleBackColor = true;
            this.ButtonLiveInfo.Click += new System.EventHandler(this.ButtonLiveInfo_Click);
            // 
            // ButtonMagInfo
            // 
            this.ButtonMagInfo.Location = new System.Drawing.Point(29, 254);
            this.ButtonMagInfo.Name = "ButtonMagInfo";
            this.ButtonMagInfo.Size = new System.Drawing.Size(120, 60);
            this.ButtonMagInfo.TabIndex = 1;
            this.ButtonMagInfo.Text = "公寓管理员信息";
            this.ButtonMagInfo.UseVisualStyleBackColor = true;
            this.ButtonMagInfo.Click += new System.EventHandler(this.ButtonMagInfo_Click);
            // 
            // ButtonStuInfo
            // 
            this.ButtonStuInfo.Location = new System.Drawing.Point(29, 47);
            this.ButtonStuInfo.Name = "ButtonStuInfo";
            this.ButtonStuInfo.Size = new System.Drawing.Size(120, 60);
            this.ButtonStuInfo.TabIndex = 0;
            this.ButtonStuInfo.Text = "学生信息";
            this.ButtonStuInfo.UseVisualStyleBackColor = true;
            this.ButtonStuInfo.Click += new System.EventHandler(this.ButtonStuInfo_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 473);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "总管理员的主页";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonMagInfo;
        private System.Windows.Forms.Button ButtonStuInfo;
        private System.Windows.Forms.Button ButtonLiveInfo;
        private System.Windows.Forms.Label labelN;
    }
}
namespace DormitoryManage
{
    partial class DormitoryManage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DormitoryManage));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelIdentify = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNameNull = new System.Windows.Forms.Label();
            this.labelPasswordNull = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("华文新魏", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTitle.Location = new System.Drawing.Point(15, 25);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(345, 40);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "学生公寓管理系统";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelName.Location = new System.Drawing.Point(65, 111);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(49, 20);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "账号";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPassword.Location = new System.Drawing.Point(65, 170);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(49, 20);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "密码";
            // 
            // LabelIdentify
            // 
            this.LabelIdentify.AutoSize = true;
            this.LabelIdentify.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelIdentify.Location = new System.Drawing.Point(65, 236);
            this.LabelIdentify.Name = "LabelIdentify";
            this.LabelIdentify.Size = new System.Drawing.Size(49, 20);
            this.LabelIdentify.TabIndex = 3;
            this.LabelIdentify.Text = "身份";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(155, 106);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(160, 25);
            this.TextName.TabIndex = 4;
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(155, 170);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(160, 25);
            this.TextPassword.TabIndex = 5;
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "总管理员",
            "公寓管理员",
            "学生"});
            this.ComboBox.Location = new System.Drawing.Point(155, 237);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(160, 23);
            this.ComboBox.TabIndex = 6;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonLogin.Location = new System.Drawing.Point(69, 289);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(250, 30);
            this.ButtonLogin.TabIndex = 7;
            this.ButtonLogin.Text = "登录";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(155, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 8;
            // 
            // labelNameNull
            // 
            this.labelNameNull.AutoSize = true;
            this.labelNameNull.ForeColor = System.Drawing.Color.Red;
            this.labelNameNull.Location = new System.Drawing.Point(156, 134);
            this.labelNameNull.Name = "labelNameNull";
            this.labelNameNull.Size = new System.Drawing.Size(55, 15);
            this.labelNameNull.TabIndex = 9;
            this.labelNameNull.Text = "      ";
            // 
            // labelPasswordNull
            // 
            this.labelPasswordNull.AutoSize = true;
            this.labelPasswordNull.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordNull.Location = new System.Drawing.Point(156, 198);
            this.labelPasswordNull.Name = "labelPasswordNull";
            this.labelPasswordNull.Size = new System.Drawing.Size(55, 15);
            this.labelPasswordNull.TabIndex = 10;
            this.labelPasswordNull.Text = "      ";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCancel.Location = new System.Drawing.Point(69, 350);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(250, 30);
            this.ButtonCancel.TabIndex = 11;
            this.ButtonCancel.Text = "取消";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOut
            // 
            this.ButtonOut.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonOut.Location = new System.Drawing.Point(69, 414);
            this.ButtonOut.Name = "ButtonOut";
            this.ButtonOut.Size = new System.Drawing.Size(250, 30);
            this.ButtonOut.TabIndex = 12;
            this.ButtonOut.Text = "退出";
            this.ButtonOut.UseVisualStyleBackColor = true;
            this.ButtonOut.Click += new System.EventHandler(this.ButtonOut_Click);
            // 
            // DormitoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(402, 473);
            this.Controls.Add(this.ButtonOut);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.labelPasswordNull);
            this.Controls.Add(this.labelNameNull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.LabelIdentify);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DormitoryManage";
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.DormitoryManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelIdentify;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNameNull;
        private System.Windows.Forms.Label labelPasswordNull;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOut;
    }
}


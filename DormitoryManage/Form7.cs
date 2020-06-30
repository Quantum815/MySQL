using MySQLDriverCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManage
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ButtonStuInfo_Click(object sender, EventArgs e)
        {
            StudentManage studentmanage = new StudentManage();
            studentmanage.Show();
        }

        private void ButtonLiveInfo_Click(object sender, EventArgs e)
        {
            StudentOther studentother = new StudentOther();
            studentother.Show();
        }

        private void ButtonMagInfo_Click(object sender, EventArgs e)
        {
            ManagerManage managermanage = new ManagerManage();
            managermanage.Show();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(TextBox.Text != "")
            {
                labelN.Text = "    ";
                PublicValue.ADMINPASWRD = TextBox.Text;
                MessageBox.Show("修改成功", "提示");   
            }
            else
                labelN.Text = "输入不能为空";
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DormitoryManage dormitorymanage = new DormitoryManage();
            dormitorymanage.Show();
        }
    }
}

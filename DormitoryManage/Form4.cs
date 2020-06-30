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
    public partial class ManagerHost : Form
    {
        public ManagerHost()
        {
            InitializeComponent();
            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
            ("localhost", "DormitoryManage", "root", "123456").AsString);
            string SQLstr = "SELECT managerName FROM manager_info where managerNumber = " + PublicValue.MAGNUM;
            SQLconnection.Open();
            MySQLCommand SQLcommand1 = new MySQLCommand("SET NAMES GB2312", SQLconnection);
            SQLcommand1.ExecuteNonQuery();   //执行设置字符集的语句
            MySQLCommand SQLcommand2 = new MySQLCommand(SQLstr, SQLconnection);
            MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand2.ExecuteReader();
            if (SQLreader.Read())
            {
                string temp = SQLreader["managerName"].ToString();
                this.Text = temp + "（公寓管理员）的主页";
            }
            SQLconnection.Close();
        }

        private void ManagerHost_Load(object sender, EventArgs e)
        {
            ButtonMagInfo.Focus();
        }

        private void ButtonMagInfo_Click(object sender, EventArgs e)
        {
            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
            ("localhost", "DormitoryManage", "root", "123456").AsString);
            string SQLstr = "SELECT * FROM manager_info WHERE managerNumber = " + PublicValue.MAGNUM;
            SQLconnection.Open();
            MySQLCommand SQLcommand1 = new MySQLCommand("SET NAMES GB2312", SQLconnection);
            SQLcommand1.ExecuteNonQuery();   //执行设置字符集的语句
            MySQLCommand SQLcommand2 = new MySQLCommand(SQLstr, SQLconnection);
            MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand2.ExecuteReader();
            if (SQLreader.Read())
            {
                this.TextBox1.Text = SQLreader["managerNumber"].ToString();
                this.TextBox2.Text = SQLreader["managerName"].ToString();
                this.TextBox3.Text = SQLreader["managerGender"].ToString();
                this.TextBox4.Text = SQLreader["managerAge"].ToString();
                this.TextBox5.Text = SQLreader["dormitoryNumber"].ToString();
                this.TextBox6.Text = SQLreader["managerPosition"].ToString();
                this.TextBox7.Text = SQLreader["managerPhone"].ToString();
                this.TextBox8.Text = SQLreader["managerPassword"].ToString();
            }
            SQLconnection.Close();
        }

        private void ButtonStuInfoM_Click(object sender, EventArgs e)
        {
            StudentManage studentmanage = new StudentManage();
            studentmanage.Show();
        }

        private void ButtonOther_Click(object sender, EventArgs e)
        {
            StudentOther studentother = new StudentOther();
            studentother.Show();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(TextBox7.Text == "" || TextBox8.Text == "")
            {
                if (TextBox7.Text == "")
                    labelN1.Text = "输入不能未空";
                else
                    labelN1.Text = "    ";
                if (TextBox8.Text == "")
                    labelN2.Text = "输入不能未空";
                else
                    labelN2.Text = "    ";
            }
            else
            {
                labelN1.Text = "    ";
                labelN2.Text = "    ";
                int flag = 0;
                string tempa = TextBox7.Text;
                string tempb = TextBox8.Text;
                MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
                ("localhost", "DormitoryManage", "root", "123456").AsString);
                string SQLstr1 = "SELECT * FROM manager_info WHERE managerNumber = " + PublicValue.MAGNUM;
                string SQLstr2 = "UPDATE manager_info set managerPhone = '" + TextBox7.Text + "',managerPassword = '" + TextBox8.Text + "'";
                SQLconnection.Open();
                MySQLCommand SQLcommand1 = new MySQLCommand("SET NAMES GB2312", SQLconnection);
                SQLcommand1.ExecuteNonQuery();   //执行设置字符集的语句
                MySQLCommand SQLcommand2 = new MySQLCommand(SQLstr1, SQLconnection);
                MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand2.ExecuteReader();
                if (SQLreader.Read())
                {
                    string oldtempa = SQLreader["managerPhone"].ToString();
                    string oldtempb = SQLreader["managerPassword"].ToString();
                    if (tempa != oldtempa || tempb != oldtempb)
                        flag = 1;
                }
                if (flag == 1)
                {
                    MySQLCommand SQLcommand3 = new MySQLCommand(SQLstr2, SQLconnection);
                    SQLcommand3.ExecuteNonQuery();
                    SQLconnection.Close();
                    MessageBox.Show("修改成功", "提示");
                }
            }          
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DormitoryManage dormitorymanage = new DormitoryManage();
            dormitorymanage.Show();
        }
    }
}

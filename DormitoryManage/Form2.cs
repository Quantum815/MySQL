using MySQLDriverCS;
using System;
using System.CodeDom.Compiler;
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
    public partial class StudentHost : Form
    {
        public StudentHost()
        {
            InitializeComponent();
            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
            ("localhost", "DormitoryManage", "root", "123456").AsString);
            string SQLstr = "SELECT studentName FROM student_info where studentNumber = " + PublicValue.STUNUM;
            SQLconnection.Open();
            MySQLCommand SQLcommand1 = new MySQLCommand("SET NAMES GB2312", SQLconnection);
            SQLcommand1.ExecuteNonQuery();   //执行设置字符集的语句
            MySQLCommand SQLcommand2 = new MySQLCommand(SQLstr, SQLconnection);
            MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand2.ExecuteReader();
            if (SQLreader.Read())
            {
                string temp = SQLreader["studentName"].ToString();
                this.Text = temp + "（学生）的主页";
            }
            SQLconnection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ButtonStuInfo.Focus();
        }

        private void ButtonStuInfo_Click(object sender, EventArgs e)
        {
            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
            ("localhost", "DormitoryManage", "root", "123456").AsString);
            string SQLstr = "SELECT * FROM student_info WHERE studentNumber = " + PublicValue.STUNUM;
            SQLconnection.Open();
            MySQLCommand SQLcommand1 = new MySQLCommand("SET NAMES GB2312", SQLconnection);
            SQLcommand1.ExecuteNonQuery();   //执行设置字符集的语句
            MySQLCommand SQLcommand2 = new MySQLCommand(SQLstr, SQLconnection);
            MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand2.ExecuteReader();
            if (SQLreader.Read())
            {
                this.TextBox1.Text = SQLreader["studentNumber"].ToString();
                this.TextBox2.Text = SQLreader["studentName"].ToString();
                this.TextBox3.Text = SQLreader["studentGender"].ToString();
                this.TextBox4.Text = SQLreader["studentAge"].ToString();
                this.TextBox5.Text = SQLreader["dormitoryNumber"].ToString();
                this.TextBox6.Text = SQLreader["roomNumber"].ToString();
                this.TextBox7.Text = SQLreader["studentMajor"].ToString();
                this.TextBox8.Text = SQLreader["studentPhone"].ToString();
                this.TextBox9.Text = SQLreader["studentPassword"].ToString();
            }
            SQLconnection.Close();
        }

        private void ButtonCheckIn_Click(object sender, EventArgs e)
        {
            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
            ("localhost", "DormitoryManage", "root", "123456").AsString);
            string SQLstr = "SELECT checkInTime,isChangeRoom FROM check_in WHERE studentNumber = " + PublicValue.STUNUM;
            SQLconnection.Open();
            MySQLCommand SQLcommand1 = new MySQLCommand("SET NAMES GB2312", SQLconnection);
            SQLcommand1.ExecuteNonQuery();   //执行设置字符集的语句
            MySQLCommand SQLcommand2 = new MySQLCommand(SQLstr, SQLconnection);
            MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand2.ExecuteReader();
            if (SQLreader.Read())
            {
                string tempa = SQLreader["checkInTime"].ToString();
                string tempb = SQLreader["isChangeRoom"].ToString();
                if(tempb == "是")
                    MessageBox.Show("        入住时间："+ tempa + "\n                       有换过寝室", "入住信息");
                if (tempb == "否")
                    MessageBox.Show("        入住时间：" + tempa + "\n                   没有换过寝室", "入住信息");
            }
            SQLconnection.Close();
        }

        private void ButtonLateReturn_Click(object sender, EventArgs e)
        {
            LateWtEl latewtel = new LateWtEl("0");
            latewtel.Show();
        }

        private void ButtonWtrElc_Click(object sender, EventArgs e)
        {
            LateWtEl latewtel = new LateWtEl("1");
            latewtel.Show();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBox8.Text == "" || TextBox9.Text == "")
            {
                if (TextBox8.Text == "")
                    labelN1.Text = "输入不能为空";
                else
                    labelN1.Text = "    ";
                if (TextBox9.Text == "")
                    labelN2.Text = "输入不能为空";
                else
                    labelN2.Text = "    ";
            }
            else
            {
                int flag = 0;
                string tempa = TextBox8.Text;
                string tempb = TextBox9.Text;
                MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
                ("localhost", "DormitoryManage", "root", "123456").AsString);
                string SQLstr1 = "SELECT * FROM student_info WHERE studentNumber = " + PublicValue.STUNUM;
                string SQLstr2 = "UPDATE student_info set studentPhone = '" + TextBox8.Text + "',studentPassword = '" + TextBox9.Text + "'";
                SQLconnection.Open();
                MySQLCommand SQLcommand1 = new MySQLCommand("SET NAMES GB2312", SQLconnection);
                SQLcommand1.ExecuteNonQuery();   //执行设置字符集的语句
                MySQLCommand SQLcommand2 = new MySQLCommand(SQLstr1, SQLconnection);
                MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand2.ExecuteReader();
                if (SQLreader.Read())
                {
                    string oldtempa = SQLreader["studentPhone"].ToString();
                    string oldtempb = SQLreader["studentPassword"].ToString();
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

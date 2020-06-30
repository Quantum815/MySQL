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
using System.Windows.Forms.VisualStyles;

namespace DormitoryManage
{
    public partial class DormitoryManage : Form
    {
        public DormitoryManage()
        {
            InitializeComponent();
        }
        private void DormitoryManage_Load(object sender, EventArgs e)
        {
            ComboBox.SelectedIndex = 0;
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(TextName.Text.Trim() == "" && TextPassword.Text.Trim() == "")
            {
                labelNameNull.Text = "账号不能为空";
                labelPasswordNull.Text = "密码不能为空";
                TextName.Focus();
            }
            else if(TextName.Text.Trim() == "")
            {
                labelNameNull.Text = "账号不能为空";
                labelPasswordNull.Text = "      ";
                TextName.Focus();
            }
            else if(TextPassword.Text.Trim() == "")
            {
                labelNameNull.Text = "      ";
                labelPasswordNull.Text = "密码不能为空";
                TextPassword.Focus();
            }
            else
            {
                labelNameNull.Text = "      ";
                labelPasswordNull.Text = "      ";

                string identify = ComboBox.SelectedItem.ToString();
                switch (identify)
                {
                    case "总管理员":
                        {
                            if (TextName.Text.Trim() != "admin" && TextPassword.Text.Trim() != PublicValue.ADMINPASWRD)
                            {
                                labelNameNull.Text = "账号输入错误";
                                labelPasswordNull.Text = "密码输入错误";
                                TextName.Focus();
                            }                             
                            else if(TextName.Text.Trim() != "admin")
                            {
                                labelNameNull.Text = "账号输入错误";
                                labelPasswordNull.Text = "      ";
                                TextName.Focus();
                            }
                            else if (TextPassword.Text.Trim() != PublicValue.ADMINPASWRD)
                            {
                                labelNameNull.Text = "      ";
                                labelPasswordNull.Text = "密码输入错误";
                                TextName.Focus();
                            }
                            else
                            {
                                MessageBox.Show("登录成功！", "提示");
                                this.Hide();
                                Admin admin = new Admin();
                                admin.Show();
                            }
                                
                            break;
                        }
                    case "公寓管理员":
                        {
                            int flag = 0;
                            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
                            ("localhost", "DormitoryManage", "root", "123456").AsString);
                            string SQLstr = "SELECT managerNumber, managerPassword FROM manager_info";
                            SQLconnection.Open();                          
                            MySQLCommand SQLcommand = new MySQLCommand(SQLstr, SQLconnection);
                            MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand.ExecuteReader();                         
                            while(SQLreader.Read())
                            {
                                string tempa = SQLreader["managerNumber"].ToString();  
                                string tempb = SQLreader["managerPassword"].ToString();  
                                if (TextName.Text.Trim() != tempa && TextPassword.Text.Trim() != tempb)
                                    flag = 0;
                                else if (TextName.Text.Trim() != tempa)
                                    flag = 1;
                                else if (TextPassword.Text.Trim() != tempb)
                                    flag = 2;
                                else
                                {
                                    flag = 3;
                                    break;
                                }
                            }
                            SQLconnection.Close();

                            if (flag == 0)
                            {
                                labelNameNull.Text = "账号输入错误";
                                labelPasswordNull.Text = "密码输入错误";
                                TextName.Focus();
                            }
                            else if (flag == 1)
                            {
                                labelNameNull.Text = "账号输入错误";
                                labelPasswordNull.Text = "      ";
                                TextName.Focus();
                            }
                            else if (flag == 2)
                            {
                                labelNameNull.Text = "      ";
                                labelPasswordNull.Text = "密码输入错误";
                                TextName.Focus();
                            }
                            else if (flag == 3)
                            {
                                MessageBox.Show("登录成功！", "提示");
                                PublicValue.MAGNUM = TextName.Text;
                                this.Hide();
                                ManagerHost managerhost = new ManagerHost();
                                managerhost.Show();
                            }
                            break;
                        }                      
                    case "学生":
                        {
                            int flag = 0;
                            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
                            ("localhost", "DormitoryManage", "root", "123456").AsString);
                            string SQLstr = "SELECT studentNumber, studentPassword FROM student_info";
                            SQLconnection.Open();
                            MySQLCommand SQLcommand1 = new MySQLCommand("SET NAMES GB2312", SQLconnection);
                            SQLcommand1.ExecuteNonQuery();   
                            MySQLCommand SQLcommand2 = new MySQLCommand(SQLstr, SQLconnection);
                            MySQLDataReader SQLreader = (MySQLDataReader)SQLcommand2.ExecuteReader();
                            while (SQLreader.Read())
                            {
                                string tempa = SQLreader["studentNumber"].ToString();  
                                string tempb = SQLreader["studentPassword"].ToString();  
                                if (TextName.Text.Trim() != tempa && TextPassword.Text.Trim() != tempb)
                                    flag = 0;
                                else if (TextName.Text.Trim() != tempa)
                                    flag = 1;
                                else if (TextPassword.Text.Trim() != tempb)
                                    flag = 2;
                                else
                                {
                                    flag = 3;
                                    break;
                                }
                            }
                            SQLconnection.Close();

                            if (flag == 0)
                            {
                                labelNameNull.Text = "账号输入错误";
                                labelPasswordNull.Text = "密码输入错误";
                                TextName.Focus();
                            }
                            else if (flag == 1)
                            {
                                labelNameNull.Text = "账号输入错误";
                                labelPasswordNull.Text = "      ";
                                TextName.Focus();
                            }
                            else if (flag == 2)
                            {
                                labelNameNull.Text = "      ";
                                labelPasswordNull.Text = "密码输入错误";
                                TextName.Focus();
                            }
                            else if (flag == 3)
                            {
                                MessageBox.Show("登录成功！", "提示");
                                PublicValue.STUNUM = TextName.Text;
                                this.Hide();
                                StudentHost studenthost = new StudentHost();
                                studenthost.Show();
                            }
                            break;
                        }                  
                }
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            TextName.Clear();
            TextPassword.Clear();
            TextName.Focus();
        }
        private void ButtonOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class PublicValue
    {
        public static string STUNUM;  //全局变量学号
        public static string MAGNUM;  //全局变量职工号
        public static string ADMINPASWRD = "admin";  //全局变量总管理员密码
    }
}

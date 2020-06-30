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
    public partial class StudentManage : Form
    {
        public StudentManage()
        {
            InitializeComponent();
        }

        private void StudentManage_Load(object sender, EventArgs e)
        {
            ComboBox.SelectedIndex = 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            string mode = ComboBox.SelectedItem.ToString();
            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
           ("localhost", "DormitoryManage", "root", "123456").AsString);
            SQLconnection.Open();
            MySQLCommand SQLcommand = new MySQLCommand("SET NAMES GB2312", SQLconnection);
            SQLcommand.ExecuteNonQuery();   //执行设置字符集的语句
            switch (mode)
            {
                case "查询":
                    {
                        if (TextBox1.Text != "")
                        {
                            string SQLstr = "SELECT studentNumber as '学号', dormitoryNumber as '公寓号',roomNumber as '寝室号'," +
                                "studentName as '姓名',studentGender as '性别',studentAge as '年龄',studentMajor as '专业'," +
                                "studentPhone as '电话',studentPassword as '密码' FROM student_info WHERE studentNumber = '" + TextBox1.Text +"'";
                            MySQLDataAdapter SQLadapter = new MySQLDataAdapter(SQLstr, SQLconnection);
                            DataSet set = new DataSet();
                            SQLadapter.Fill(set);
                            DataGridView.DataSource = set.Tables[0];
                            SQLconnection.Close();
                            MessageBox.Show("查询完成！", "提示");
                        }
                        else
                        {
                            string SQLstr = "SELECT studentNumber as '学号', dormitoryNumber as '公寓号',roomNumber as '寝室号'," +
                                 "studentName as '姓名',studentGender as '性别',studentAge as '年龄',studentMajor as '专业'," +
                                 "studentPhone as '电话',studentPassword as '密码' FROM student_info";
                            MySQLDataAdapter SQLadapter = new MySQLDataAdapter(SQLstr, SQLconnection);
                            DataSet set = new DataSet();
                            SQLadapter.Fill(set);
                            DataGridView.DataSource = set.Tables[0];
                            SQLconnection.Close();
                            MessageBox.Show("查询完成！", "提示");
                        }
                        break;
                    }
                case "添加":
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" ||
                        TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "")
                        {
                            if (TextBox1.Text == "")
                                labelN1.Text = "输入不能为空";
                            else
                                labelN1.Text = "    ";
                            if (TextBox2.Text == "")
                                labelN2.Text = "输入不能为空";
                            else
                                labelN2.Text = "    ";
                            if (TextBox3.Text == "")
                                labelN3.Text = "输入不能为空";
                            else
                                labelN3.Text = "    ";
                            if (TextBox4.Text == "")
                                labelN4.Text = "输入不能为空";
                            else
                                labelN4.Text = "    ";
                            if (TextBox5.Text == "")
                                labelN5.Text = "输入不能为空";
                            else
                                labelN5.Text = "    ";
                            if (TextBox6.Text == "")
                                labelN6.Text = "输入不能为空";
                            else
                                labelN6.Text = "    ";
                            if (TextBox7.Text == "")
                                labelN7.Text = "输入不能为空";
                            else
                                labelN7.Text = "    ";
                            if (TextBox8.Text == "")
                                labelN8.Text = "输入不能为空";
                            else
                                labelN8.Text = "    ";
                            if (TextBox9.Text == "")
                                labelN9.Text = "输入不能为空";
                            else
                                labelN9.Text = "    ";
                        }
                        else
                        {
                            labelN1.Text = "    ";
                            labelN2.Text = "    ";
                            labelN3.Text = "    ";
                            labelN4.Text = "    ";
                            labelN5.Text = "    ";
                            labelN6.Text = "    ";
                            labelN7.Text = "    ";
                            labelN8.Text = "    ";
                            labelN9.Text = "    ";
                            string SQLstr = "INSERT student_info VALUES('"+ TextBox1.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "'," +
                                "'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "'," +
                                "'" + TextBox9.Text + "')";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                            {
                                MessageBox.Show("添加成功！", "提示");
                            }
                            else
                            {
                                MessageBox.Show("添加失败！", "提示");
                            }
                        }
                        break;
                    }
                case "修改":
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" ||
                        TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "")
                        {
                            if (TextBox1.Text == "")
                                labelN1.Text = "输入不能为空";
                            else
                                labelN1.Text = "    ";
                            if (TextBox2.Text == "")
                                labelN2.Text = "输入不能为空";
                            else
                                labelN2.Text = "    ";
                            if (TextBox3.Text == "")
                                labelN3.Text = "输入不能为空";
                            else
                                labelN3.Text = "    ";
                            if (TextBox4.Text == "")
                                labelN4.Text = "输入不能为空";
                            else
                                labelN4.Text = "    ";
                            if (TextBox5.Text == "")
                                labelN5.Text = "输入不能为空";
                            else
                                labelN5.Text = "    ";
                            if (TextBox6.Text == "")
                                labelN6.Text = "输入不能为空";
                            else
                                labelN6.Text = "    ";
                            if (TextBox7.Text == "")
                                labelN7.Text = "输入不能为空";
                            else
                                labelN7.Text = "    ";
                            if (TextBox8.Text == "")
                                labelN8.Text = "输入不能为空";
                            else
                                labelN8.Text = "    ";
                            if (TextBox9.Text == "")
                                labelN9.Text = "输入不能为空";
                            else
                                labelN9.Text = "    ";
                        }
                        else
                        {
                            labelN1.Text = "    ";
                            labelN2.Text = "    ";
                            labelN3.Text = "    ";
                            labelN4.Text = "    ";
                            labelN5.Text = "    ";
                            labelN6.Text = "    ";
                            labelN7.Text = "    ";
                            labelN8.Text = "    ";
                            labelN9.Text = "    ";
                            int studentnumber = int.Parse(DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                            string SQLstr = "UPDATE student_info SET studentNumber = '{0}', dormitoryNumber = '{1}',roomNumber = '{2}'," +
                                "studentName = '{3}',studentGender = '{4}',studentAge = '{5}',studentMajor = '{6}'," +
                                "studentPhone = '{7}',studentPassword = '{8}'WHERE studentNumber = " + studentnumber;
                            SQLstr = string.Format(SQLstr, TextBox1.Text, TextBox5.Text, TextBox6.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text,
                                TextBox7.Text, TextBox8.Text, TextBox9.Text);
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("修改成功！", "提示");
                            else
                                MessageBox.Show("修改失败！", "提示");
                        }
                        break;
                    }
                case "删除":
                    {
                        if (TextBox1.Text != "")
                        {
                            string SQLstr = "DELETE FROM student_info WHERE studentNumber = '" + TextBox1.Text + "'";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("删除成功！", "提示");
                            else
                                MessageBox.Show("删除失败！", "提示");
                        }
                        else
                        {
                            string SQLstr = "TRUNCATE TABLE student_info";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("删除成功！", "提示");
                            else
                                MessageBox.Show("删除失败！", "提示");
                        }
                        break;
                    }
            }
            SQLconnection.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mode = ComboBox.SelectedItem.ToString();
            switch (mode)
            {
                case "查询":
                    {
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        break;
                    }
                case "添加":
                    {
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = false;
                        TextBox5.ReadOnly = false;
                        TextBox6.ReadOnly = false;
                        TextBox7.ReadOnly = false;
                        TextBox8.ReadOnly = false;
                        TextBox9.ReadOnly = false;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        break;
                    }
                case "修改":
                    {
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = false;
                        TextBox5.ReadOnly = false;
                        TextBox6.ReadOnly = false;
                        TextBox7.ReadOnly = false;
                        TextBox8.ReadOnly = false;
                        TextBox9.ReadOnly = false;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        break;
                    }
                case "删除":
                    {
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        TextBox9.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        break;
                    }
            }
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            string mode = ComboBox.SelectedItem.ToString();
            if (mode == "修改")
            {
                TextBox1.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                TextBox2.Text = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                TextBox3.Text = DataGridView.SelectedRows[0].Cells[4].Value.ToString();
                TextBox4.Text = DataGridView.SelectedRows[0].Cells[5].Value.ToString();
                TextBox5.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                TextBox6.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                TextBox7.Text = DataGridView.SelectedRows[0].Cells[6].Value.ToString();
                TextBox8.Text = DataGridView.SelectedRows[0].Cells[7].Value.ToString();
                TextBox9.Text = DataGridView.SelectedRows[0].Cells[8].Value.ToString();
            }
        }
    }
}

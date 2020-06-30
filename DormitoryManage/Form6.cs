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
    public partial class StudentOther : Form
    {
        public StudentOther()
        {
            InitializeComponent();
        }

        private void StudentOther_Load(object sender, EventArgs e)
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
                case "入住信息 查询":
                    {
                        if (TextBox1.Text != "")
                        {
                            string SQLstr = "SELECT studentNumber as '学号', dormitoryNumber as '公寓号',roomNumber as '寝室号'," +
                                "checkInTime as '入住时间',isChangeRoom as '换寝情况' FROM check_in WHERE studentNumber = '" + TextBox1.Text + "'";
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
                                "checkInTime as '入住时间',isChangeRoom as '换寝情况' FROM check_in";
                            MySQLDataAdapter SQLadapter = new MySQLDataAdapter(SQLstr, SQLconnection);
                            DataSet set = new DataSet();
                            SQLadapter.Fill(set);
                            DataGridView.DataSource = set.Tables[0];
                            SQLconnection.Close();
                            MessageBox.Show("查询完成！", "提示");
                        }                   
                        break;
                    }
                case "入住信息 添加":
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
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
                        }
                        else
                        {
                            labelN1.Text = "    ";
                            labelN2.Text = "    ";
                            labelN3.Text = "    ";
                            labelN4.Text = "    ";
                            labelN5.Text = "    ";
                            string SQLstr = "INSERT check_in VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," +
                                "'" + TextBox4.Text + "','" + TextBox5.Text + "')";
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
                case "入住信息 修改":
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
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
                            labelN10.Text = "    ";
                            labelN11.Text = "    ";
                            int studentnumber = int.Parse(DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                            string SQLstr = "UPDATE check_in SET studentNumber = '{0}', dormitoryNumber = '{1}',roomNumber = '{2}'," +
                                "checkInTime = '{3}',isChangeRoom = '{4}' WHERE studentNumber = " + studentnumber;
                            SQLstr = string.Format(SQLstr, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("修改成功！", "提示");
                            else
                                MessageBox.Show("修改失败！", "提示");
                        }
                        break;
                    }
                case "入住信息 删除":
                    {
                        if (TextBox1.Text != "")
                        {
                            string SQLstr = "DELETE FROM check_in WHERE studentNumber = '" + TextBox1.Text + "'";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("删除成功！", "提示");
                            else
                                MessageBox.Show("删除失败！", "提示");
                        }
                        else
                        {
                            string SQLstr = "TRUNCATE TABLE check_in";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("删除成功！", "提示");
                            else
                                MessageBox.Show("删除失败！", "提示");
                        }
                        break;
                    }
                case "晚归信息 查询":
                    {
                        if (TextBox1.Text != "")
                        {
                            string SQLstr = "SELECT studentNumber as '学号', dormitoryNumber as '公寓号',roomNumber as '寝室号'," +
                                "lateReturnTime as '晚归时间' FROM late_return WHERE studentNumber = '" + TextBox1.Text + "'";
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
                                "lateReturnTime as '晚归时间' FROM late_return";
                            MySQLDataAdapter SQLadapter = new MySQLDataAdapter(SQLstr, SQLconnection);
                            DataSet set = new DataSet();
                            SQLadapter.Fill(set);
                            DataGridView.DataSource = set.Tables[0];
                            SQLconnection.Close();
                            MessageBox.Show("查询完成！", "提示");
                        }
                        break;
                    }
                case "晚归信息 添加":
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox7.Text == "")
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
                            if (TextBox7.Text == "")
                                labelN7.Text = "输入不能为空";
                            else
                                labelN7.Text = "    ";
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
                            labelN10.Text = "    ";
                            labelN11.Text = "    ";
                            string SQLstr = "INSERT late_return VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," +
                                "'" + TextBox7.Text + "')";
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
                case "晚归信息 修改":
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox7.Text == "")
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
                            if (TextBox7.Text == "")
                                labelN7.Text = "输入不能为空";
                            else
                                labelN7.Text = "    ";
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
                            labelN10.Text = "    ";
                            labelN11.Text = "    ";
                            string SQLstr = "UPDATE late_return SET studentNumber = '{0}', dormitoryNumber = '{1}',roomNumber = '{2}'," +
                                "lateReturnTime = '{3}' WHERE studentNumber = '" + TextBox1.Text + "' and lateReturnTime = '"
                                + TextBox7.Text + "'";
                            SQLstr = string.Format(SQLstr, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox7.Text);
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("修改成功！", "提示");
                            else
                                MessageBox.Show("修改失败！", "提示");
                        }
                        break;
                    }
                case "晚归信息 删除":
                    {
                        if (TextBox1.Text != "")
                        {
                            string SQLstr = "DELETE FROM late_return WHERE studentNumber = '" + TextBox1.Text + "'";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("删除成功！", "提示");
                            else
                                MessageBox.Show("删除失败！", "提示");
                        }
                        else
                        {
                            string SQLstr = "TRUNCATE TABLE late_return";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("删除成功！", "提示");
                            else
                                MessageBox.Show("删除失败！", "提示");
                        }
                        break;
                    }
                case "水电信息 查询":
                    {
                        if (TextBox2.Text != "" && TextBox3.Text != "")
                        {
                            labelN2.Text = "    ";
                            labelN3.Text = "    ";
                            string SQLstr = "SELECT dormitoryNumber as '公寓号',roomNumber as '寝室号',studentNumber as '学号'," +
                                "checkMonth as '日期',electricityConsumption as '用电量',electricityBill as '电费',waterConsumption" +
                                " as '用水量',waterBill as '水费' FROM water_electricity WHERE dormitoryNumber = '" + TextBox2.Text + "'" +
                                "and roomNumber = '" + TextBox3.Text + "'";
                            MySQLDataAdapter SQLadapter = new MySQLDataAdapter(SQLstr, SQLconnection);
                            DataSet set = new DataSet();
                            SQLadapter.Fill(set);
                            DataGridView.DataSource = set.Tables[0];
                            SQLconnection.Close();
                            MessageBox.Show("查询完成！", "提示");
                        }
                        else if (TextBox2.Text != "")
                        {
                            labelN3.Text = "输入不能为空";
                        }
                        else if (TextBox3.Text != "")
                        {
                            labelN2.Text = "输入不能为空";
                        }
                        else
                        {
                            labelN2.Text = "    ";
                            labelN3.Text = "    ";
                            string SQLstr = "SELECT dormitoryNumber as '公寓号',roomNumber as '寝室号',studentNumber as '学号'," +
                                "checkMonth as '日期',electricityConsumption as '用电量',electricityBill as '电费',waterConsumption" +
                                " as '用水量',waterBill as '水费' FROM water_electricity";
                            MySQLDataAdapter SQLadapter = new MySQLDataAdapter(SQLstr, SQLconnection);
                            DataSet set = new DataSet();
                            SQLadapter.Fill(set);
                            DataGridView.DataSource = set.Tables[0];
                            SQLconnection.Close();
                            MessageBox.Show("查询完成！", "提示");  
                        }
                        break;
                    }
                case "水电信息 添加":
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox6.Text == "" || TextBox8.Text == "" ||
                            TextBox9.Text == "" || TextBox10.Text == "" || TextBox11.Text == "")
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
                            if (TextBox6.Text == "")
                                labelN6.Text = "输入不能为空";
                            else
                                labelN6.Text = "    ";
                            if (TextBox8.Text == "")
                                labelN8.Text = "输入不能为空";
                            else
                                labelN8.Text = "    ";
                            if (TextBox9.Text == "")
                                labelN9.Text = "输入不能为空";
                            else
                                labelN9.Text = "    ";
                            if (TextBox10.Text == "")
                                labelN10.Text = "输入不能为空";
                            else
                                labelN10.Text = "    ";
                            if (TextBox11.Text == "")
                                labelN11.Text = "输入不能为空";
                            else
                                labelN11.Text = "    ";
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
                            labelN10.Text = "    ";
                            labelN11.Text = "    ";
                            string SQLstr = "INSERT water_electricity VALUES('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox1.Text + "'," +
                                "'" + TextBox6.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "')";
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
                case "水电信息 修改":
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox6.Text == "" || TextBox8.Text == "" ||
                        TextBox9.Text == "" || TextBox10.Text == "" || TextBox11.Text == "")
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
                            if (TextBox6.Text == "")
                                labelN6.Text = "输入不能为空";
                            else
                                labelN6.Text = "    ";
                            if (TextBox8.Text == "")
                                labelN8.Text = "输入不能为空";
                            else
                                labelN8.Text = "    ";
                            if (TextBox9.Text == "")
                                labelN9.Text = "输入不能为空";
                            else
                                labelN9.Text = "    ";
                            if (TextBox10.Text == "")
                                labelN10.Text = "输入不能为空";
                            else
                                labelN10.Text = "    ";
                            if (TextBox11.Text == "")
                                labelN11.Text = "输入不能为空";
                            else
                                labelN11.Text = "    ";
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
                            labelN10.Text = "    ";
                            labelN11.Text = "    ";

                            string SQLstr = "UPDATE water_electricity SET dormitoryNumber = '{0}', roomNumber = '{1}',studentNumber = '{2}'," +
                                "checkMonth = '{3}',electricityConsumption = '{4}',electricityBill = '{5}',waterConsumption = '{6}'," +
                                "waterBill = '{7}' WHERE dormitoryNumber = '" + TextBox2.Text + "'" +
                                    "and roomNumber = '" + TextBox3.Text + "'";
                            SQLstr = string.Format(SQLstr, TextBox2.Text, TextBox3.Text, TextBox1.Text, TextBox6.Text, TextBox8.Text, TextBox9.Text,
                                TextBox10.Text, TextBox11.Text);
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("修改成功！", "提示");
                            else
                                MessageBox.Show("修改失败！", "提示");
                        }
                        break;
                    }
                case "水电信息 删除":
                    {
                        if (TextBox2.Text != "" && TextBox3.Text != "")
                        {
                            labelN2.Text = "    ";
                            labelN3.Text = "    ";
                            string SQLstr = "DELETE FROM water_electricity WHERE dormitoryNumber = '" + TextBox2.Text + "'" +
                                    "and roomNumber = '" + TextBox3.Text + "'";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("删除成功！", "提示");
                            else
                                MessageBox.Show("删除失败！", "提示");
                        }
                        else if (TextBox2.Text != "")
                        {
                            labelN3.Text = "输入不能为空";
                        }
                        else if (TextBox3.Text != "")
                        {
                            labelN2.Text = "输入不能为空";
                        }
                        else
                        {
                            labelN2.Text = "    ";
                            labelN3.Text = "    ";
                            string SQLstr = "TRUNCATE TABLE water_electricity";
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
                case "入住信息 查询":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "入住信息 添加":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = false;
                        TextBox5.ReadOnly = false;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "入住信息 修改":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = false;
                        TextBox5.ReadOnly = false;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "入住信息 删除":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "晚归信息 查询":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "晚归信息 添加":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = false;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "晚归信息 修改":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = false;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "晚归信息 删除":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "水电信息 查询":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = true;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "水电信息 添加":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = false;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = false;
                        TextBox9.ReadOnly = false;
                        TextBox10.ReadOnly = false;
                        TextBox11.ReadOnly = false;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "水电信息 修改":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = false;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = false;
                        TextBox9.ReadOnly = false;
                        TextBox10.ReadOnly = false;
                        TextBox11.ReadOnly = false;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
                case "水电信息 删除":
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
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox1.ReadOnly = true;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        TextBox9.ReadOnly = true;
                        TextBox10.ReadOnly = true;
                        TextBox11.ReadOnly = true;
                        labelN1.Text = "    ";
                        labelN2.Text = "    ";
                        labelN3.Text = "    ";
                        labelN4.Text = "    ";
                        labelN5.Text = "    ";
                        labelN6.Text = "    ";
                        labelN7.Text = "    ";
                        labelN8.Text = "    ";
                        labelN9.Text = "    ";
                        labelN10.Text = "    ";
                        labelN11.Text = "    ";
                        break;
                    }
            }
        }
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mode = ComboBox.SelectedItem.ToString();
            if (mode == "入住信息 修改")
            {
                TextBox1.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                TextBox2.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                TextBox3.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                TextBox4.Text = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                TextBox5.Text = DataGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
            if (mode == "晚归信息 修改")
            {
                TextBox1.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                TextBox2.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                TextBox3.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                TextBox7.Text = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
            if (mode == "水电信息 修改")
            {
                TextBox1.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                TextBox2.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                TextBox3.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                TextBox6.Text = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                TextBox8.Text = DataGridView.SelectedRows[0].Cells[5].Value.ToString();
                TextBox9.Text = DataGridView.SelectedRows[0].Cells[4].Value.ToString();
                TextBox10.Text = DataGridView.SelectedRows[0].Cells[7].Value.ToString();
                TextBox11.Text = DataGridView.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
    }
}

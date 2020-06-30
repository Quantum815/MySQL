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
    public partial class ManagerManage : Form
    {
        public ManagerManage()
        {
            InitializeComponent();
        }

        private void ManagerManage_Load(object sender, EventArgs e)
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
            SQLcommand.ExecuteNonQuery();   
            switch (mode)
            {
                case "查询":
                    {
                        if (TextBox1.Text != "")
                        {
                            string SQLstr = "SELECT managerNumber as '职工号', dormitoryNumber as '公寓号',managerName as '姓名'," +
                                "managerGender as '性别',managerAge as '年龄', managerPhone as '电话',managerPosition as '职位'," +
                                "managerPassword as '密码' FROM manager_info WHERE managerNumber = '" + TextBox1.Text + "'";
                            MySQLDataAdapter SQLadapter = new MySQLDataAdapter(SQLstr, SQLconnection);
                            DataSet set = new DataSet();
                            SQLadapter.Fill(set);
                            DataGridView.DataSource = set.Tables[0];
                            SQLconnection.Close();
                            MessageBox.Show("查询完成！", "提示");
                        }
                        else
                        {
                            string SQLstr = "SELECT managerNumber as '职工号', dormitoryNumber as '公寓号',managerName as '姓名'," +
                                "managerGender as '性别', managerAge as '年龄', managerPhone as '电话', managerPosition as '职位'," +
                                "managerPassword as '密码' FROM manager_info";
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
                        TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "")
                        {
                            if (TextBox1.Text == "")
                                labelNull1.Text = "输入不能为空";
                            else
                                labelNull1.Text = "    ";
                            if (TextBox2.Text == "")
                                labelNull2.Text = "输入不能为空";
                            else
                                labelNull2.Text = "    ";
                            if (TextBox3.Text == "")
                                labelNull3.Text = "输入不能为空";
                            else
                                labelNull3.Text = "    ";
                            if (TextBox4.Text == "")
                                labelNull4.Text = "输入不能为空";
                            else
                                labelNull4.Text = "    ";
                            if (TextBox5.Text == "")
                                labelNull5.Text = "输入不能为空";
                            else
                                labelNull5.Text = "    ";
                            if (TextBox6.Text == "")
                                labelNull6.Text = "输入不能为空";
                            else
                                labelNull6.Text = "    ";
                            if (TextBox7.Text == "")
                                labelNull7.Text = "输入不能为空";
                            else
                                labelNull7.Text = "    ";
                            if (TextBox8.Text == "")
                                labelNull8.Text = "输入不能为空";
                            else
                                labelNull8.Text = "    ";
                        }
                        else
                        {
                            labelNull1.Text = "    ";
                            labelNull2.Text = "    ";
                            labelNull3.Text = "    ";
                            labelNull4.Text = "    ";
                            labelNull5.Text = "    ";
                            labelNull6.Text = "    ";
                            labelNull7.Text = "    ";
                            labelNull8.Text = "    ";
                            string SQLstr = "INSERT manager_info VALUES('" + TextBox1.Text + "','" + TextBox5.Text + "','" + TextBox2.Text + "'," +
                            "'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox7.Text + "','" + TextBox6.Text + "','" + TextBox8.Text + "')";
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
                        TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "")
                        {
                            if (TextBox1.Text == "")
                                labelNull1.Text = "输入不能为空";
                            else
                                labelNull1.Text = "    ";
                            if (TextBox2.Text == "")
                                labelNull2.Text = "输入不能为空";
                            else
                                labelNull2.Text = "    ";
                            if (TextBox3.Text == "")
                                labelNull3.Text = "输入不能为空";
                            else
                                labelNull3.Text = "    ";
                            if (TextBox4.Text == "")
                                labelNull4.Text = "输入不能为空";
                            else
                                labelNull4.Text = "    ";
                            if (TextBox5.Text == "")
                                labelNull5.Text = "输入不能为空";
                            else
                                labelNull5.Text = "    ";
                            if (TextBox6.Text == "")
                                labelNull6.Text = "输入不能为空";
                            else
                                labelNull6.Text = "    ";
                            if (TextBox7.Text == "")
                                labelNull7.Text = "输入不能为空";
                            else
                                labelNull7.Text = "    ";
                            if (TextBox8.Text == "")
                                labelNull8.Text = "输入不能为空";
                            else
                                labelNull8.Text = "    ";
                        }
                        else
                        {
                            labelNull1.Text = "    ";
                            labelNull2.Text = "    ";
                            labelNull3.Text = "    ";
                            labelNull4.Text = "    ";
                            labelNull5.Text = "    ";
                            labelNull6.Text = "    ";
                            labelNull7.Text = "    ";
                            labelNull8.Text = "    ";
                            int managernumber = int.Parse(DataGridView.SelectedRows[0].Cells[0].Value.ToString());
                            string SQLstr = "UPDATE manager_info SET managerNumber = '{0}', dormitoryNumber = '{1}'," +
                                "managerName = '{2}',managerGender = '{3}',managerAge = '{4}',managerPhone = '{5}'," +
                                "managerPosition = '{7}',managerPassword = '{7}'WHERE managerNumber = " + managernumber;
                            SQLstr = string.Format(SQLstr,TextBox1.Text, TextBox5.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text,
                                TextBox7.Text, TextBox6.Text, TextBox8.Text);
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
                            string SQLstr = "DELETE FROM manager_info WHERE managerNumber = '" + TextBox1.Text + "'";
                            MySQLCommand sqlcommand = new MySQLCommand(SQLstr, SQLconnection);
                            if (sqlcommand.ExecuteNonQuery() != -1)
                                MessageBox.Show("删除成功！", "提示");
                            else
                                MessageBox.Show("删除失败！", "提示");
                        }
                        else
                        {
                            string SQLstr = "TRUNCATE TABLE manager_info";
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
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        labelNull1.Text = "    ";
                        labelNull2.Text = "    ";
                        labelNull3.Text = "    ";
                        labelNull4.Text = "    ";
                        labelNull5.Text = "    ";
                        labelNull6.Text = "    ";
                        labelNull7.Text = "    ";
                        labelNull8.Text = "    ";
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
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = false;
                        TextBox5.ReadOnly = false;
                        TextBox6.ReadOnly = false;
                        TextBox7.ReadOnly = false;
                        TextBox8.ReadOnly = false;
                        labelNull1.Text = "    ";
                        labelNull2.Text = "    ";
                        labelNull3.Text = "    ";
                        labelNull4.Text = "    ";
                        labelNull5.Text = "    ";
                        labelNull6.Text = "    ";
                        labelNull7.Text = "    ";
                        labelNull8.Text = "    ";
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
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox3.ReadOnly = false;
                        TextBox4.ReadOnly = false;
                        TextBox5.ReadOnly = false;
                        TextBox6.ReadOnly = false;
                        TextBox7.ReadOnly = false;
                        TextBox8.ReadOnly = false;
                        labelNull1.Text = "    ";
                        labelNull2.Text = "    ";
                        labelNull3.Text = "    ";
                        labelNull4.Text = "    ";
                        labelNull5.Text = "    ";
                        labelNull6.Text = "    ";
                        labelNull7.Text = "    ";
                        labelNull8.Text = "    ";
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
                        TextBox1.ReadOnly = false;
                        TextBox2.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox3.ReadOnly = true;
                        TextBox4.ReadOnly = true;
                        TextBox5.ReadOnly = true;
                        TextBox6.ReadOnly = true;
                        TextBox7.ReadOnly = true;
                        TextBox8.ReadOnly = true;
                        labelNull1.Text = "    ";
                        labelNull2.Text = "    ";
                        labelNull3.Text = "    ";
                        labelNull4.Text = "    ";
                        labelNull5.Text = "    ";
                        labelNull6.Text = "    ";
                        labelNull7.Text = "    ";
                        labelNull8.Text = "    ";
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
                TextBox2.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                TextBox3.Text = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                TextBox4.Text = DataGridView.SelectedRows[0].Cells[4].Value.ToString();
                TextBox5.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                TextBox6.Text = DataGridView.SelectedRows[0].Cells[6].Value.ToString();
                TextBox7.Text = DataGridView.SelectedRows[0].Cells[5].Value.ToString();
                TextBox8.Text = DataGridView.SelectedRows[0].Cells[7].Value.ToString();
            }
        }
    }
}

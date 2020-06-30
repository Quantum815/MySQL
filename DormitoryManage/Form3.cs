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
    public partial class LateWtEl : Form
    {
        public LateWtEl(string flag)
        {          
            InitializeComponent();
            string SQLstr = "\0";
            MySQLConnection SQLconnection = new MySQLConnection(new MySQLConnectionString
            ("localhost", "DormitoryManage", "root", "123456").AsString);
            if(flag == "0")
            {
                this.Text = "晚归信息";
                SQLstr = "SELECT studentNumber as '学号',lateReturnTime as '晚归时间' FROM late_return WHERE studentNumber = " + PublicValue.STUNUM;
            }               
            else if(flag == "1")
            {
                this.Text = "水电信息";
                SQLstr = "SELECT studentNumber as '学号', dormitoryNumber as '公寓号',roomNumber as '寝室号',checkMonth as '日期',electricityConsumption as '用电量',electricityBill as '电费',waterConsumption" +
                " as '用水量',waterBill as '水费' FROM Water_Electricity WHERE studentNumber = " + PublicValue.STUNUM;
            }
            SQLconnection.Open();
            MySQLCommand SQLcommand = new MySQLCommand("SET NAMES GB2312", SQLconnection);
            SQLcommand.ExecuteNonQuery();   //执行设置字符集的语句
            MySQLDataAdapter SQLadapter = new MySQLDataAdapter(SQLstr, SQLconnection);
            DataSet set = new DataSet();
            SQLadapter.Fill(set);
            DataGridView.DataSource = set.Tables[0];
            SQLconnection.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ButtonBack.Focus();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database191030
{
    public partial class Form1 : Form
    {
        DataTable mytable1;
        DataTable mytable2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void get_data_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (DataRow mydataRow in mytable1.Rows)
            {
                listBox1.Items.Add(mydataRow["s_id"] + " " + mydataRow["s_name"] + " " + mydataRow["p_id"]);
            }
        }

        private void save_data_btn_Click(object sender, EventArgs e)
        {
            
            String s_name = s_name_tb.Text;
            String s_id = s_id_tb.Text;
            String p_id = p_id_tb.Text;

            DataRow mydataRow = mytable1.NewRow();

            mydataRow["s_name"] = s_name;
            mydataRow["s_id"] = s_id;
            mydataRow["p_id"] = p_id;

            mytable1.Rows.Add(mydataRow);
            MessageBox.Show("입력성공");
            oracleConnection1.Open();
            oracleDataAdapter1.Update(dataSet11, "Students");
            oracleConnection1.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleDataAdapter1.Fill(dataSet11, "Students");
            oracleConnection1.Close();

            mytable1 = dataSet11.Tables["Students"];

            foreach (DataRow mydataRow in mytable1.Rows)
            {
                listBox1.Items.Add(mydataRow["s_id"] + " " + mydataRow["s_name"] + " " + mydataRow["p_id"]);
            }
        }

        private void s_name_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

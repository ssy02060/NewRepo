using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase191028
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleCommand1.CommandText = "SELECT object_name FROM user_objects WHERE object_type = 'TABLE'";
            tabPage1.Text = "데이터";
            tabPage2.Text = "칼럼";

            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            while (rdr.Read())
            {
                listBox1.Items.Add(rdr[0]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string my_contents = "";
            string sql_data = "SELECT * FROM ";
            
            string tbl_name = listBox1.SelectedItem.ToString();
            string sql_column = "SELECT * FROM COLS WHERE TABLE_NAME = ";


            oracleCommand2.CommandText = sql_data + tbl_name;
            oracleCommand3.CommandText = sql_column + "'" + tbl_name + "'";

            OracleDataReader rdr_data = oracleCommand2.ExecuteReader();
            OracleDataReader rdr_cols = oracleCommand3.ExecuteReader();

            listBox2.Items.Clear();
            listBox3.Items.Clear();

            int count = rdr_data.FieldCount;

            while (rdr_cols.Read())
            {
                my_contents = "";
                my_contents += rdr_cols[1] + ";";
                my_contents += rdr_cols[2] + ";";
                listBox3.Items.Add(my_contents);
            }

            while (rdr_data.Read())
            {
                my_contents = "";
                for(int i = 0; i < count; i++)
                {
                    if (rdr_data[i].ToString() == "")
                    {
                        my_contents += "null;";
                        continue;
                    }
                    my_contents = my_contents + rdr_data[i] + ";";
                }
                listBox2.Items.Add(my_contents);
            }
        }
    }
}

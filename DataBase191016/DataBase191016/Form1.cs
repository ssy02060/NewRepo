using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase191016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SQL문 작성
            oracleCommand1.CommandText = "SELECT * FROM MEMO_TABLE";
            oracleCommand2.CommandText = "SELECT * FROM MEMO_TABLE WHERE M_ID = :PARAM";
            oracleCommand3.CommandText = "INSERT INTO MEMO_TABLE VALUES (memo_seq.nextval, :aa, :bb, :cc)";
            //시스템 시간을 받아오는 select문
            oracleCommand4.CommandText = "SELECT SYSDATE FROM DUAL";

            oracleConnection1.Open();
        }

        private void view_list_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //dataReader에 커맨드 연결
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            //읽어들이면서 ID 출력
            while (rdr.Read())
            {
                listBox1.Items.Add(rdr["M_ID"]);
            }
            rdr.Close();
        }

        private void view_content_btn_Click(object sender, EventArgs e)
        {
            //listBox에 선택된 아이템의 텍스트를 parameter[0]에 전달
            oracleCommand2.Parameters[0].Value = listBox1.GetItemText(listBox1.SelectedItem);

            OracleDataReader rdr = oracleCommand2.ExecuteReader();

            while (rdr.Read())
            {
                content.Text = rdr["M_date"].ToString() + "\r\n" + rdr["M_CONTENTS"].ToString();
            }
                
            rdr.Close();
        }

        private void save_memo_btn_Click(object sender, EventArgs e)
        {
            DateTime current_time;

            //서버 시간을 current_time에 저장
            current_time = Convert.ToDateTime(oracleCommand4.ExecuteScalar());

            oracleCommand3.Parameters["aa"].Value = title_tb.Text;
            oracleCommand3.Parameters["bb"].Value = current_time.ToString();
            oracleCommand3.Parameters["cc"].Value = content_tb.Text;

            //전달된 parameter로 insert문 실행
            oracleCommand3.ExecuteNonQuery();

            MessageBox.Show("Memo Successfully Added");
        }

        private void next_memo_btn_Click(object sender, EventArgs e)
        {
            title_tb.Clear();
            content_tb.Clear();
        }
    }
}

namespace Database191030
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter11 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter12 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter13 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter14 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter15 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter16 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter17 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter18 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter19 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter20 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter21 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter22 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter23 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter24 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter25 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter26 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter27 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter28 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter29 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter30 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter31 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter32 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter1 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter2 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter3 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter4 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter5 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter6 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter7 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter8 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter9 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter10 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.get_data_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.s_id_tb = new System.Windows.Forms.TextBox();
            this.s_name_tb = new System.Windows.Forms.TextBox();
            this.p_id_tb = new System.Windows.Forms.TextBox();
            this.save_data_btn = new System.Windows.Forms.Button();
            this.dataSet11 = new Database191030.DataSet1();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.selectOracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.insertOracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.updateOracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.deleteOracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 229);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "students";
            // 
            // get_data_btn
            // 
            this.get_data_btn.Location = new System.Drawing.Point(81, 13);
            this.get_data_btn.Name = "get_data_btn";
            this.get_data_btn.Size = new System.Drawing.Size(127, 23);
            this.get_data_btn.TabIndex = 2;
            this.get_data_btn.Text = "데이터 불러오기";
            this.get_data_btn.UseVisualStyleBackColor = true;
            this.get_data_btn.Click += new System.EventHandler(this.get_data_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "s_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "s_name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "p_id";
            // 
            // s_id_tb
            // 
            this.s_id_tb.Location = new System.Drawing.Point(81, 292);
            this.s_id_tb.Name = "s_id_tb";
            this.s_id_tb.Size = new System.Drawing.Size(223, 25);
            this.s_id_tb.TabIndex = 6;
            // 
            // s_name_tb
            // 
            this.s_name_tb.Location = new System.Drawing.Point(81, 327);
            this.s_name_tb.Name = "s_name_tb";
            this.s_name_tb.Size = new System.Drawing.Size(223, 25);
            this.s_name_tb.TabIndex = 7;
            this.s_name_tb.TextChanged += new System.EventHandler(this.s_name_tb_TextChanged);
            // 
            // p_id_tb
            // 
            this.p_id_tb.Location = new System.Drawing.Point(81, 359);
            this.p_id_tb.Name = "p_id_tb";
            this.p_id_tb.Size = new System.Drawing.Size(223, 25);
            this.p_id_tb.TabIndex = 8;
            // 
            // save_data_btn
            // 
            this.save_data_btn.Location = new System.Drawing.Point(331, 327);
            this.save_data_btn.Name = "save_data_btn";
            this.save_data_btn.Size = new System.Drawing.Size(127, 23);
            this.save_data_btn.TabIndex = 9;
            this.save_data_btn.Text = "데이터 저장";
            this.save_data_btn.UseVisualStyleBackColor = true;
            this.save_data_btn.Click += new System.EventHandler(this.save_data_btn_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oracleDataAdapter1
            // 
            this.oracleDataAdapter1.DeleteCommand = this.deleteOracleCommand1;
            this.oracleDataAdapter1.InsertCommand = this.insertOracleCommand1;
            this.oracleDataAdapter1.SelectCommand = this.selectOracleCommand1;
            this.oracleDataAdapter1.UpdateCommand = this.updateOracleCommand1;
            // 
            // selectOracleCommand1
            // 
            this.selectOracleCommand1.CommandText = "SELECT * FROM students";
            this.selectOracleCommand1.Connection = this.oracleConnection1;
            this.selectOracleCommand1.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "USER ID=A5293638;DATA SOURCE=ORARA;PASSWORD=san9yun2;PERSIST SECURITY INFO=true;";
            this.oracleConnection1.Credential = null;
            // 
            // insertOracleCommand1
            // 
            this.insertOracleCommand1.CommandText = resources.GetString("insertOracleCommand1.CommandText");
            this.insertOracleCommand1.Connection = this.oracleConnection1;
            oracleParameter11.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter11.ParameterName = ":cur_S_ID_p0";
            oracleParameter11.SourceColumn = "S_ID";
            oracleParameter12.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter12.ParameterName = ":cur_S_NAME_p1";
            oracleParameter12.SourceColumn = "S_NAME";
            oracleParameter13.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter13.ParameterName = ":cur_S_ADDRESS_p2";
            oracleParameter13.SourceColumn = "S_ADDRESS";
            oracleParameter14.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Date;
            oracleParameter14.ParameterName = ":cur_S_BIRTHDATE_p3";
            oracleParameter14.SourceColumn = "S_BIRTHDATE";
            oracleParameter15.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter15.ParameterName = ":cur_P_ID_p4";
            oracleParameter15.SourceColumn = "P_ID";
            oracleParameter16.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Char;
            oracleParameter16.ParameterName = ":cur_S_PHONE_NUMBER_p5";
            oracleParameter16.SourceColumn = "S_PHONE_NUMBER";
            this.insertOracleCommand1.Parameters.Add(oracleParameter11);
            this.insertOracleCommand1.Parameters.Add(oracleParameter12);
            this.insertOracleCommand1.Parameters.Add(oracleParameter13);
            this.insertOracleCommand1.Parameters.Add(oracleParameter14);
            this.insertOracleCommand1.Parameters.Add(oracleParameter15);
            this.insertOracleCommand1.Parameters.Add(oracleParameter16);
            this.insertOracleCommand1.Transaction = null;
            // 
            // updateOracleCommand1
            // 
            this.updateOracleCommand1.CommandText = resources.GetString("updateOracleCommand1.CommandText");
            this.updateOracleCommand1.Connection = this.oracleConnection1;
            oracleParameter17.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter17.ParameterName = ":cur_S_ID_p0";
            oracleParameter17.SourceColumn = "S_ID";
            oracleParameter18.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter18.ParameterName = ":cur_S_NAME_p1";
            oracleParameter18.SourceColumn = "S_NAME";
            oracleParameter19.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter19.ParameterName = ":cur_S_ADDRESS_p2";
            oracleParameter19.SourceColumn = "S_ADDRESS";
            oracleParameter20.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Date;
            oracleParameter20.ParameterName = ":cur_S_BIRTHDATE_p3";
            oracleParameter20.SourceColumn = "S_BIRTHDATE";
            oracleParameter21.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter21.ParameterName = ":cur_P_ID_p4";
            oracleParameter21.SourceColumn = "P_ID";
            oracleParameter22.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Char;
            oracleParameter22.ParameterName = ":cur_S_PHONE_NUMBER_p5";
            oracleParameter22.SourceColumn = "S_PHONE_NUMBER";
            oracleParameter23.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter23.ParameterName = ":ori_S_ID_p6";
            oracleParameter23.SourceColumn = "S_ID";
            oracleParameter23.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter24.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter24.ParameterName = ":ori_S_NAME_p7";
            oracleParameter24.SourceColumn = "S_NAME";
            oracleParameter24.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter25.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter25.ParameterName = ":ori_S_ADDRESS_p8";
            oracleParameter25.SourceColumn = "S_ADDRESS";
            oracleParameter25.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter26.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter26.ParameterName = ":ori_S_ADDRESS_p9";
            oracleParameter26.SourceColumn = "S_ADDRESS";
            oracleParameter26.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter27.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Date;
            oracleParameter27.ParameterName = ":ori_S_BIRTHDATE_p10";
            oracleParameter27.SourceColumn = "S_BIRTHDATE";
            oracleParameter27.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter28.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Date;
            oracleParameter28.ParameterName = ":ori_S_BIRTHDATE_p11";
            oracleParameter28.SourceColumn = "S_BIRTHDATE";
            oracleParameter28.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter29.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter29.ParameterName = ":ori_P_ID_p12";
            oracleParameter29.SourceColumn = "P_ID";
            oracleParameter29.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter30.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter30.ParameterName = ":ori_P_ID_p13";
            oracleParameter30.SourceColumn = "P_ID";
            oracleParameter30.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter31.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Char;
            oracleParameter31.ParameterName = ":ori_S_PHONE_NUMBER_p14";
            oracleParameter31.SourceColumn = "S_PHONE_NUMBER";
            oracleParameter31.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter32.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Char;
            oracleParameter32.ParameterName = ":ori_S_PHONE_NUMBER_p15";
            oracleParameter32.SourceColumn = "S_PHONE_NUMBER";
            oracleParameter32.SourceVersion = System.Data.DataRowVersion.Original;
            this.updateOracleCommand1.Parameters.Add(oracleParameter17);
            this.updateOracleCommand1.Parameters.Add(oracleParameter18);
            this.updateOracleCommand1.Parameters.Add(oracleParameter19);
            this.updateOracleCommand1.Parameters.Add(oracleParameter20);
            this.updateOracleCommand1.Parameters.Add(oracleParameter21);
            this.updateOracleCommand1.Parameters.Add(oracleParameter22);
            this.updateOracleCommand1.Parameters.Add(oracleParameter23);
            this.updateOracleCommand1.Parameters.Add(oracleParameter24);
            this.updateOracleCommand1.Parameters.Add(oracleParameter25);
            this.updateOracleCommand1.Parameters.Add(oracleParameter26);
            this.updateOracleCommand1.Parameters.Add(oracleParameter27);
            this.updateOracleCommand1.Parameters.Add(oracleParameter28);
            this.updateOracleCommand1.Parameters.Add(oracleParameter29);
            this.updateOracleCommand1.Parameters.Add(oracleParameter30);
            this.updateOracleCommand1.Parameters.Add(oracleParameter31);
            this.updateOracleCommand1.Parameters.Add(oracleParameter32);
            this.updateOracleCommand1.Transaction = null;
            // 
            // deleteOracleCommand1
            // 
            this.deleteOracleCommand1.CommandText = resources.GetString("deleteOracleCommand1.CommandText");
            this.deleteOracleCommand1.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = ":ori_S_ID_p0";
            oracleParameter1.SourceColumn = "S_ID";
            oracleParameter1.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter2.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = ":ori_S_NAME_p1";
            oracleParameter2.SourceColumn = "S_NAME";
            oracleParameter2.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter3.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = ":ori_S_ADDRESS_p2";
            oracleParameter3.SourceColumn = "S_ADDRESS";
            oracleParameter3.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter4.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter4.ParameterName = ":ori_S_ADDRESS_p3";
            oracleParameter4.SourceColumn = "S_ADDRESS";
            oracleParameter4.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter5.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Date;
            oracleParameter5.ParameterName = ":ori_S_BIRTHDATE_p4";
            oracleParameter5.SourceColumn = "S_BIRTHDATE";
            oracleParameter5.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter6.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Date;
            oracleParameter6.ParameterName = ":ori_S_BIRTHDATE_p5";
            oracleParameter6.SourceColumn = "S_BIRTHDATE";
            oracleParameter6.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter7.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter7.ParameterName = ":ori_P_ID_p6";
            oracleParameter7.SourceColumn = "P_ID";
            oracleParameter7.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter8.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter8.ParameterName = ":ori_P_ID_p7";
            oracleParameter8.SourceColumn = "P_ID";
            oracleParameter8.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter9.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Char;
            oracleParameter9.ParameterName = ":ori_S_PHONE_NUMBER_p8";
            oracleParameter9.SourceColumn = "S_PHONE_NUMBER";
            oracleParameter9.SourceVersion = System.Data.DataRowVersion.Original;
            oracleParameter10.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Char;
            oracleParameter10.ParameterName = ":ori_S_PHONE_NUMBER_p9";
            oracleParameter10.SourceColumn = "S_PHONE_NUMBER";
            oracleParameter10.SourceVersion = System.Data.DataRowVersion.Original;
            this.deleteOracleCommand1.Parameters.Add(oracleParameter1);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter2);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter3);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter4);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter5);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter6);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter7);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter8);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter9);
            this.deleteOracleCommand1.Parameters.Add(oracleParameter10);
            this.deleteOracleCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 428);
            this.Controls.Add(this.save_data_btn);
            this.Controls.Add(this.p_id_tb);
            this.Controls.Add(this.s_name_tb);
            this.Controls.Add(this.s_id_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.get_data_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button get_data_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox s_id_tb;
        private System.Windows.Forms.TextBox s_name_tb;
        private System.Windows.Forms.TextBox p_id_tb;
        private System.Windows.Forms.Button save_data_btn;
        private DataSet1 dataSet11;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private Oracle.ManagedDataAccess.Client.OracleCommand deleteOracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.ManagedDataAccess.Client.OracleCommand insertOracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleCommand selectOracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleCommand updateOracleCommand1;
    }
}


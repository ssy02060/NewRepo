namespace DataBase191016
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
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter1 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter2 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter3 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter4 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.content_tb = new System.Windows.Forms.TextBox();
            this.next_memo_btn = new System.Windows.Forms.Button();
            this.save_memo_btn = new System.Windows.Forms.Button();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.content = new System.Windows.Forms.TextBox();
            this.view_content_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.view_list_btn = new System.Windows.Forms.Button();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.oracleCommand2 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand3 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand4 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.content_tb);
            this.tabPage1.Controls.Add(this.next_memo_btn);
            this.tabPage1.Controls.Add(this.save_memo_btn);
            this.tabPage1.Controls.Add(this.title_tb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(573, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "메모입력";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // content_tb
            // 
            this.content_tb.Location = new System.Drawing.Point(9, 58);
            this.content_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.content_tb.Multiline = true;
            this.content_tb.Name = "content_tb";
            this.content_tb.Size = new System.Drawing.Size(530, 323);
            this.content_tb.TabIndex = 4;
            // 
            // next_memo_btn
            // 
            this.next_memo_btn.Location = new System.Drawing.Point(325, 21);
            this.next_memo_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.next_memo_btn.Name = "next_memo_btn";
            this.next_memo_btn.Size = new System.Drawing.Size(86, 29);
            this.next_memo_btn.TabIndex = 3;
            this.next_memo_btn.Text = "다음메모";
            this.next_memo_btn.UseVisualStyleBackColor = true;
            this.next_memo_btn.Click += new System.EventHandler(this.next_memo_btn_Click);
            // 
            // save_memo_btn
            // 
            this.save_memo_btn.Location = new System.Drawing.Point(232, 21);
            this.save_memo_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_memo_btn.Name = "save_memo_btn";
            this.save_memo_btn.Size = new System.Drawing.Size(86, 29);
            this.save_memo_btn.TabIndex = 2;
            this.save_memo_btn.Text = "메모저장";
            this.save_memo_btn.UseVisualStyleBackColor = true;
            this.save_memo_btn.Click += new System.EventHandler(this.save_memo_btn_Click);
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(61, 24);
            this.title_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(164, 25);
            this.title_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "키워드";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.content);
            this.tabPage2.Controls.Add(this.view_content_btn);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.view_list_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(573, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "메모리스트";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(19, 165);
            this.content.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(367, 202);
            this.content.TabIndex = 3;
            // 
            // view_content_btn
            // 
            this.view_content_btn.Location = new System.Drawing.Point(408, 64);
            this.view_content_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_content_btn.Name = "view_content_btn";
            this.view_content_btn.Size = new System.Drawing.Size(86, 29);
            this.view_content_btn.TabIndex = 2;
            this.view_content_btn.Text = "내용보기";
            this.view_content_btn.UseVisualStyleBackColor = true;
            this.view_content_btn.Click += new System.EventHandler(this.view_content_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(19, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 109);
            this.listBox1.TabIndex = 1;
            // 
            // view_list_btn
            // 
            this.view_list_btn.Location = new System.Drawing.Point(408, 28);
            this.view_list_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_list_btn.Name = "view_list_btn";
            this.view_list_btn.Size = new System.Drawing.Size(86, 29);
            this.view_list_btn.TabIndex = 0;
            this.view_list_btn.Text = "리스트보기";
            this.view_list_btn.UseVisualStyleBackColor = true;
            this.view_list_btn.Click += new System.EventHandler(this.view_list_btn_Click);
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORARA;USER ID=A5293638;PASSWORD=san9yun2;";
            this.oracleConnection1.Credential = null;
            this.oracleConnection1.KeepAlive = false;
            this.oracleConnection1.KeepAliveInterval = 6;
            this.oracleConnection1.KeepAliveTime = 60;
            this.oracleConnection1.TnsAdmin = null;
            this.oracleConnection1.WalletLocation = null;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            this.oracleCommand2.Parameters.Add(oracleParameter1);
            this.oracleCommand2.Transaction = null;
            // 
            // oracleCommand3
            // 
            this.oracleCommand3.Connection = this.oracleConnection1;
            oracleParameter2.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "aa";
            oracleParameter3.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = "bb";
            oracleParameter4.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter4.ParameterName = "cc";
            this.oracleCommand3.Parameters.Add(oracleParameter2);
            this.oracleCommand3.Parameters.Add(oracleParameter3);
            this.oracleCommand3.Parameters.Add(oracleParameter4);
            this.oracleCommand3.Transaction = null;
            // 
            // oracleCommand4
            // 
            this.oracleCommand4.Connection = this.oracleConnection1;
            this.oracleCommand4.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 496);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox content_tb;
        private System.Windows.Forms.Button next_memo_btn;
        private System.Windows.Forms.Button save_memo_btn;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_list_btn;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button view_content_btn;
        private System.Windows.Forms.ListBox listBox1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand2;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand3;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand4;
    }
}


namespace _01BASIC
{
    partial class WINFORM
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
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TEMP_BOX = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sun_txt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DIS_TXT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.BackColor = System.Drawing.Color.White;
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.PortNumber.Location = new System.Drawing.Point(9, 20);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(122, 20);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndexChanged += new System.EventHandler(this.PortNumber_SelectedIndexChanged_1);
            // 
            // conn_btn
            // 
            this.conn_btn.BackColor = System.Drawing.Color.White;
            this.conn_btn.Location = new System.Drawing.Point(163, 20);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(75, 20);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = false;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // textArea
            // 
            this.textArea.BackColor = System.Drawing.Color.White;
            this.textArea.Font = new System.Drawing.Font("새굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textArea.Location = new System.Drawing.Point(6, 20);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textArea.Size = new System.Drawing.Size(188, 215);
            this.textArea.TabIndex = 2;
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PortNumber);
            this.groupBox1.Controls.Add(this.conn_btn);
            this.groupBox1.Location = new System.Drawing.Point(29, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(29, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED제어";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textArea);
            this.groupBox3.Location = new System.Drawing.Point(327, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 252);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "로그 확인";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TEMP_BOX);
            this.groupBox4.Location = new System.Drawing.Point(29, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 60);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "온도 센서";
            // 
            // TEMP_BOX
            // 
            this.TEMP_BOX.Enabled = false;
            this.TEMP_BOX.Location = new System.Drawing.Point(9, 21);
            this.TEMP_BOX.Multiline = true;
            this.TEMP_BOX.Name = "TEMP_BOX";
            this.TEMP_BOX.Size = new System.Drawing.Size(229, 23);
            this.TEMP_BOX.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sun_txt);
            this.groupBox5.Location = new System.Drawing.Point(29, 303);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 53);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "조도 센서";
            // 
            // sun_txt
            // 
            this.sun_txt.Enabled = false;
            this.sun_txt.Location = new System.Drawing.Point(10, 19);
            this.sun_txt.Name = "sun_txt";
            this.sun_txt.Size = new System.Drawing.Size(227, 21);
            this.sun_txt.TabIndex = 0;
            this.sun_txt.TextChanged += new System.EventHandler(this.sun_txt_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DIS_TXT);
            this.groupBox6.Location = new System.Drawing.Point(327, 303);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 53);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "초음파 센서";
            // 
            // DIS_TXT
            // 
            this.DIS_TXT.Enabled = false;
            this.DIS_TXT.Location = new System.Drawing.Point(6, 19);
            this.DIS_TXT.Multiline = true;
            this.DIS_TXT.Name = "DIS_TXT";
            this.DIS_TXT.Size = new System.Drawing.Size(188, 21);
            this.DIS_TXT.TabIndex = 0;
            // 
            // WINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(571, 397);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "WINFORM";
            this.Text = "-";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TEMP_BOX;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox sun_txt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox DIS_TXT;
    }
}


namespace OrderingSystemFLATSTYLE
{
    partial class Orderlist
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn匯出 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl數量 = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnDELALL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRes_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderPerson = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btndroplist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxOrderNum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOrdernum = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn匯出
            // 
            this.btn匯出.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btn匯出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn匯出.Font = new System.Drawing.Font("標楷體", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn匯出.Location = new System.Drawing.Point(244, 542);
            this.btn匯出.Name = "btn匯出";
            this.btn匯出.Size = new System.Drawing.Size(69, 28);
            this.btn匯出.TabIndex = 1;
            this.btn匯出.Text = "匯出清單";
            this.btn匯出.UseVisualStyleBackColor = false;
            this.btn匯出.Click += new System.EventHandler(this.btn匯出_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl數量);
            this.groupBox1.Controls.Add(this.lblTotalSum);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(19, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "總計";
            // 
            // lbl數量
            // 
            this.lbl數量.AutoSize = true;
            this.lbl數量.Location = new System.Drawing.Point(180, 38);
            this.lbl數量.Name = "lbl數量";
            this.lbl數量.Size = new System.Drawing.Size(47, 14);
            this.lbl數量.TabIndex = 1;
            this.lbl數量.Text = "label7";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Location = new System.Drawing.Point(42, 38);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(47, 14);
            this.lblTotalSum.TabIndex = 0;
            this.lblTotalSum.Text = "label6";
            // 
            // btnDEL
            // 
            this.btnDEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDEL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDEL.FlatAppearance.BorderSize = 2;
            this.btnDEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDEL.Location = new System.Drawing.Point(19, 414);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(133, 42);
            this.btnDEL.TabIndex = 3;
            this.btnDEL.Text = "刪除所選項目";
            this.btnDEL.UseVisualStyleBackColor = false;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnDELALL
            // 
            this.btnDELALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDELALL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDELALL.FlatAppearance.BorderSize = 2;
            this.btnDELALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELALL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDELALL.Location = new System.Drawing.Point(180, 414);
            this.btnDELALL.Name = "btnDELALL";
            this.btnDELALL.Size = new System.Drawing.Size(133, 42);
            this.btnDELALL.TabIndex = 4;
            this.btnDELALL.Text = "清除所有";
            this.btnDELALL.UseVisualStyleBackColor = false;
            this.btnDELALL.Click += new System.EventHandler(this.btnDELALL_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "餐廳:";
            // 
            // lblRes_name
            // 
            this.lblRes_name.AutoEllipsis = true;
            this.lblRes_name.AutoSize = true;
            this.lblRes_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblRes_name.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRes_name.Location = new System.Drawing.Point(14, 63);
            this.lblRes_name.Name = "lblRes_name";
            this.lblRes_name.Size = new System.Drawing.Size(69, 19);
            this.lblRes_name.TabIndex = 6;
            this.lblRes_name.Text = "餐廳名";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(177, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "負責人:";
            // 
            // lblOrderPerson
            // 
            this.lblOrderPerson.AutoEllipsis = true;
            this.lblOrderPerson.AutoSize = true;
            this.lblOrderPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblOrderPerson.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderPerson.Location = new System.Drawing.Point(230, 10);
            this.lblOrderPerson.Name = "lblOrderPerson";
            this.lblOrderPerson.Size = new System.Drawing.Size(52, 16);
            this.lblOrderPerson.TabIndex = 8;
            this.lblOrderPerson.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time";
            // 
            // btndroplist
            // 
            this.btndroplist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.btndroplist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndroplist.FlatAppearance.BorderSize = 0;
            this.btndroplist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndroplist.Font = new System.Drawing.Font("新細明體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndroplist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndroplist.Location = new System.Drawing.Point(261, 141);
            this.btndroplist.Name = "btndroplist";
            this.btndroplist.Size = new System.Drawing.Size(69, 30);
            this.btndroplist.TabIndex = 10;
            this.btndroplist.Text = "刪除訂單";
            this.btndroplist.UseVisualStyleBackColor = false;
            this.btndroplist.Click += new System.EventHandler(this.btndroplist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "訂單編號";
            // 
            // cboxOrderNum
            // 
            this.cboxOrderNum.FormattingEnabled = true;
            this.cboxOrderNum.Location = new System.Drawing.Point(10, 119);
            this.cboxOrderNum.Name = "cboxOrderNum";
            this.cboxOrderNum.Size = new System.Drawing.Size(121, 20);
            this.cboxOrderNum.TabIndex = 12;
            this.cboxOrderNum.SelectedIndexChanged += new System.EventHandler(this.cboxOrderNum_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "單號";
            // 
            // lblOrdernum
            // 
            this.lblOrdernum.AutoSize = true;
            this.lblOrdernum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblOrdernum.Location = new System.Drawing.Point(62, 11);
            this.lblOrdernum.Name = "lblOrdernum";
            this.lblOrdernum.Size = new System.Drawing.Size(33, 12);
            this.lblOrdernum.TabIndex = 16;
            this.lblOrdernum.Text = "label9";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("新細明體", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(119, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "訂購截止";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(176, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "訂單日期:";
            // 
            // listViewOrder
            // 
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(0, 174);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(333, 234);
            this.listViewOrder.TabIndex = 19;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.btnShow.FlatAppearance.BorderSize = 2;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.btnShow.Location = new System.Drawing.Point(3, 145);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 20;
            this.btnShow.Text = "顯示訂單";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Orderlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOrdernum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboxOrderNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndroplist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOrderPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRes_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDELALL);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn匯出);
            this.Name = "Orderlist";
            this.Size = new System.Drawing.Size(333, 600);
            this.Load += new System.EventHandler(this.Orderlist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn匯出;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnDELALL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRes_name;
        private System.Windows.Forms.Label lbl數量;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndroplist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxOrderNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOrdernum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btnShow;
    }
}

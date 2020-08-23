namespace OrderingSystemFLATSTYLE
{
    partial class 菜單管理
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
            this.p_resArrange = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.p_insertbtn = new System.Windows.Forms.Panel();
            this.btnSaveFix = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboxresName管理 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox新增餐廳菜色 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfoodName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnADDdishes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p_resArrange.SuspendLayout();
            this.panel1.SuspendLayout();
            this.p_insertbtn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_resArrange
            // 
            this.p_resArrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.p_resArrange.Controls.Add(this.panel1);
            this.p_resArrange.Controls.Add(this.btnCreate);
            this.p_resArrange.Controls.Add(this.p_insertbtn);
            this.p_resArrange.Controls.Add(this.button1);
            this.p_resArrange.Controls.Add(this.cboxresName管理);
            this.p_resArrange.Controls.Add(this.label7);
            this.p_resArrange.Controls.Add(this.label6);
            this.p_resArrange.Controls.Add(this.txtPhone);
            this.p_resArrange.Controls.Add(this.label5);
            this.p_resArrange.Controls.Add(this.txtComment);
            this.p_resArrange.Controls.Add(this.label4);
            this.p_resArrange.Controls.Add(this.txtKind);
            this.p_resArrange.Controls.Add(this.label3);
            this.p_resArrange.Controls.Add(this.txtAddress);
            this.p_resArrange.Controls.Add(this.label2);
            this.p_resArrange.Controls.Add(this.txtName);
            this.p_resArrange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_resArrange.ForeColor = System.Drawing.Color.Coral;
            this.p_resArrange.Location = new System.Drawing.Point(0, 262);
            this.p_resArrange.Name = "p_resArrange";
            this.p_resArrange.Size = new System.Drawing.Size(356, 338);
            this.p_resArrange.TabIndex = 0;
            this.p_resArrange.Paint += new System.Windows.Forms.PaintEventHandler(this.p_resArrange_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Location = new System.Drawing.Point(188, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 43);
            this.panel1.TabIndex = 28;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.IndianRed;
            this.btnupdate.Location = new System.Drawing.Point(52, 10);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "儲存更改";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCreate.Location = new System.Drawing.Point(29, 40);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(47, 23);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "+新增";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // p_insertbtn
            // 
            this.p_insertbtn.Controls.Add(this.btnSaveFix);
            this.p_insertbtn.Location = new System.Drawing.Point(3, 292);
            this.p_insertbtn.Name = "p_insertbtn";
            this.p_insertbtn.Size = new System.Drawing.Size(163, 43);
            this.p_insertbtn.TabIndex = 27;
            // 
            // btnSaveFix
            // 
            this.btnSaveFix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveFix.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSaveFix.Location = new System.Drawing.Point(37, 10);
            this.btnSaveFix.Name = "btnSaveFix";
            this.btnSaveFix.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFix.TabIndex = 22;
            this.btnSaveFix.Text = "儲存新增";
            this.btnSaveFix.UseVisualStyleBackColor = true;
            this.btnSaveFix.Click += new System.EventHandler(this.btnSaveFix_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(240, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 26;
            this.button1.Text = "刪除餐廳";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // cboxresName管理
            // 
            this.cboxresName管理.FormattingEnabled = true;
            this.cboxresName管理.Location = new System.Drawing.Point(206, 71);
            this.cboxresName管理.Name = "cboxresName管理";
            this.cboxresName管理.Size = new System.Drawing.Size(121, 20);
            this.cboxresName管理.TabIndex = 25;
            this.cboxresName管理.SelectedIndexChanged += new System.EventHandler(this.cboxresName管理_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(93, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "餐廳資料異動";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "電話";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(66, 194);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(175, 22);
            this.txtPhone.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "評價";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(66, 233);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(217, 37);
            this.txtComment.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "種類";
            // 
            // txtKind
            // 
            this.txtKind.Location = new System.Drawing.Point(66, 156);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(100, 22);
            this.txtKind.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "地址";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(66, 107);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 30);
            this.txtAddress.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "餐廳名稱";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(104, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "新增菜色";
            // 
            // cbox新增餐廳菜色
            // 
            this.cbox新增餐廳菜色.FormattingEnabled = true;
            this.cbox新增餐廳菜色.Location = new System.Drawing.Point(142, 41);
            this.cbox新增餐廳菜色.Name = "cbox新增餐廳菜色";
            this.cbox新增餐廳菜色.Size = new System.Drawing.Size(121, 20);
            this.cbox新增餐廳菜色.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(62, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "選擇餐廳";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(66, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "菜色名稱";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(66, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "價格";
            // 
            // txtfoodName
            // 
            this.txtfoodName.Location = new System.Drawing.Point(140, 81);
            this.txtfoodName.Name = "txtfoodName";
            this.txtfoodName.Size = new System.Drawing.Size(123, 22);
            this.txtfoodName.TabIndex = 30;
            this.txtfoodName.TextChanged += new System.EventHandler(this.txtfoodName_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(140, 115);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 22);
            this.txtPrice.TabIndex = 31;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnADDdishes
            // 
            this.btnADDdishes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.btnADDdishes.FlatAppearance.BorderSize = 0;
            this.btnADDdishes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDdishes.ForeColor = System.Drawing.Color.IndianRed;
            this.btnADDdishes.Location = new System.Drawing.Point(27, 3);
            this.btnADDdishes.Name = "btnADDdishes";
            this.btnADDdishes.Size = new System.Drawing.Size(75, 23);
            this.btnADDdishes.TabIndex = 32;
            this.btnADDdishes.Text = "新增菜色";
            this.btnADDdishes.UseVisualStyleBackColor = false;
            this.btnADDdishes.Click += new System.EventHandler(this.btnADDdishes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnADDdishes);
            this.panel2.Location = new System.Drawing.Point(100, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 29);
            this.panel2.TabIndex = 33;
            // 
            // 菜單管理
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtfoodName);
            this.Controls.Add(this.cbox新增餐廳菜色);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_resArrange);
            this.Name = "菜單管理";
            this.Size = new System.Drawing.Size(356, 600);
            this.Load += new System.EventHandler(this.菜單管理_Load);
            this.p_resArrange.ResumeLayout(false);
            this.p_resArrange.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.p_insertbtn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_resArrange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveFix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboxresName管理;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbox新增餐廳菜色;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfoodName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnADDdishes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Panel p_insertbtn;
        private System.Windows.Forms.Panel panel2;
    }
}

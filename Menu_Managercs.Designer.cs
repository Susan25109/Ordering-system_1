namespace OrderingSystemFLATSTYLE
{
    partial class Menu_Managercs
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxRes = new System.Windows.Forms.ComboBox();
            this.lstDecidedItem = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_assignMenu = new System.Windows.Forms.Button();
            this.lblClass_Menu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldate_MenuM = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl店名_menuM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetOrder = new System.Windows.Forms.Button();
            this.cboxOrderidExisit = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇餐廳:";
            // 
            // cboxRes
            // 
            this.cboxRes.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxRes.FormattingEnabled = true;
            this.cboxRes.Location = new System.Drawing.Point(4, 90);
            this.cboxRes.Name = "cboxRes";
            this.cboxRes.Size = new System.Drawing.Size(121, 27);
            this.cboxRes.TabIndex = 1;
            this.cboxRes.SelectedIndexChanged += new System.EventHandler(this.cboxRes_SelectedIndexChanged);
            // 
            // lstDecidedItem
            // 
            this.lstDecidedItem.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstDecidedItem.FormattingEnabled = true;
            this.lstDecidedItem.ItemHeight = 19;
            this.lstDecidedItem.Location = new System.Drawing.Point(4, 125);
            this.lstDecidedItem.Name = "lstDecidedItem";
            this.lstDecidedItem.Size = new System.Drawing.Size(282, 175);
            this.lstDecidedItem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "班級:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(0, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "日期:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 20, 0, 0, 0, 0);
            // 
            // btn_assignMenu
            // 
            this.btn_assignMenu.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_assignMenu.Location = new System.Drawing.Point(97, 327);
            this.btn_assignMenu.Name = "btn_assignMenu";
            this.btn_assignMenu.Size = new System.Drawing.Size(88, 30);
            this.btn_assignMenu.TabIndex = 7;
            this.btn_assignMenu.Text = "新增訂單";
            this.btn_assignMenu.UseVisualStyleBackColor = true;
            this.btn_assignMenu.Click += new System.EventHandler(this.btn_assignMenu_Click);
            // 
            // lblClass_Menu
            // 
            this.lblClass_Menu.AutoSize = true;
            this.lblClass_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.lblClass_Menu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClass_Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblClass_Menu.Location = new System.Drawing.Point(27, 57);
            this.lblClass_Menu.Name = "lblClass_Menu";
            this.lblClass_Menu.Size = new System.Drawing.Size(64, 26);
            this.lblClass_Menu.TabIndex = 8;
            this.lblClass_Menu.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "訂單編號";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldate_MenuM);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl店名_menuM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSetOrder);
            this.groupBox1.Controls.Add(this.cboxOrderidExisit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(16, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 126);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "指派已存在訂單";
            // 
            // lbldate_MenuM
            // 
            this.lbldate_MenuM.AutoSize = true;
            this.lbldate_MenuM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.lbldate_MenuM.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldate_MenuM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbldate_MenuM.Location = new System.Drawing.Point(71, 97);
            this.lbldate_MenuM.Name = "lbldate_MenuM";
            this.lbldate_MenuM.Size = new System.Drawing.Size(40, 16);
            this.lbldate_MenuM.TabIndex = 15;
            this.lbldate_MenuM.Text = "日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "訂購日期";
            // 
            // lbl店名_menuM
            // 
            this.lbl店名_menuM.AutoSize = true;
            this.lbl店名_menuM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.lbl店名_menuM.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl店名_menuM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl店名_menuM.Location = new System.Drawing.Point(71, 69);
            this.lbl店名_menuM.Name = "lbl店名_menuM";
            this.lbl店名_menuM.Size = new System.Drawing.Size(72, 16);
            this.lbl店名_menuM.TabIndex = 13;
            this.lbl店名_menuM.Text = "店家名稱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "店家名稱";
            // 
            // btnSetOrder
            // 
            this.btnSetOrder.FlatAppearance.BorderSize = 2;
            this.btnSetOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSetOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetOrder.Location = new System.Drawing.Point(171, 34);
            this.btnSetOrder.Name = "btnSetOrder";
            this.btnSetOrder.Size = new System.Drawing.Size(105, 23);
            this.btnSetOrder.TabIndex = 11;
            this.btnSetOrder.Text = "指派訂單";
            this.btnSetOrder.UseVisualStyleBackColor = true;
            this.btnSetOrder.Click += new System.EventHandler(this.btnSetOrder_Click);
            // 
            // cboxOrderidExisit
            // 
            this.cboxOrderidExisit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxOrderidExisit.FormattingEnabled = true;
            this.cboxOrderidExisit.Location = new System.Drawing.Point(7, 34);
            this.cboxOrderidExisit.Name = "cboxOrderidExisit";
            this.cboxOrderidExisit.Size = new System.Drawing.Size(158, 24);
            this.cboxOrderidExisit.TabIndex = 10;
            this.cboxOrderidExisit.SelectedIndexChanged += new System.EventHandler(this.cboxOrderidExisit_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDecidedItem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboxRes);
            this.groupBox2.Controls.Add(this.btn_assignMenu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 370);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新訂單";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(245, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 22);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "重新整理";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Menu_Managercs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblClass_Menu);
            this.Controls.Add(this.label2);
            this.Name = "Menu_Managercs";
            this.Size = new System.Drawing.Size(333, 600);
            this.Load += new System.EventHandler(this.Menu_Managercs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxRes;
        private System.Windows.Forms.ListBox lstDecidedItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_assignMenu;
        private System.Windows.Forms.Label lblClass_Menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxOrderidExisit;
        private System.Windows.Forms.Label lbldate_MenuM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl店名_menuM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSetOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
    }
}

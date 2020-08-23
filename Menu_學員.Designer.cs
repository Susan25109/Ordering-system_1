namespace OrderingSystemFLATSTYLE
{
    partial class Menu_學員
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
            this.lblRES_name = new System.Windows.Forms.Label();
            this.lstboxItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKind = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cbox學生餐廳名稱 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRES_name
            // 
            this.lblRES_name.AutoSize = true;
            this.lblRES_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblRES_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRES_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRES_name.Location = new System.Drawing.Point(17, 68);
            this.lblRES_name.Name = "lblRES_name";
            this.lblRES_name.Size = new System.Drawing.Size(86, 24);
            this.lblRES_name.TabIndex = 1;
            this.lblRES_name.Text = "餐廳名稱";
            // 
            // lstboxItems
            // 
            this.lstboxItems.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstboxItems.FormattingEnabled = true;
            this.lstboxItems.ItemHeight = 19;
            this.lstboxItems.Location = new System.Drawing.Point(17, 125);
            this.lstboxItems.Name = "lstboxItems";
            this.lstboxItems.Size = new System.Drawing.Size(285, 213);
            this.lstboxItems.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "餐廳種類:";
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblKind.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblKind.Location = new System.Drawing.Point(81, 36);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(49, 19);
            this.lblKind.TabIndex = 4;
            this.lblKind.Text = "種類";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "地址:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblAddress.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.Location = new System.Drawing.Point(50, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "餐廳地址";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblComment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(82)))), ((int)(((byte)(121)))));
            this.groupBox1.Location = new System.Drawing.Point(17, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 220);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餐廳資訊";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "評價:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblComment.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblComment.Location = new System.Drawing.Point(50, 120);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(76, 16);
            this.lblComment.TabIndex = 10;
            this.lblComment.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "電話:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblPhone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhone.Location = new System.Drawing.Point(50, 92);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 16);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "餐廳電話";
            // 
            // cbox學生餐廳名稱
            // 
            this.cbox學生餐廳名稱.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox學生餐廳名稱.FormattingEnabled = true;
            this.cbox學生餐廳名稱.Location = new System.Drawing.Point(17, 95);
            this.cbox學生餐廳名稱.Name = "cbox學生餐廳名稱";
            this.cbox學生餐廳名稱.Size = new System.Drawing.Size(121, 24);
            this.cbox學生餐廳名稱.TabIndex = 8;
            this.cbox學生餐廳名稱.SelectedIndexChanged += new System.EventHandler(this.cbox學生餐廳名稱_SelectedIndexChanged);
            // 
            // Menu_學員
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.cbox學生餐廳名稱);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstboxItems);
            this.Controls.Add(this.lblRES_name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_學員";
            this.Size = new System.Drawing.Size(333, 600);
            this.Load += new System.EventHandler(this.Menu_學員_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRES_name;
        private System.Windows.Forms.ListBox lstboxItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox學生餐廳名稱;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhone;
    }
}

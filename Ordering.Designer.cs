namespace OrderingSystemFLATSTYLE
{
    partial class Ordering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordering));
            this.lstBox品項 = new System.Windows.Forms.ListBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstbox已選購 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOID = new System.Windows.Forms.Label();
            this.pboxremove = new System.Windows.Forms.PictureBox();
            this.lblstname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxremove)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBox品項
            // 
            this.lstBox品項.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstBox品項.FormattingEnabled = true;
            this.lstBox品項.ItemHeight = 15;
            this.lstBox品項.Location = new System.Drawing.Point(14, 90);
            this.lstBox品項.Name = "lstBox品項";
            this.lstBox品項.Size = new System.Drawing.Size(170, 214);
            this.lstBox品項.TabIndex = 1;
            this.lstBox品項.SelectedIndexChanged += new System.EventHandler(this.lstBox品項_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(218, 184);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "餐廳:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(191, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "數量:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSubtotal.Location = new System.Drawing.Point(123, 501);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 24);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "小計";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(191, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "單價:";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(201, 118);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(117, 28);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(36)))), ((int)(((byte)(23)))));
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(88)))), ((int)(((byte)(3)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(88)))), ((int)(((byte)(3)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("標楷體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(162)))));
            this.btnAdd.Location = new System.Drawing.Point(129, 552);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "送出";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(11, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "品項:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(172, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "姓名:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblTitle.Font = new System.Drawing.Font("新細明體-ExtB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(82)))), ((int)(((byte)(121)))));
            this.lblTitle.Location = new System.Drawing.Point(44, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 22);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "今日餐廳";
            // 
            // lstbox已選購
            // 
            this.lstbox已選購.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbox已選購.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstbox已選購.FormattingEnabled = true;
            this.lstbox已選購.ItemHeight = 19;
            this.lstbox已選購.Location = new System.Drawing.Point(15, 390);
            this.lstbox已選購.Name = "lstbox已選購";
            this.lstbox已選購.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbox已選購.Size = new System.Drawing.Size(303, 95);
            this.lstbox已選購.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(9, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "<已選擇品項>";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("新細明體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelect.Location = new System.Drawing.Point(104, 320);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 35);
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "加入選擇";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(194, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 10);
            this.label7.TabIndex = 18;
            this.label7.Text = "編號";
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.Location = new System.Drawing.Point(225, 1);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(51, 12);
            this.lblOID.TabIndex = 19;
            this.lblOID.Text = "ordernum";
            // 
            // pboxremove
            // 
            this.pboxremove.Image = ((System.Drawing.Image)(resources.GetObject("pboxremove.Image")));
            this.pboxremove.Location = new System.Drawing.Point(287, 489);
            this.pboxremove.Name = "pboxremove";
            this.pboxremove.Size = new System.Drawing.Size(30, 29);
            this.pboxremove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxremove.TabIndex = 20;
            this.pboxremove.TabStop = false;
            this.pboxremove.Click += new System.EventHandler(this.pboxremove_Click);
            // 
            // lblstname
            // 
            this.lblstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.lblstname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblstname.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstname.Location = new System.Drawing.Point(179, 36);
            this.lblstname.MaximumSize = new System.Drawing.Size(150, 30);
            this.lblstname.MinimumSize = new System.Drawing.Size(118, 23);
            this.lblstname.Name = "lblstname";
            this.lblstname.Size = new System.Drawing.Size(118, 30);
            this.lblstname.TabIndex = 21;
            this.lblstname.Text = "label8";
            this.lblstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ordering
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.lblstname);
            this.Controls.Add(this.pboxremove);
            this.Controls.Add(this.lblOID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstbox已選購);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lstBox品項);
            this.Name = "Ordering";
            this.Size = new System.Drawing.Size(333, 600);
            this.Load += new System.EventHandler(this.Ordering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxremove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstBox品項;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstbox已選購;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.PictureBox pboxremove;
        private System.Windows.Forms.Label lblstname;
    }
}

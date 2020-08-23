namespace OrderingSystemFLATSTYLE
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_btnset = new System.Windows.Forms.Panel();
            this.btn_Menu管理 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pb_icon = new System.Windows.Forms.PictureBox();
            this.user_controlP = new System.Windows.Forms.Panel();
            this.panel_btnset.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_btnset
            // 
            this.panel_btnset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.panel_btnset.Controls.Add(this.btn_Menu管理);
            this.panel_btnset.Controls.Add(this.panel3);
            this.panel_btnset.Controls.Add(this.btn_search);
            this.panel_btnset.Controls.Add(this.btn_order);
            this.panel_btnset.Controls.Add(this.btn_menu);
            this.panel_btnset.Controls.Add(this.panel2);
            this.panel_btnset.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_btnset.Location = new System.Drawing.Point(0, 0);
            this.panel_btnset.Name = "panel_btnset";
            this.panel_btnset.Size = new System.Drawing.Size(117, 600);
            this.panel_btnset.TabIndex = 0;
            // 
            // btn_Menu管理
            // 
            this.btn_Menu管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Menu管理.FlatAppearance.BorderSize = 0;
            this.btn_Menu管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu管理.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu管理.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(162)))));
            this.btn_Menu管理.Location = new System.Drawing.Point(0, 342);
            this.btn_Menu管理.Name = "btn_Menu管理";
            this.btn_Menu管理.Size = new System.Drawing.Size(117, 93);
            this.btn_Menu管理.TabIndex = 1;
            this.btn_Menu管理.Text = "餐廳資料管理";
            this.btn_Menu管理.UseVisualStyleBackColor = true;
            this.btn_Menu管理.Click += new System.EventHandler(this.btn_餐廳資料管理);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(162)))));
            this.panel3.Controls.Add(this.btn_logout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 537);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 63);
            this.panel3.TabIndex = 5;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 2;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(15, 16);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 34);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "登出";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_search
            // 
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(162)))));
            this.btn_search.Location = new System.Drawing.Point(0, 249);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(117, 93);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "訂購單";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_orderlist_Click);
            // 
            // btn_order
            // 
            this.btn_order.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_order.FlatAppearance.BorderSize = 0;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(162)))));
            this.btn_order.Location = new System.Drawing.Point(0, 156);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(117, 93);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "點餐";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(162)))));
            this.btn_menu.Location = new System.Drawing.Point(0, 63);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(117, 93);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "菜單";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(195)))), ((int)(((byte)(162)))));
            this.panel2.Controls.Add(this.Pb_icon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 63);
            this.panel2.TabIndex = 0;
            // 
            // Pb_icon
            // 
            this.Pb_icon.Image = ((System.Drawing.Image)(resources.GetObject("Pb_icon.Image")));
            this.Pb_icon.Location = new System.Drawing.Point(0, 0);
            this.Pb_icon.Name = "Pb_icon";
            this.Pb_icon.Size = new System.Drawing.Size(117, 63);
            this.Pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_icon.TabIndex = 0;
            this.Pb_icon.TabStop = false;
            // 
            // user_controlP
            // 
            this.user_controlP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_controlP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.user_controlP.Location = new System.Drawing.Point(117, 0);
            this.user_controlP.Name = "user_controlP";
            this.user_controlP.Size = new System.Drawing.Size(333, 600);
            this.user_controlP.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.user_controlP);
            this.Controls.Add(this.panel_btnset);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(82)))), ((int)(((byte)(121)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "點餐";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_btnset.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_btnset;
        private System.Windows.Forms.Button btn_Menu管理;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel user_controlP;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Pb_icon;
    }
}


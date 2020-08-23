using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OrderingSystemFLATSTYLE
{
    public partial class Form1 : Form
    {
             

       
        public Form1()
        {
            InitializeComponent();          
                         
        }


        private void addUserControl(UserControl uc)
        {
            user_controlP.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            user_controlP.Controls.Add(uc);

            
        }

       

        private void btn_order_Click(object sender, EventArgs e)
        {
            if ((InsertOrderlist.insertOid != null)&&(ClassMytools.Class.ToString()==InsertOrderlist.insertclass.ToString()))
            {
                Ordering toorder = new Ordering();
                addUserControl(toorder);
            }
            else
            {
                MessageBox.Show("點餐尚未開放");
            }
            
        }

        private void btn_orderlist_Click(object sender, EventArgs e)
        {
            
            
                if (ClassMytools.Who.ToString() == "管理員")
                {
                       Orderlist myorder = new Orderlist();
                       addUserControl(myorder);
                }
                else
                {
                    MessageBox.Show("您沒有權限進入該頁面!");
                }
            
            
           
            
           
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (ClassMytools.Who.ToString() == "學員")
            {
                Menu_學員 mymenu = new Menu_學員();
                addUserControl(mymenu);
            }
            else
            {
                Menu_Managercs tomanageit = new Menu_Managercs();//管理介面
                addUserControl(tomanageit);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ClassMytools.Who != null)
            {
                if (ClassMytools.Who.ToString() == "學員")
                {
                    Menu_學員 mymenu = new Menu_學員();
                    addUserControl(mymenu);
                }
                else
                {
                    Menu_Managercs tomanageit = new Menu_Managercs();//管理介面
                    addUserControl(tomanageit);

                }
            }           
            
        }

        private void btn_management_Click(object sender, EventArgs e)
        {
            //做權限阻擋
        }

        private void btn_餐廳資料管理(object sender, EventArgs e)
        {
            if (ClassMytools.Who.ToString() == "管理員")
            {
                菜單管理 mymenu = new 菜單管理();
                addUserControl(mymenu);
            }
            else
            {
                MessageBox.Show("您沒有權限進入該頁面");
            }
        }
             
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login mylog = new Login();
            mylog.ShowDialog();
        }
    }
}

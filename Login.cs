using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace OrderingSystemFLATSTYLE
{
    public partial class Login : Form
    {
        string mydbconnection = "";
        // SqlConnectionStringBuilder myconnectedsql;
        List<string> listSTID = new List<string>();
        
        public Login()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            


            ArrayList check = new ArrayList();
            check.Add("身分未選");
            check.Add("班級未選");
            check.Add("姓名未選");

            foreach(string i in check)
            {                
                switch (i)
                {
                    case "身分未選":
                        if (cboxIdentity.SelectedIndex < 0)
                        { MessageBox.Show("請選擇登入身分"); }
                        continue;
                    case "班級未選":
                        if(cboxClass.SelectedIndex < 0)
                        { MessageBox.Show("請選擇班級!"); }
                        continue;
                    case "姓名未選":
                        if (cboxstName.SelectedIndex < 0) { MessageBox.Show("請選擇姓名"); }
                        continue;

                    default:
                        break;

                }
                continue;
            }



            

            if ((cboxIdentity.SelectedIndex > -1) && (cboxClass.SelectedIndex > -1)&&(cboxstName.SelectedIndex>-1))
            {

                if (cboxIdentity.Text == "學員")
                {
                    ClassMytools.Who = cboxIdentity.Text;
                    ClassMytools.Class = cboxClass.Text;
                    ClassMytools.Name = cboxstName.Text;
                }
                else
                {
                    ClassMytools.Who = cboxIdentity.Text;
                    ClassMytools.Class = cboxClass.Text;
                    OrderListElement.ResponsibleMan = cboxstName.Text;
                    ClassMytools.ID = listSTID[cboxstName.SelectedIndex];
                }

                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Hide();
            }
            
            



        }

        private void Login_Load(object sender, EventArgs e)
        {
                     
            mydbconnection = ConfigurationManager.ConnectionStrings["myordersystemConnectionString1"].ConnectionString;
          

            
            cboxIdentity.Items.Add("學員");                      
            cboxIdentity.Items.Add("管理員");

            //匯入表單內之班級,to comboxbox
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "select class from [StudentINFO] group by [class]";
            SqlCommand cmd = new SqlCommand(tsql, conn);
            SqlDataReader readclass = cmd.ExecuteReader();           

           
            int count = 0;

            while ((readclass.Read() == true) && (count < 100))
            {
                cboxClass.Items.Add((string)readclass["class"]);
            }
            readclass.Close();         
            conn.Close();



            panel3.Visible = false;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            RegisterPage toregister = new RegisterPage();
            toregister.ShowDialog();
        }

        private void cboxIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void cboxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxstName.Items.Clear();
            cboxstName.Text = null;
            if (cboxClass.SelectedIndex >= 0)
            {
                SqlConnection conn = new SqlConnection(mydbconnection);
                conn.Open();
                string tsql2 = "select * from [StudentINFO] where class=@class ";
                SqlCommand cmd2 = new SqlCommand(tsql2, conn);
                cmd2.Parameters.AddWithValue("@class", cboxClass.Text);
                SqlDataReader read = cmd2.ExecuteReader();

                while (read.Read())
                {
                    listSTID.Add((string)read["st_id"]);
                    cboxstName.Items.Add((string)read["st_name"]);
                }
                read.Close();
                conn.Close();
            }
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            讀取班級();

          
           
        }
        private void 讀取班級()
        {
            cboxClass.Items.Clear();
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql2 = "select class from [StudentINFO] group by [class]";
            SqlCommand cmd = new SqlCommand(tsql2, conn);
            SqlDataReader readclass = cmd.ExecuteReader();
            int count = 0;

            while ((readclass.Read() == true) && (count < 100))
            {
                cboxClass.Items.Add((string)readclass["class"]);
            }
            readclass.Close();
            conn.Close();
            
        }       

        private void cboxstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

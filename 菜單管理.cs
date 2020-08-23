using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OrderingSystemFLATSTYLE
{
    public partial class 菜單管理 : UserControl
    {
        List<int> resID= new List<int>();//用於刪除
        string mydbconnection = "";
       
        public 菜單管理()
        {
            InitializeComponent();
        }

        private void 菜單管理_Load(object sender, EventArgs e)
        {
            mydbconnection = ConfigurationManager.ConnectionStrings["myordersystemConnectionString1"].ConnectionString;

            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "select res_id,res_name from restaurant";
            SqlCommand cmd = new SqlCommand(tsql, conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                resID.Add((int)read["res_id"]);
                cboxresName管理.Items.Add((string)read["res_name"]);
                cbox新增餐廳菜色.Items.Add((string)read["res_name"]);
            }
            read.Close();
            conn.Dispose();
            conn.Close();

            p_insertbtn.Visible = false;
            panel1.Visible = false;
        }

        private void p_resArrange_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void 讀檔餐廳資訊()
        {
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "select * from restaurant where res_id= @resID";
            SqlCommand cmd = new SqlCommand(tsql, conn);
            if (cboxresName管理.SelectedIndex > -1)
            {
                cmd.Parameters.AddWithValue("@resID", resID[cboxresName管理.SelectedIndex]);
            }
            
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                txtName.Text = (string)read["res_name"];
                txtAddress.Text = (string)read["res_address"];
                txtKind.Text = (string)read["res_kind"];
                txtPhone.Text = (string)read["res_phone"];
                txtComment.Text = (string)read["res_commemt"];
            }
            conn.Dispose();
            conn.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            txtName.Text = "";
            txtAddress.Text = "";
            txtKind.Text = "";
            txtPhone.Text = "";
            txtComment.Text = "";
            p_insertbtn.Visible = true;
            panel1.Visible = false;
        }

        private void btnSaveFix_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPhone.Text != ""))
            {
                SqlConnection conn = new SqlConnection(mydbconnection);
                conn.Open();
                string tsql = "insert into restaurant(res_name,res_address,res_kind,res_commemt,res_phone) " +
                    "values(@resName, @resAddr, @resKind, @Comment, @resPhone)";
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("@resName", txtName.Text);
                cmd.Parameters.AddWithValue("@resAddr", txtAddress.Text);
                cmd.Parameters.AddWithValue("@resKind", txtKind.Text);
                cmd.Parameters.AddWithValue("@Comment", txtComment.Text);
                cmd.Parameters.AddWithValue("@resPhone", txtPhone.Text);

                int row = cmd.ExecuteNonQuery();
                conn.Dispose();
                conn.Close();
                MessageBox.Show("資料新增成功! 共" + row.ToString() + "列受影響");
            }
            else
            {
                MessageBox.Show("姓名,電話 不可為空!");
            }

            //if (cboxresName管理.SelectedIndex > -1)
            //{
            //    讀檔餐廳資訊();
            //}

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "delete from restaurant where res_id=@resID";
            SqlCommand cmd = new SqlCommand(tsql, conn);
            if (cboxresName管理.SelectedIndex > -1)
            {
                cmd.Parameters.AddWithValue("@resID", resID[cboxresName管理.SelectedIndex]);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                conn.Close();
                MessageBox.Show("刪除成功");
            }
            else
            {
                MessageBox.Show("請選擇欲刪除之選項");
            }
           
        }

        private void cboxresName管理_SelectedIndexChanged(object sender, EventArgs e)
        {

            讀檔餐廳資訊();
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            p_insertbtn.Visible = false;

            if (cboxresName管理.SelectedIndex > -1)
            {
                panel1.Visible = true;
            }
        }

        private void btnADDdishes_Click(object sender, EventArgs e)
        {
            if ((cbox新增餐廳菜色.SelectedIndex >-1)&&(txtfoodName.Text!="")&&(txtPrice.Text!=""))
            {
                SqlConnection conn = new SqlConnection(mydbconnection);
                conn.Open();
                string tsql = "insert into foodlist(res_id,fooditems,price) values(@RID,@Food,@price)";
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("@RID", resID[cbox新增餐廳菜色.SelectedIndex]);
                cmd.Parameters.AddWithValue("@Food", txtfoodName.Text);

                int price = 0;
                System.Int32.TryParse(txtPrice.Text, out price);
                cmd.Parameters.AddWithValue("@price",price);
                
                int row = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("資料新增成功! 共" + row.ToString() + "列受影響");
            }
            else
            {
                List<string> listcheck = new List<string>();
                listcheck.Add("未選擇餐廳");
                listcheck.Add("菜品未填寫");
                listcheck.Add("價格未填入");

                foreach(string i in listcheck)
                {
                    switch (i)
                    {
                        case "未選擇餐廳":
                            if(cbox新增餐廳菜色.SelectedIndex > -1) { MessageBox.Show("請選擇餐廳"); }
                            continue;
                        case "菜品未填寫":
                            if (txtfoodName.Text =="") { MessageBox.Show("請填入菜品"); }
                            continue;
                        case "價格未填入":
                            if(txtPrice.Text =="") { MessageBox.Show("請輸入價格"); }
                            continue;
                        default:
                            break;
                    }
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int money = 0;
            bool ifnum = System.Int32.TryParse(txtPrice.Text, out money);
            if (ifnum == true)
            {
                //成功
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void txtfoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "update restaurant " +
                "set res_name =@Rname , res_address = @RAddr, res_kind = @kind, res_commemt = @Comment, res_phone = @phone" +
                "where res_id = @res_id";
            SqlCommand cmd = new SqlCommand(tsql, conn);
            cmd.Parameters.AddWithValue("@Rname",txtName.Text);
            cmd.Parameters.AddWithValue("@RAddr", txtAddress.Text);
            cmd.Parameters.AddWithValue("@kind", txtKind.Text);
            cmd.Parameters.AddWithValue("@Comment", txtComment.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@res_id", resID[cboxresName管理.SelectedIndex]);

            int row =cmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
            if (row>0)
            {
                MessageBox.Show("更新成功");
            }
        }
    }
}

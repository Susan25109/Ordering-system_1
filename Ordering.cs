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
using System.Collections;

namespace OrderingSystemFLATSTYLE
{
    public partial class Ordering : UserControl
    {
        string mydbconnection = "";
        int Amount;
        List<string> listitem = new List<string>();
        List<int> listprice = new List<int>();
        List<ArrayList> orderInfo = new List<ArrayList>();
        List<string> listSTID = new List<string>();
        List<int> listFOODID = new List<int>();
        int row;
        public Ordering()
        {
            InitializeComponent();
        }

        private void Ordering_Load(object sender, EventArgs e)
        {

            

            mydbconnection = ConfigurationManager.ConnectionStrings["myordersystemConnectionString1"].ConnectionString;
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();           
            string tsql = "select foodid,fooditems,price " +
               "from restaurant R inner join foodlist F on R.res_id = F.res_id " +
               "where R.res_id = @resID";
            SqlCommand cmd = new SqlCommand(tsql,conn);
            cmd.Parameters.AddWithValue("@resID",InsertOrderlist.insertResID.ToString());
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                listFOODID.Add((int)read["foodid"]);
                listitem.Add((string)read["fooditems"]);
                listprice.Add((int)read["price"]);
            }
            read.Close();
            conn.Close();

            for (int i = 0; i < listitem.Count; i++)//匯入lstbox
            {
                string items = listitem[i];
                int price = listprice[i];
                string str = string.Format("{0}      {1}", items, price);
                lstBox品項.Items.Add(str);
            }
                       


            if (InsertOrderlist.insertOid != null)
            {
                lblOID.Text = InsertOrderlist.insertOid.ToString();
            }
            else
            {
                lblOID.Text = "尚未建立訂單";
            }

            if (ClassMytools.Name != null)
            {
                lblstname.Text = ClassMytools.Name.ToString();
            }
            else
            {
                lblstname.Text = OrderListElement.ResponsibleMan.ToString();
            }

            if (InsertOrderlist.insertRName != null)
            {
                lblTitle.Text = InsertOrderlist.insertRName.ToString();//如餐廳為null//原匯入資料消失//未先指定即跳錯
            }
            else
            {
                lblTitle.Text = "尚未指定餐廳";
            }


            
            txtAmount.Text = "1";
            Amount = 1;
            

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if(txtAmount.Text!="")
            {
                bool ifnum = System.Int32.TryParse(txtAmount.Text, out Amount);
                if((ifnum==true)&&(Amount>=1))
                {
                   
                }
                else
                {
                    txtAmount.Text = "1";
                    Amount = 1;
                    MessageBox.Show("錯誤!請輸入數量");
                }
            }
            else
            {
                txtAmount.Text = "1";
                Amount = 1;
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstbox已選購.Items.Count > 0)
            {

                DialogResult r=MessageBox.Show("送出後將無法更改,確定送出訂單??","送出成功",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                //匯入OrderlistElement
                if (r == DialogResult.Yes)
                {
                    
                    foreach(ArrayList i in orderInfo)
                    {
                        int Foodid = (int)i[3];
                        int amount = (int)i[2];

                        SqlConnection conn = new SqlConnection(mydbconnection);
                        conn.Open();
                        string tsql = "insert into OrderINFODetail(order_id,st_id,foodid,amount) " +
                            "values(@OID,@stid,@foodid,@amount)";
                        SqlCommand cmd = new SqlCommand(tsql, conn);
                        cmd.Parameters.AddWithValue("@OID", InsertOrderlist.insertOid.ToString());
                        cmd.Parameters.AddWithValue("@stid",ClassMytools.ID);
                        cmd.Parameters.AddWithValue("@foodid",Foodid);
                        cmd.Parameters.AddWithValue("@amount",amount);

                        row=cmd.ExecuteNonQuery();

                        conn.Close();                      
                       
                        lstbox已選購.Items.Clear();
                    }
                    if (row > 0)
                    {
                        MessageBox.Show("共"+row.ToString()+"筆資料送出");
                    }
                }
                else
                {
                    MessageBox.Show("請三思您的餐點");
                }
            }
            else
            {
                MessageBox.Show("請選擇餐點");
            }
            
        }

        private void lstBox品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox品項.SelectedIndex > -1)
            {
                int p = listprice[lstBox品項.SelectedIndex];
                lblPrice.Text = p.ToString();
            }
           
        }
        private int 小計()
        {
            int sub = 0;           
            
              
            foreach(ArrayList m in orderInfo)
            {
                int P = (int)m[1];
                int A = (int)m[2];    

                 sub +=P*A ;       
            }                 
            
            lblSubtotal.Text = "小計:" + sub.ToString() + "元";            
            return sub;
           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            lstbox已選購.Items.Clear();
            if ((lstBox品項.SelectedIndex > -1) && (txtAmount.Text != ""))
            {
                string items = listitem[lstBox品項.SelectedIndex].ToString();
                int money =listprice[lstBox品項.SelectedIndex];
                int foodid = listFOODID[lstBox品項.SelectedIndex];
                ArrayList array = new ArrayList();
                array.Add(items);
                array.Add(money);
                array.Add(Amount);
                array.Add(foodid);
              

               orderInfo.Add(array);
                


                foreach(ArrayList info in orderInfo)//匯入lstbox//為因應刪除功能不直接影響listitems,另匯入新list
                {
                    string 品項 = (string)info[0];
                    int 價錢 = (int)info[1];
                    int 數量 = (int)info[2];
                    string str = string.Format("{0}  {1}元  {2}個", 品項, 價錢, 數量);
                    lstbox已選購.Items.Add(str);
                }
            }
            else
            {
                MessageBox.Show("請檢查品項是否輸入!");
            }
            小計();

        }

        private void pboxremove_Click(object sender, EventArgs e)
        {
            if (lstbox已選購.SelectedIndices.Count > 0)
            {
                for (int i = lstbox已選購.SelectedIndices.Count-1; i >= 0; i--)
                {
                    orderInfo.RemoveAt(lstbox已選購.SelectedIndices[i]);
                    lstbox已選購.Items.RemoveAt(lstbox已選購.SelectedIndices[i]);
                }
            }
            小計();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Collections;

namespace OrderingSystemFLATSTYLE
{
    public partial class Orderlist : UserControl
    {
        List<string> listOID = new List<string>();
        //匯入訂單細項之項目
        List<string> listOitems = new List<string>();
        List<string> listStname = new List<string>();
        List<int> listfoodid = new List<int>();
        List<int> listAmount = new List<int>();
        List<string> listStid = new List<string>();
        List<int> listPrice = new List<int>();
        //匯入訂單主檔之名稱
        int RID;
        string RMAN;
        string RNAME;
        string Phone;

        int Sub;
        int A;
        List<int> listsub = new List<int>();

        string mydbconnection = "";
        public Orderlist()
        {
            InitializeComponent();
        }

        private void Orderlist_Load(object sender, EventArgs e)
        {
            


            listViewOrder.View = View.Details;
            listViewOrder.Columns.Add("品項",108);
            listViewOrder.Columns.Add("數量", 40);
            listViewOrder.Columns.Add("單價", 50);
            listViewOrder.Columns.Add("姓名", 95);
            listViewOrder.Columns.Add("小計", 40);
            listViewOrder.FullRowSelect = true;

            mydbconnection = ConfigurationManager.ConnectionStrings["myordersystemConnectionString1"].ConnectionString;
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql01 = "select order_id from OrderINFOMaster group by order_id ";
            SqlCommand cmd1 = new SqlCommand(tsql01, conn);
            SqlDataReader read1 = cmd1.ExecuteReader();

            while (read1.Read())
            {
                cboxOrderNum.Items.Add((string)read1["order_id"]);
                listOID.Add((string)read1["order_id"]);
            }
            read1.Close();
            conn.Dispose();          
                      
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            if (listPrice.Count>0)
            {
                for (int o = 0; o <= listfoodid.Count - 1; o++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                    item.Tag = listfoodid[o];
                    item.Tag = listStid[o];
                    item.Text = listOitems[o];
                    item.SubItems.Add(listAmount[o].ToString());
                    item.SubItems.Add(listPrice[o].ToString());
                    item.SubItems.Add(listStname[o].ToString());

                    if (listPrice.Count > 0)
                    {
                        for (int n = 0; n < listPrice.Count; n++)
                        {
                            int p = listPrice[n] * listAmount[n];
                            listsub.Add(p);
                        }
                    }
                    else
                    {
                        MessageBox.Show("價格載入錯誤");
                    }
                    

                    item.SubItems.Add(listsub[o].ToString());
                    listViewOrder.Items.Add(item);
                    計算總價();
                    數量總計();
                }
            }
            else
            {
                MessageBox.Show("此訂單無訂購品項");
            }
            
            
            
        }

        private void btndroplist_Click(object sender, EventArgs e)
        {

            DialogResult r= MessageBox.Show("確定要刪除整個訂單??","刪除訂單",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(mydbconnection);
                conn.Open();
                string tsql = "delete from OrderINFOMaster where order_id=@OID";
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("@OID", listOID[cboxOrderNum.SelectedIndex].ToString());
                int row=cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show("刪除訂單");
                }
                conn.Dispose();
                conn.Close();
                listViewOrder.Items.Clear();
                計算總價();
                數量總計();
            }
           
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            DialogResult r= MessageBox.Show("確定刪除該項目?","刪除",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if ((r == DialogResult.Yes) && (listViewOrder.SelectedIndices.Count > 0))
            {
                SqlConnection conn = new SqlConnection(mydbconnection);
                conn.Open();
               
                if (listViewOrder.SelectedItems.Count > 0)
                {
                    string tsql = "delete from OrderINFODetail where order_id=@OID and foodid=@fID and st_id=@sID";
                    SqlCommand cmd = new SqlCommand(tsql, conn);
                    cmd.Parameters.AddWithValue("@OID", listOID[cboxOrderNum.SelectedIndex].ToString());
                    cmd.Parameters.AddWithValue("@fID", listfoodid[listViewOrder.Items.IndexOf(listViewOrder.SelectedItems[0])]);
                    cmd.Parameters.AddWithValue("@sID", listStid[listViewOrder.Items.IndexOf(listViewOrder.SelectedItems[0])]);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("刪除成功");
                    }
                    listAmount.RemoveAt(listViewOrder.Items.IndexOf(listViewOrder.SelectedItems[0]));
                    listfoodid.RemoveAt(listViewOrder.Items.IndexOf(listViewOrder.SelectedItems[0]));
                    listOitems.RemoveAt(listViewOrder.Items.IndexOf(listViewOrder.SelectedItems[0]));
                    listPrice.RemoveAt(listViewOrder.Items.IndexOf(listViewOrder.SelectedItems[0]));
                    listStname.RemoveAt(listViewOrder.Items.IndexOf(listViewOrder.SelectedItems[0]));
                    listStid.RemoveAt(listViewOrder.Items.IndexOf(listViewOrder.SelectedItems[0]));
                    listViewOrder.Items.Remove(listViewOrder.SelectedItems[0]);
                    計算總價();
                    數量總計();
                }
                
            }
        }

        private void btnDELALL_Click(object sender, EventArgs e)
        {
            DialogResult r =MessageBox.Show("確定刪除所有紀錄?","刪除成功",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                listAmount.Clear();
                listfoodid.Clear();
                listOitems.Clear();
                listPrice.Clear();
                listStname.Clear();
                listStid.Clear();
                SqlConnection conn = new SqlConnection(mydbconnection);
                conn.Open();
                string tsql = "delete from OrderINFODetail where order_id=@OID";
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("@OID", listOID[cboxOrderNum.SelectedIndex].ToString());
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("共" + row.ToString() + "筆項目刪除");
                listViewOrder.Items.Clear();
                計算總價();
                數量總計();
            }
           
        }


        private int 計算總價()
        {
            int sub = 0;
            for (int i = 0; i < listAmount.Count; i++)
            {

                sub += listPrice[i]*listAmount[i];
            }
            lblTotalSum.Text = "共" + sub.ToString() + "元";
            Sub = sub;
            return sub;

        }

        private int 數量總計()
        {
            int a = 0;
            
            
            a =listAmount.Sum();
            
            lbl數量.Text = "共" + a.ToString() + "份餐點";
            A = a;
            return a;
            
        }

        private void cboxOrderNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxOrderNum.SelectedIndex > -1)
            {
                SqlConnection conn = new SqlConnection(mydbconnection);
                conn.Open();
                string tsql02 = "select *from OrderINFOMaster OM inner join restaurant r on OM.res_id=r.res_id " +
               "where order_id=@OID and class=@class";
                SqlCommand cmdgetOM = new SqlCommand(tsql02, conn);
                cmdgetOM.Parameters.AddWithValue("@OID", listOID[cboxOrderNum.SelectedIndex].ToString());
                cmdgetOM.Parameters.AddWithValue("@class", ClassMytools.Class.ToString());
                SqlDataReader readOM = cmdgetOM.ExecuteReader();

                while (readOM.Read())
                {
                    RID = (int)readOM["res_id"];
                    RMAN = (string)readOM["responsibleMan"];
                    RNAME = (string)readOM["res_name"];
                    Phone = (string)readOM["res_phone"];
                }
                readOM.Close();


                string tsql = "select* from OrderINFODetail  where order_id = @OID";
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("@OID", listOID[cboxOrderNum.SelectedIndex].ToString());
                SqlDataReader read = cmd.ExecuteReader();


                while (read.Read())
                {
                    listfoodid.Add((int)read["foodid"]);
                    listStid.Add((string)read["st_id"]);
                    listAmount.Add((int)read["amount"]);
                }
                read.Close();


                for (int i = 0; i <= listfoodid.Count - 1; i++)
                {
                    string tsql2 = "select * from foodlist where foodid=@fID";
                    SqlCommand cmd2 = new SqlCommand(tsql2, conn);
                    cmd2.Parameters.AddWithValue("@fID", listfoodid[i]);
                    SqlDataReader read2 = cmd2.ExecuteReader();

                    while (read2.Read())
                    {
                        listOitems.Add((string)read2["fooditems"]);
                        listPrice.Add((int)read2["price"]);
                    }
                    read2.Close();
                }

                conn.Close();
                conn.Dispose();

                for (int j = 0; j <= listStid.Count - 1; j++)
                {
                    SqlConnection conn2 = new SqlConnection(mydbconnection);
                    conn2.Open();
                    string tsql3 = "select*from StudentINFO where st_id=@stid";
                    SqlCommand cmd3 = new SqlCommand(tsql3, conn2);
                    cmd3.Parameters.AddWithValue("@stid", listStid[j]);
                    SqlDataReader read3 = cmd3.ExecuteReader();

                    while (read3.Read())
                    {
                        listStname.Add((string)read3["st_name"]);
                    }
                    read3.Close();
                    conn2.Close();
                }


               
                lblOrdernum.Text = listOID[cboxOrderNum.SelectedIndex].ToString();
                lblRes_name.Text = RNAME.ToString();
                lblOrderPerson.Text = RMAN.ToString();
            }
        }

        private void btn匯出_Click(object sender, EventArgs e)
        {
            string str匯出路徑 = @"";
            string str檔名 = "午餐訂購.txt";
            string 完整路徑 = str匯出路徑 + str檔名;

            List<string> 檔案內容 = new List<string>();



            檔案內容.Add("  " +RNAME+"訂購單");
            檔案內容.Add(" " + "電話: " +Phone.ToString());
            檔案內容.Add(" "+"=======================");
            檔案內容.Add("　"+DateTime.Now.ToString()+"　 "+"訂購人:"+RMAN.ToString());
            檔案內容.Add("-------------------------------------------------------------");
            檔案內容.Add(" "+"單號:"+listOID[cboxOrderNum.SelectedIndex]);
            檔案內容.Add("-------------------------------------------------------------");

            for(int i = 0; i <= listOitems.Count - 1; i++)
            {
                string 品項 = listOitems[i].ToString();
                string 數量 = listAmount[i].ToString();
                string 單價 = listPrice[i].ToString();
                string 姓名 = listStname[i].ToString();
                string 小計 = listsub[i].ToString();
                string str明細 = string.Format(" "+(i+1)+"."+" {0}  {1}份 {2}元 {3}  共{4}元", 品項, 數量, 單價, 姓名, 小計);
                檔案內容.Add(str明細);
            }

            檔案內容.Add(" "+"總共 "+Sub.ToString()+" 元"+"    "+"共"+A.ToString()+" 份餐點");
            System.IO.File.WriteAllLines(完整路徑,檔案內容,Encoding.UTF8);

            MessageBox.Show("匯出完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "update OrderINFOMaster set abletobook = 0 where order_id =@OID";
            SqlCommand cmd = new SqlCommand(tsql,conn);
            cmd.Parameters.AddWithValue("@OID",listOID[cboxOrderNum.SelectedIndex]);
            int row=cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("停止訂購");
            }
            conn.Dispose();
            conn.Close();
        }
    }
}

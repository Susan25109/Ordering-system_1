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
using System.Data.SqlTypes;
using System.Collections;

namespace OrderingSystemFLATSTYLE
{    

    public partial class Menu_Managercs : UserControl
    {
        List<int> list = new List<int>();
        List<string> listitem =new List<string>();
        List<int> listprice = new List<int>();
        string Orderid;
        string insertOID;
        int insertRID;
        string insertRMan;
        string stclass;
        
        string mydbconnection = "";
        public Menu_Managercs()
        {
            InitializeComponent();
        }

        private void Menu_Managercs_Load(object sender, EventArgs e)
        {
            mydbconnection = ConfigurationManager.ConnectionStrings["myordersystemConnectionString1"].ConnectionString;


            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "select res_id,res_name from restaurant";
            SqlCommand cmd = new SqlCommand(tsql, conn);
            SqlDataReader readResName = cmd.ExecuteReader();


            while (readResName.Read())
            {
                
                list.Add((int)readResName["res_id"]);//匯入resid
                cboxRes.Items.Add((string)readResName["res_name"]);
            }

            readResName.Close();

            string tsql2 = "IF EXists(select order_id from OrderINFOMaster where order_id is not null) " +
                "select order_id from OrderINFOMaster where [class]=@class and [abletobook]=1 group by order_id; ";
            SqlCommand cmd2 = new SqlCommand(tsql2, conn);
            cmd2.Parameters.AddWithValue("@class",ClassMytools.Class.ToString());
            SqlDataReader read = cmd2.ExecuteReader(); 

            while (read.Read())
            {
                cboxOrderidExisit.Items.Add((string)read["order_id"]);
            }

            read.Close();

            //匯入已存在之訂單
            if (cboxOrderidExisit.SelectedIndex>-1)
            {
                string tsql3 = "IF EXists" +
                "(select order_id from OrderINFOMaster where order_id is not null) " +
                "select* from OrderINFOMaster where [order_id]=@OID and [class]=@class and [abletobook]=1";
                SqlCommand cmd3 = new SqlCommand(tsql3, conn);
                cmd3.Parameters.AddWithValue("@OID", cboxOrderidExisit.Text);
                cmd3.Parameters.AddWithValue("@class", ClassMytools.Class.ToString());
                SqlDataReader read2 = cmd3.ExecuteReader();
                while (read2.Read())
                {
                    insertOID= (string)read2["order_id"];
                    insertRID = (int)read2["res_id"];
                    insertRMan = (string)read2["responsibleMan"];
                }
                read2.Close();
            }
            


            conn.Close();



            lblClass_Menu.Text = ClassMytools.Class.ToString();
        }

        private void cboxRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lstDecidedItem.Items.Clear();
            listitem.Clear();
            listprice.Clear();
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql2 = "select fooditems,price " +
               "from restaurant R inner join foodlist F on R.res_id = F.res_id " +
               "where R.res_id = @resID";
            SqlCommand cmd2 = new SqlCommand(tsql2, conn);


            cmd2.Parameters.AddWithValue("@resID", list[cboxRes.SelectedIndex]);
            SqlDataReader readitems = cmd2.ExecuteReader();


           
            while (readitems.Read())//可在宣告全域變數,美觀排版
            {

                listitem.Add((string)readitems["fooditems"]);
                listprice.Add((int)readitems["price"]);
            }

            
            readitems.Close();
            conn.Close();

           

            for (int i = 0; i < listitem.Count; i++)//匯入lstbox
            {
                string items = listitem[i];
                int price = listprice[i];
                string str = string.Format("{0}      {1}", items, price);
                lstDecidedItem.Items.Add(str);
            }

            


        }
              
        private void 讀取訂單()
        {
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            if (cboxOrderidExisit.SelectedIndex > -1)
            {
                string tsql3 = "select* from OrderINFOMaster where [order_id]=@OID and [class]=@class and [abletobook]=1";
                SqlCommand cmd3 = new SqlCommand(tsql3, conn);
                cmd3.Parameters.AddWithValue("@OID", cboxOrderidExisit.Text);
                cmd3.Parameters.AddWithValue("@class", ClassMytools.Class.ToString());
                SqlDataReader read2 = cmd3.ExecuteReader();
                while (read2.Read())
                {
                    insertOID = (string)read2["order_id"];
                    insertRID = (int)read2["res_id"];
                    insertRMan = (string)read2["responsibleMan"];
                }
                read2.Close();
            }
            conn.Close();

        }
     
        private void btn_assignMenu_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string date =dateTimePicker1.Value.ToString("yyMMdd");
            Orderid = date.ToString()+ ClassMytools.Class.ToString()+random.Next(100,999).ToString();

           DialogResult r=MessageBox.Show("確定新增訂單?","指定成功",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (r == DialogResult.Yes)
            {
                RestaurantGear.IDaccess = list[cboxRes.SelectedIndex];//存入餐廳id,用以匯出
                RestaurantGear.餐廳 = cboxRes.Text;//存入餐廳名稱,用以匯出
                OrderListElement.O_ID = Orderid;
                if (RestaurantGear.餐廳 != null)
                {
                    cboxRes.Text = RestaurantGear.餐廳.ToString();
                }
                SqlConnection conn = new SqlConnection(mydbconnection);
                conn.Open();
                string tsql = "insert into OrderINFOMaster(order_id,res_id,class,ordertime,responsibleMan) values(@orderid,@resID,@class,@date,@RMan)";
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("@orderid",Orderid);
                cmd.Parameters.AddWithValue("@resID", RestaurantGear.IDaccess);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyMMdd"));
                cmd.Parameters.AddWithValue("@RMan",OrderListElement.ResponsibleMan.ToString());
                cmd.Parameters.AddWithValue("@class", ClassMytools.Class.ToString());
                int row=cmd.ExecuteNonQuery();

                MessageBox.Show("共"+row.ToString()+"個資料受影響");
                conn.Close();
            }
            else
            {
                MessageBox.Show("請選擇要指定的店家");
            }

            OrderListElement.O_ID = Orderid;
        }

        private void btnSetOrder_Click(object sender, EventArgs e)
        {
            if (cboxOrderidExisit.SelectedIndex >= 0)
            {
                InsertOrderlist.insertOid = cboxOrderidExisit.Text;
                InsertOrderlist.insertResID = insertRID;
                InsertOrderlist.Rman = insertRMan;
                InsertOrderlist.insertclass = stclass;
                MessageBox.Show("指派成功");
            }
            else
            {
                MessageBox.Show("請選擇訂單");
            }
           

        }

        private void cboxOrderidExisit_SelectedIndexChanged(object sender, EventArgs e)
        {
            讀取訂單();
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "select * from OrderINFOMaster OM inner join restaurant r on OM.res_id=r.res_id " +
                "where r.res_id =@resid";
            SqlCommand cmd = new SqlCommand(tsql,conn);
            cmd.Parameters.AddWithValue("@resid", insertRID);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                InsertOrderlist.insertRName = (string)read["res_name"];
                InsertOrderlist.insertPhone = (string)read["res_phone"];
                stclass = (string)read["class"];
               // InsertOrderlist.insertdate = (string)read["ordertime"];//轉型不成功

            }
            conn.Dispose();
            lbl店名_menuM.Text = InsertOrderlist.insertRName.ToString();
           // lbldate_MenuM.Text = InsertOrderlist.insertdate.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboxOrderidExisit.Items.Clear();
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql2 = "IF EXists(select order_id from OrderINFOMaster where order_id is not null) " +
                "select order_id from OrderINFOMaster where [class]=@class and [abletobook]=1 group by order_id ";
            SqlCommand cmd2 = new SqlCommand(tsql2, conn);
            cmd2.Parameters.AddWithValue("@class", ClassMytools.Class.ToString());
            SqlDataReader read = cmd2.ExecuteReader();

            while (read.Read())
            {
                cboxOrderidExisit.Items.Add((string)read["order_id"]);
            }

            read.Close();
            conn.Close();
            conn.Dispose();
        }
    }
}

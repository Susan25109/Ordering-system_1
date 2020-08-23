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
    public partial class Menu_學員 : UserControl
    {
        string mydbconnection = "";
        List<int> listresid = new List<int>();
        List<string> listitem2 = new List<string>();
        List<int> listprice2 = new List<int>();
        string Comment2="";
        string Address = "";
        string Kind = "";
        string Phone = "";
        
        public Menu_學員()
        {
            InitializeComponent();
        }

        private void Menu_學員_Load(object sender, EventArgs e)
        {
            mydbconnection = ConfigurationManager.ConnectionStrings["myordersystemConnectionString1"].ConnectionString;


            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql = "select res_id,res_name from restaurant";
            SqlCommand cmd = new SqlCommand(tsql, conn);
            SqlDataReader readResName = cmd.ExecuteReader();


            while (readResName.Read())
            {
                listresid.Add((int)readResName["res_id"]);
                cbox學生餐廳名稱.Items.Add((string)readResName["res_name"]);               
            }

            readResName.Close();
            conn.Close();
        }

        private void cbox學生餐廳名稱_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstboxItems.Items.Clear();
            listitem2.Clear();
            listprice2.Clear();
            SqlConnection conn = new SqlConnection(mydbconnection);
            conn.Open();
            string tsql2 = "select fooditems,price " +
               "from restaurant R inner join foodlist F on R.res_id = F.res_id " +
               "where R.res_id = @resID";
            SqlCommand cmd = new SqlCommand(tsql2, conn);
            cmd.Parameters.AddWithValue("@resID",listresid[cbox學生餐廳名稱.SelectedIndex]);
            SqlDataReader readitems = cmd.ExecuteReader();

            while (readitems.Read())
            {
                listitem2.Add((string)readitems["fooditems"]);
                listprice2.Add((int)readitems["price"]);
            }

            for(int i=0; i < listitem2.Count; i++)
            {
                string foods = listitem2[i];
                int price2 = listprice2[i];
                string str2 = string.Format("{0}    {1}",foods,price2);
                lstboxItems.Items.Add(str2);
            }
            readitems.Close();

            string tsql3 = "select res_address,res_kind,res_commemt,res_phone from restaurant where res_id=@resID";
            SqlCommand cmd2 = new SqlCommand(tsql3, conn);
            cmd2.Parameters.AddWithValue("@resID", listresid[cbox學生餐廳名稱.SelectedIndex]);
            SqlDataReader readInfo = cmd2.ExecuteReader();

            while (readInfo.Read())
            {
                Address = (string)readInfo["res_address"];
                Kind = (string)readInfo["res_kind"];
                Phone = (string)readInfo["res_phone"];
                Comment2 = (string)readInfo["res_commemt"];
            }
            conn.Close();
           
            lblAddress.Text = Address.ToString();//學生菜單瀏覽//RG全域屬性將挪用於Manager版之Menu
            lblKind.Text = Kind.ToString();
            lblPhone.Text = Phone.ToString();
            lblComment.Text = Comment2.ToString();
        }
    }
}

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

namespace OrderingSystemFLATSTYLE
{
    public partial class RegisterPage : Form
    {
        string mydbconncetionString = "";

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            mydbconncetionString = ConfigurationManager.ConnectionStrings
                ["myordersystemConnectionString1"].ConnectionString;

        

        }

        private void lblbacktoRPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfirmRegister_Click(object sender, EventArgs e)//資料庫未連動
        {
            SqlConnection conn = new SqlConnection(mydbconncetionString);


            if ((txtstID.Text != "") && (txtPW.Text != "") && (txtName.Text != "") && (txtClass.Text != ""))
            {
               
                conn.Open();             
                string tsql = "insert into StudentINFO values" +
                    "(@stID, @stPW, @NewName, @NewClass, @Phone, @Mail)";
                SqlCommand cmd = new SqlCommand(tsql, conn);


                cmd.Parameters.AddWithValue("@stID", txtstID.Text);//必填
                cmd.Parameters.AddWithValue("@stPW", txtPW.Text);//必填
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);//必填
                cmd.Parameters.AddWithValue("@NewClass", txtClass.Text);//必填
                //cmd.Parameters.AddWithValue("@Phone", txtPhone);//數字型別
                cmd.Parameters.AddWithValue("@Mail", txtemail.Text);

                int myphone;
                System.Int32.TryParse(txtPhone.Text, out myphone);
                cmd.Parameters.AddWithValue("@Phone", myphone); 

                int row = cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("註冊成功,影響"+row.ToString()+"筆資料數");

                this.Close();

            }
            else
            {
                conn.Close();
                MessageBox.Show("學號,密碼,姓名,班級 為必填!!");
            }          

        }
    }
}

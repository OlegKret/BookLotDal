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

namespace Test2
{
    public partial class Login : Form
    {
        string connectionString = @"data source = DESKTOP-3NFJB2R\SQLEXPRESS; initial catalog = Users;  integrated security = True;";
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields");
            }
            SqlConnection con = new SqlConnection(@"data source = DESKTOP-3NFJB2R\SQLEXPRESS; initial catalog = Users;  integrated security = True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Role FROM [Users].[dbo].[Table] Where Login='" + txtLogin.Text + "' and Password='" + txtPassword.Text + "'", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Parent ss = new Parent(dt.Rows[0][0].ToString());
                ss.Show();
                //((Form)this.MdiParent).Controls["label1"].Text = dt.Rows[0][0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields");
            }
             else if (checkLogin() == true)
            {
                label11.Text = "Your Login Already Registered";
                txt_Login.BackColor = System.Drawing.Color.CornflowerBlue;
                label11.Visible = true;
            }
            else if (checkPhone() == true)
            {
                label12.Text = "Your Phone Already Registered";
                txtPhone.BackColor = System.Drawing.Color.CornflowerBlue;
                label12.Visible = true;
            }
            else if (checkUser() == true)
            {
                label13.Text = "Your Name Already Registered";
                txtFirstName.BackColor = System.Drawing.Color.CornflowerBlue;
                label13.Visible = true;
                label14.Text = "Your LastName Already Registered";
                txtLastName.BackColor = System.Drawing.Color.CornflowerBlue;
                label14.Visible = true;
            }

            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("LastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Phone", txtPhone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Adress", txtAdress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Login", txt_Login.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("Password", txt_Password.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    Clear();
                }
            }
        }
        private Boolean checkLogin()
        {
            Boolean loginavailable = false;
            string mycon = @"data source = DESKTOP-3NFJB2R\SQLEXPRESS; initial catalog = Users;  integrated security = True;";
            string myquery = "Select * from [Users].[dbo].[Table] where Login='" + txt_Login.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                loginavailable = true;
            }
            con.Close();
            return loginavailable;
        }
        private Boolean checkPhone()
        {
            Boolean loginavailable = false;
            string mycon = @"data source = DESKTOP-3NFJB2R\SQLEXPRESS; initial catalog = Users;  integrated security = True;";
            string myquery = "Select * from [Users].[dbo].[Table] where Phone='" + txtPhone.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                loginavailable = true;
            }
            con.Close();
            return loginavailable;
        }
        private Boolean checkUser()
        {
            Boolean useravailable = false;
            string mycon = @"data source = DESKTOP-3NFJB2R\SQLEXPRESS; initial catalog = Users;  integrated security = True;";
            string myquery = "Select * from [Users].[dbo].[Table] where FirstName='" + txtFirstName.Text + "' and LastName='" + txtLastName.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                useravailable = true;
            }
            con.Close();
            return useravailable;
        }
        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtPhone.Text = txtAdress.Text =
                txt_Login.Text = txtPassword.Text = "";
        }
    }
}

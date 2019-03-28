using BookServise.ServiceReference2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfServiceBooks.DAL;

namespace BookServise
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Database.SetInitializer(new DataInitializer());
            //new BookLotEntities().Database.Initialize(true);
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (txtLogin.Text == "")
                    {
                        throw new EmptyLoginException("Введіть логін!");
                    }
                    if (txtPassword.Text == "")
                    {
                        throw new EmptyPasswordException("Введіть пароль!");
                    }

                    AccountClient accountClient = new AccountClient();
                    User input = accountClient.Login(txtLogin.Text, txtPassword.Text);
                //SqlConnection con = new SqlConnection();
                //SqlDataAdapter sda = new SqlDataAdapter("Select Role FROM User Where Login='" + txtLogin.Text + "' and Password='" + txtPassword.Text + "'", con);
                //DataTable dt = new System.Data.DataTable();
                //sda.Fill(dt);
                //this.Hide();
                //foreach (User c in context.Users.SqlQuery("Select role FROM Users Where Login='" + txtLogin.Text + "' and Password='" + txtPassword.Text + "'")) ;
                SqlConnection con = new SqlConnection(@"data source=WCFServise.mssql.somee.com;initial catalog=WCFServise;user id=OlegKret_SQLLogin_1;password=tqyupwho8j");
                SqlDataAdapter sda = new SqlDataAdapter("Select Role FROM Users Where Login='" + txtLogin.Text + "' and Password='" + txtPassword.Text + "'", con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Parent ss = new Parent(dt.Rows[0][0].ToString());
                    ss.Show();
                    //((Form)this.MdiParent).Controls["label1"].Text = dt.Rows[0][0].ToString();
                }

                //Parent ss = new Parent(input.ToString());
                //    ss.Show();
                if (input != null)
                {
                        MessageBox.Show("Вхід успішний!");

                        //if (input.PhotoName != null)
                        //{
                        //    Form2 form2 = new Form2(accountClient.GetImage(input.PhotoName));
                        //    form2.ShowDialog();
                        //}
                        //else
                        //{
                        //    Form2 form2 = new Form2(null);
                        //    form2.ShowDialog();
                        //}

                    }
                    if (input == null)
                    {
                        MessageBox.Show("Ви НЕ ввійшли в особистий кабінет! \n Перевірте логін і пароль!");
                    }

                    accountClient.Close();
                }
                catch (EmptyLoginException emptyLoginException)
                {
                    MessageBox.Show(emptyLoginException.Message);
                }
                catch (EmptyPasswordException emptyPasswordException)
                {
                    MessageBox.Show(emptyPasswordException.Message);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {

            if (checkLogin() == true || checkPhone() == true || checkEmail() == true)
            {
                label8.Text = "Your Login Already Registered";
                txt_Login.BackColor = System.Drawing.Color.CornflowerBlue;
                label8.Visible = true;

                label10.Text = "Your Phone Already Registered";
                txtPhoneNumber.BackColor = System.Drawing.Color.CornflowerBlue;
                label10.Visible = true;

                label9.Text = "Your Email Already Registered";
                txtEmail.BackColor = System.Drawing.Color.CornflowerBlue;
                label9.Visible = true;
            }


            //else if ()
            //{

            //}
            //else if ()
            //{

            //}

            else
            {
                if (pictureBox1.Image != null && checkLogin() != true && checkPhone() != true && checkEmail() != true)
                {
                    //AccountClient accountClient = new AccountClient();
                    string fname = txtId.Text + ".jpg";
                    string folder = "C:\\Images";
                    string pathstring = System.IO.Path.Combine(folder, fname);
                    Image a = pictureBox1.Image;
                    a.Save(pathstring);


                    User user = new User();
                    //accountClient.ConvertFiltoBite(this.pictureBox1.ImageLocation);
                    user.Id = Int32.Parse(txtId.Text);
                    user.Login = txt_Login.Text;
                    user.Password = txt_Password.Text;
                    user.Email = txtEmail.Text;
                    user.PhoneNumber = txtPhoneNumber.Text;
                    user.role = txtRole.Text;
                    user.Pic = pathstring;



                    AccountClient accountClient = new AccountClient();
                    bool registered = accountClient.Register(user);

                    if (registered == true)
                    {
                        MessageBox.Show("Користувача зареєстровано!");
                    }
                }
                else
                {
                    MessageBox.Show("Choose picture...");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                try
                {
                    int userId = Int32.Parse(txtId.Text);
                    User userToUpdate = context.Users.Find(userId);
                    if (userToUpdate != null)
                    {
                        AccountClient accountClient = new AccountClient();
                       
                        userToUpdate.Id = Int32.Parse(txtId.Text);
                        userToUpdate.Login = txt_Login.Text;
                        userToUpdate.Password = txt_Password.Text;
                        userToUpdate.Email = txtEmail.Text;
                        userToUpdate.PhoneNumber = txtPhoneNumber.Text;
                        userToUpdate.role = txtRole.Text;
                        accountClient.Save(userToUpdate);
                        //context.SaveChanges();
                        accountClient.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Empty format, try again");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(txtId.Text);
            using (var context = new BookLotEntities())
            {
                User userToDelete = new User() { Id = userId };
                //context.Entry(userToDelete).State = EntityState.Deleted;
                //context.SaveChanges();
                AccountClient accountClient = new AccountClient();
                accountClient.Delete(userToDelete);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
                using (var context = new BookLotEntities())
                {
                    //foreach (Books c in context.Books)
                    //{
                    //    cboBooks.Items.Add(c.Title);

                    //}

                    var source = context.Users.ToList();
                    cboUsers.DataSource = source;
                    //cboBooks.BindingContext=this.BindingContext();
                    cboUsers.ValueMember = "Id";
                    cboUsers.DisplayMember = "Login";

                    //cboBooks.DisplayMember = "Genre";
                    cboUsers.Invalidate();
                    cboUsers.DataBindings.Clear();
                    //cboBooks.SelectedValueChanged += new EventHandler(cboBooks_SelectedValueChanged);
                    txtId.DataBindings.Add("Text", source, "Id", true);

                    txt_Login.DataBindings.Add("Text", source, "Login", true);
                    txtLogin.DataBindings.Add("Text", source, "Login", true);
                    txt_Password.DataBindings.Add("Text", source, "Password", true);
                    txtEmail.DataBindings.Add("Text", source, "Email", true);
                    txtPassword.DataBindings.Add("Text", source, "Password");
                    txtRole.DataBindings.Add("Text", source, "role");
                    txtPhoneNumber.DataBindings.Add("Text", source, "PhoneNumber");
                    txtPic.DataBindings.Add("Text", source, "Pic");
                    //pictureBox1.DataBindings.Add(new Binding("Image", source, "Pic", true));
                    //var s = from o in context.Users select o;
                   
               
            }
        }

        private Boolean checkLogin()
        {

            using (var context = new BookLotEntities())
            {
                Boolean loginavailable = false;

                int userid = (from x in context.Users
                              where x.Login == txt_Login.Text
                              select x.Id).SingleOrDefault();
                if (userid > 0)
                {
                    loginavailable = true;
                }
                return loginavailable;
            }
                
        }

        private Boolean checkPhone()
        {
           
                using (var context = new BookLotEntities())
            {
                
                    Boolean phoneavailable = false;
               
                    int userid = (from x in context.Users
                              where x.PhoneNumber == txtPhoneNumber.Text
                              select x.Id).SingleOrDefault();
                //try
                //{
                    if (userid > 0)
                    {
                        phoneavailable = true;
                    }

                //}
                //catch(Exception ex)
                //{
                //MessageBox.Show("Try....");
                //}
                return phoneavailable;
            }

        }

        private Boolean checkEmail()
        {
            using (var context = new BookLotEntities())
            {
                Boolean emailavailable = false;

                int userid = (from x in context.Users
                              where x.Email == txtPhoneNumber.Text
                              select x.Id).SingleOrDefault();
                if (userid > 0)
                {
                    emailavailable = true;
                }
                return emailavailable;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = ofd.FileName;
            }

            //OpenFileDialog open = new OpenFileDialog();
            //PictureBox p = sender as PictureBox;

            //open.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
            //open.Multiselect = false;
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    p.Image = Image.FromFile(open.FileName);
            //}

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //BookLotEntities db = new BookLotEntities();
            //var st = (from o in db.Users where o.Id == Int32.Parse(txtId.Text) select o).First();
            //txtLogin.Text = st.Login;
            //string pathstring = System.IO.Path.Combine(st.Pic);
            //pictureBox1.Image = Image.FromFile(pathstring);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("" + txtPic.Text);
        }
        AccountClient client = new AccountClient();
        private void btnNew_Click_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromStream(client.GetStream());
        }
    }

    [Serializable]
    internal class EmptyPasswordException : Exception
    {
        public EmptyPasswordException()
        {
        }

        public EmptyPasswordException(string message) : base(message)
        {
        }

        public EmptyPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

        [Serializable]
        internal class EmptyLoginException : Exception
        {
            public EmptyLoginException()
            {
            }

            public EmptyLoginException(string message) : base(message)
            {
            }

            public EmptyLoginException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected EmptyLoginException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
            public byte[] ConvertFiltoBite(string sPath)
            {
                byte[] data = null;
                FileInfo fInfo = new FileInfo(sPath);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                data = br.ReadBytes((int)numBytes);
                return data;
            }
        AccountClient client = new AccountClient();
        public void ScreenImage(string baseAddress)
        {
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
            binding.TransferMode = TransferMode.StreamedResponse;
            binding.MaxReceivedMessageSize = 1024 * 1024 * 2;
            client = new AccountClient(binding, new EndpointAddress(baseAddress));

        }
        }
    }


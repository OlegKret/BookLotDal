using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using BookServise.ServiceReference2;
using System.Runtime.Serialization;
using BookServise.ServiceReference1;
using WcfServiceBooks.DAL;
using Books = WcfServiceBooks.DAL.Books;
using System.Data.Entity;

namespace BookServise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void btnEnter_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtLogin.Text == "")
        //        {
        //            throw new EmptyLoginException("Введіть логін!");
        //        }
        //        if (txtPassword.Text == "")
        //        {
        //            throw new EmptyPasswordException("Введіть пароль!");
        //        }

        //        AccountClient accountClient = new AccountClient();
        //        User input = accountClient.Login(txtLogin.Text, txtPassword.Text);

        //        if (input != null)
        //        {
        //            MessageBox.Show("Вхід успішний!");

        //            //if (input.PhotoName != null)
        //            //{
        //            //    Form2 form2 = new Form2(accountClient.GetImage(input.PhotoName));
        //            //    form2.ShowDialog();
        //            //}
        //            //else
        //            //{
        //            //    Form2 form2 = new Form2(null);
        //            //    form2.ShowDialog();
        //            //}

        //        }
        //        if (input == null)
        //        {
        //            MessageBox.Show("Ви НЕ ввійшли в особистий кабінет! \n Перевірте логін і пароль!");
        //        }

        //        accountClient.Close();
        //    }
        //    catch (EmptyLoginException emptyLoginException)
        //    {
        //        MessageBox.Show(emptyLoginException.Message);
        //    }
        //    catch (EmptyPasswordException emptyPasswordException)
        //    {
        //        MessageBox.Show(emptyPasswordException.Message);
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Service1Client client = new Service1Client();
            
            Books books = new Books();
            //client.Add(books);
            //client.Save(books);
            books.AuthorId = Int32.Parse(txtAuthorId.Text);
            books.PublisherId = Int32.Parse(txtPublisherId.Text);
            books.Title = txtTitle.Text;
            books.ISBN = txtISBN.Text;
            books.Genre = txtGenre.Text;
            books.Type = txtType.Text;
            books.PublicationYear = txtPubYear.Text;
            books.Price = Int32.Parse(txtPrice.Text);

            books.Condition = txtCondition.Text;

            BookLotEntities lotEntities = new BookLotEntities();
            lotEntities.BookCategories.Add(books);
            lotEntities.SaveChanges();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                try
                {
                    int bookId = Int32.Parse(txtBookId.Text);
                    Books booksToUpdate = context.BookCategories.Find(bookId);
                    if (booksToUpdate != null)
                    {

                        booksToUpdate.BookId = Int32.Parse(txtBookId.Text);
                        booksToUpdate.AuthorId = Int32.Parse(txtAuthorId.Text);
                        booksToUpdate.PublisherId = Int32.Parse(txtAuthorId.Text);
                        booksToUpdate.Title = txtTitle.Text;
                        booksToUpdate.ISBN = txtISBN.Text;
                        booksToUpdate.Genre = txtGenre.Text;
                        booksToUpdate.Type = txtType.Text;
                        booksToUpdate.PublicationYear = txtPubYear.Text;
                        booksToUpdate.Price = Int32.Parse(txtPrice.Text);

                        booksToUpdate.Condition = txtCondition.Text;
                        context.SaveChanges();
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
            int bookId = Int32.Parse(txtBookId.Text);
            using (var context = new BookLotEntities())
            {
                Books booksToDelete = new Books() { BookId = bookId };
                context.Entry(booksToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label11.Text = "You login as :" + ((Form)this.MdiParent).Controls["label1"].Text;
            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                btnClear.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                
                btnUpdate.Enabled = false;
               
            }
            using (var context = new BookLotEntities())
            {
                //foreach (Books c in context.Books)
                //{
                //    cboBooks.Items.Add(c.Title);

                //}

                var source = context.BookCategories.ToList();
                cboBooks.DataSource = source;
                //cboBooks.BindingContext=this.BindingContext();
                cboBooks.ValueMember = "BookId";
                cboBooks.DisplayMember = "Title";

                //cboBooks.DisplayMember = "Genre";
                cboBooks.Invalidate();
                cboBooks.DataBindings.Clear();
                //cboBooks.SelectedValueChanged += new EventHandler(cboBooks_SelectedValueChanged);
                txtAuthorId.DataBindings.Add("Text", source, "AuthorId", true);

                txtPublisherId.DataBindings.Add("Text", source, "PublisherId", true);
                txtTitle.DataBindings.Add("Text", source, "Title", true);
                txtISBN.DataBindings.Add("Text", source, "ISBN", true);
                txtBookId.DataBindings.Add("Text", source, "BookID");
                txtGenre.DataBindings.Add("Text", source, "Genre", true);
                txtType.DataBindings.Add("Text", source, "Type", true);

                txtPubYear.DataBindings.Add("Text", source, "PublicationYear");
                txtPrice.DataBindings.Add("Text", source, "Price", true);

                txtCondition.DataBindings.Add("Text", source, "Condition", true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //cboBooks.Items.Remove(cboBooks.SelectedItem.ToString());

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
        }
    }
}

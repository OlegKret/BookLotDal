using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BookLotDal.EF;
using BookLotDal.Models;
using BookLotDal.Repos;
using System.Collections.ObjectModel;

namespace Test2
{
    public partial class Form1 : Form
    {
        Books books;
        
        public ObservableCollection<BookLotEntities> Books { get; }

        public Form1()
        {
            InitializeComponent();
            //Database.SetInitializer(new DataInitializer());
            //new BookLotEntities().Database.Initialize(true);
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Books books = new Books();
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
                lotEntities.Books.Add(books);
                lotEntities.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Empty format");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //using (var repo = new BooksRepo())
            //{
            //    int bookId = Int32.Parse(txtBooksId.Text);
            //    var booksToUpdate = repo.GetOne(bookId);
            //    if (booksToUpdate != null)
            //    {
            //        booksToUpdate.BookId = Int32.Parse(txtBooksId.Text);
            //        booksToUpdate.AuthorId = Int32.Parse(txtAuthorId.Text);
            //        booksToUpdate.PublisherId = Int32.Parse(txtAuthorId.Text);
            //        booksToUpdate.Title = txtTitle.Text;
            //        booksToUpdate.ISBN = txtISBN.Text;
            //        booksToUpdate.Genre = txtGenre.Text;
            //        booksToUpdate.Type = txtType.Text;
            //        booksToUpdate.PublicationYear = txtPubYear.Text;
            //        booksToUpdate.Price = Int32.Parse(txtPrice.Text);

            //        booksToUpdate.Condition = txtCondition.Text;
            //        repo.Save(booksToUpdate);
            //    }
            //}
            using (var context = new BookLotEntities())
            {
                try
                {
                    int bookId = Int32.Parse(txtBooksId.Text);
                    Books booksToUpdate = context.Books.Find(bookId);
                    if (booksToUpdate != null)
                    {

                        booksToUpdate.BookId = Int32.Parse(txtBooksId.Text);
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
        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int bookId = Int32.Parse(txtBooksId.Text);
            using (var context = new BookLotEntities())
            {
                Books booksToDelete = new Books() { BookId = bookId };
                context.Entry(booksToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        private void txtBksTitle_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                //foreach (Books c in context.Books)
                //{
                //    cboBooks.Items.Add(c.Title);

                //}
               
                var source = context.Books.ToList();
                cboBooks.DataSource = source;
                //cboBooks.BindingContext=this.BindingContext();
                cboBooks.ValueMember = "BookId";
                cboBooks.DisplayMember = "Title";
                
                //cboBooks.DisplayMember = "Genre";
                cboBooks.Invalidate();
                cboBooks.DataBindings.Clear();
                //cboBooks.SelectedValueChanged += new EventHandler(cboBooks_SelectedValueChanged);
                txtAuthorId.DataBindings.Add("Text", source, "AuthorId",true);
                
                txtPublisherId.DataBindings.Add("Text", source, "PublisherId",true);
                txtTitle.DataBindings.Add("Text", source, "Title", true);
                txtISBN.DataBindings.Add("Text", source, "ISBN", true);
                txtBooksId.DataBindings.Add("Text", source, "BookID");
                txtGenre.DataBindings.Add("Text", source, "Genre", true);
                txtType.DataBindings.Add("Text", source, "Type", true);
               
                txtPubYear.DataBindings.Add("Text", source, "PublicationYear");
                txtPrice.DataBindings.Add("Text", source, "Price", true);

                txtCondition.DataBindings.Add("Text", source, "Condition", true);
            }

        }



        private void cboBooks_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBooks.SelectedIndex != -1)
            {


            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            OrderItems orderItem = new OrderItems();
            Books books = new Books();
            orderItem.OrderId = Int32.Parse(txtOrderId.Text);
            orderItem.BookId = Int32.Parse(txtBookId.Text);
            orderItem.Quantity = Int32.Parse(txtQuantity.Text);
            orderItem.Price = Decimal.Parse(txt_Price.Text);

            //orderItem.Price = books.Price;
            //txtTotal.Text = (orders.Subtotal / 100 * 120).ToString();

            BookLotEntities lotEntities = new BookLotEntities();
            lotEntities.OrderItems.Add(orderItem);
            lotEntities.SaveChanges();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            using (var context = new BookLotEntities())
            {
                int orderId = Int32.Parse(txtOrderId.Text);
                OrderItems ordersToUpdate = context.OrderItems.Find(orderId);
                if (ordersToUpdate != null)
                {
                   
                        ordersToUpdate.OrderId = Int32.Parse(txtOrderId.Text);
                        ordersToUpdate.BookId = Int32.Parse(txtBookId.Text);
                        ordersToUpdate.Quantity = Int32.Parse(txtQuantity.Text);
                    decimal result ;
                    
                    ordersToUpdate.Price = Decimal.Parse(txt_Price.Text);


                    context.SaveChanges();
                  
                   
                }
            }
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int orderItem = Int32.Parse(txtOrderId.Text);
            using (var context = new BookLotEntities())
            {
                OrderItems ordersToDelete = new OrderItems() { OrderId = orderItem };
                context.Entry(ordersToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        private void btnAddDB_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
               
                var source = context.OrderItems.ToList();
                cboOrderItem.DataSource = source;
                
                cboOrderItem.ValueMember = "OrderId";
                cboOrderItem.DisplayMember = "OrderId";

                cboOrderItem.Invalidate();
                //cboOrderItem.DataSource = null;
                cboOrderItem.DataBindings.Clear();
                cboOrderItem.DataSource = source;
                 
                txtOrderId.DataBindings.Add(new Binding("Text", source, "OrderId", true));
                //txtOrderId.Clear();
                //txtOrderId.Refresh();
                txtBookId.DataBindings.Add(new Binding("Text", source, "BookId", true));
                
                txtQuantity.DataBindings.Add(new Binding("Text", source, "Quantity", true));
                txt_Price.DataBindings.Add(new Binding("Text", source, "Price", true));
                 
            }
        }

        private void btnSaveOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.OrderId = Int32.Parse(txt_OrderId.Text);
            orders.CustId = Int32.Parse(txtCustId.Text);
            orders.Subtotal = Decimal.Parse(txtSubtotal.Text);
            orders.Shipping = txtShipping.Text;
            orders.OrderDate = DateTime.Now;
            orders.Total =orders.Subtotal/100*120;
           txtTotal.Text= (orders.Subtotal / 100 * 120).ToString();
            BookLotEntities lotEntities = new BookLotEntities();
            lotEntities.Orders.Add(orders);
            lotEntities.SaveChanges();
        }

        private void updateOrders_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                
                int orderId = Int32.Parse(txt_OrderId.Text);
                Orders orders = context.Orders.Find(orderId);
                    if (orders != null)
                    {
                    try
                    {
                        orders.OrderId = Int32.Parse(txt_OrderId.Text);
                        orders.CustId = Int32.Parse(txtCustId.Text);
                        orders.Subtotal = Int32.Parse(txtSubtotal.Text);
                        orders.Shipping = txtShipping.Text;
                        orders.OrderDate = DateTime.Now;
                        orders.Total = orders.Subtotal / 100 * 120;
                        txtTotal.Text = (orders.Subtotal / 100 * 120).ToString();

                        context.SaveChanges();

                    }
                    catch(Exception ex)

                    {
                        MessageBox.Show("Just format is bad :)");
                    }
                }
            }
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {
            try
            {
                int orderItem = Int32.Parse(txt_OrderId.Text);
                using (var context = new BookLotEntities())
                {
                    Orders ordersToDelete = new Orders() { OrderId = orderItem };
                    context.Entry(ordersToDelete).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bad Format");
            }
        }

        private void btnOrdersDB_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {

                var source = context.Orders.ToList();
                cboOrders.DataSource = source;

               cboOrders.ValueMember = "OrderId";
                cboOrders.DisplayMember = "OrderId";

                cboOrderItem.Invalidate();
                cboOrderItem.DataBindings.Clear();
                txt_OrderId.DataBindings.Add(new Binding("Text", source, "OrderId", true));
                
                txtCustId.DataBindings.Add(new Binding("Text", source, "CustId", true));
                txtSubtotal.DataBindings.Add(new Binding("Text", source, "Subtotal", true));
                txtShipping.DataBindings.Add(new Binding("Text", source, "Shipping", true));
                txtTotal.DataBindings.Add(new Binding("Text", source, "Total", true));

            }
        }

        private void btnSetPrice_Click(object sender, EventArgs e)
        {
            
            using (var context = new BookLotEntities())
            {
                //var price = from d in context.Books
                //            join d1 in context.OrderItems on d.BookId equals d1.BookId
                //            //where context.Books.
                //            select new {Price= d.Price };
                //txtBooksId.Text= ( from d in context.Books
                //             where d.BookId==3
                //             select d.Price).FirstOrDefault().ToString();

                txt_Price.Text = (from d in context.Books
                                   join d1 in context.OrderItems on d.BookId equals d1.BookId
                                   where d.BookId == d1.BookId
                                   select d.Price).Any().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                try
                {
                    string value = txtQuery.Text;
                    txtQuery.Text = (from d in context.Books
                                     where d.Title.StartsWith(value)
                                     select new
                                     {
                                         d.Genre,
                                         d.BookId,
                                         d.Condition,
                                         d.ISBN,
                                         d.Price,
                                         d.PublicationYear,
                                         d.Title,
                                         d.AuthorId
                                     }).FirstOrDefault().ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Not Contain");
                }

            }
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
               
                IQueryable<Books> books = context.Books;
                IQueryable<Authors> authors = context.Authors;
                string value = txtQuery.Text;
                txtQuery.Text = (from d in context.Books
                                join d1 in context.Authors
                               on d.AuthorId equals d1.AuthorId
                               join d2 in context.OrderItems
                               on d.BookId equals d2.BookId
                               join d3 in context.Orders
                               on d.BookId equals d3.OrderItems.BookId
                               where d1.AuthorLastName.StartsWith(value)
                                 
                                 select new
                                 {
                                     d3.OrderItems.Books.Authors.AuthorFirstName,
                                     d.Genre,
                                   
                                     d.Condition,
                                     d.ISBN,
                                     d.Price,
                                     d.PublicationYear,
                                     d.Title,
                                     d.AuthorId
                                 }).ToList().ToString();
            }
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                try
                {
                    string value = txtQuery.Text;
                    txtQuery.Text = (from d in context.Books
                                     where d.Genre.StartsWith(value)
                                     select new
                                     {
                                         d.Genre,
                                         d.BookId,
                                         d.Condition,
                                         d.ISBN,
                                         d.Price,
                                         d.PublicationYear,
                                         d.Title,
                                         d.AuthorId
                                     }).FirstOrDefault().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Contain");
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                try
                {
                    string value = txtQuantity.Text;
                    txtQuery.Text = (from item in context.Books
                                     where item.PublicationYear == "2019"
                                     select new
                                     {
                                         item.BookId,
                                         item.Condition,
                                         item.AuthorId,
                                         item.Genre,
                                         item.ISBN,
                                         item.Price,
                                         item.PublicationYear,
                                         item.PublisherId,
                                         item.Title
                                     }).FirstOrDefault().ToString();
                    //var books = context.Books.SqlQuery("Select * from Books where PublicationYear = 2019 ").FirstOrDefault<Books>();
                    //txtQuery.Text = books.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Dont contain in db");
                }
            }
        
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                txtPrice.Text = (from d in context.Books
                                 join d1 in context.SalesBook on d.BookId equals d1.BookId
                                 where d.BookId == d1.BookId
                                 select new {Price=d.Price/100*90,
                                 BookId=d.BookId}).FirstOrDefault().ToString();
            }
        }

        private void btnBestSeller_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                var items = (from item in context.OrderItems
                                 group item.Quantity by item.Books into g
                                 orderby g.Sum() descending
                                 select new
                                
                                 { g.Key.Price,
                                 g.Key.Title,
                                 g.Key.Authors.AuthorFirstName,
                                 g.Key.Publishers.PublisherName}).Take(5).FirstOrDefault().ToString();
                foreach (var item in items)
                {
                  txtQuery.Text=  items.ToString();
                }
            }
            
        }
        public List<object> GetList()
        {
            using (var context = new BookLotEntities())
            {
                var result = (from item in context.OrderItems
                              group item.Quantity by item.Books into g
                              orderby g.Sum() descending
                              select g.Key);
                return result.Cast<object>().ToList();
               
            }
            
        }

        private void btnSaveAction_Click(object sender, EventArgs e)
        {
            try
            {
                SalesBook sales = new SalesBook();
                sales.SalesBookId = Int32.Parse(txtSalesBookId.Text);
                sales.TitleAction = txtTitleAction.Text;
                sales.BookId = Int32.Parse(txt_BookId.Text);

                BookLotEntities lotEntities = new BookLotEntities();
                lotEntities.SalesBook.Add(sales);
                lotEntities.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bad Format");
            }
        }

        private void btnUpdateAction_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {

                int salesBookId = Int32.Parse(txtSalesBookId.Text);
                SalesBook sales = context.SalesBook.Find(salesBookId);
                if (sales != null)
                {
                    try
                    {
                        sales.SalesBookId = Int32.Parse(txtSalesBookId.Text);
                        sales.TitleAction = txtTitleAction.Text;
                        sales.BookId = Int32.Parse(txt_BookId.Text);

                        context.SaveChanges();

                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show("Just format is bad :)");
                    }
                }
            }
        }

        private void btnRemoveAction_Click(object sender, EventArgs e)
        {
            int salesItem = Int32.Parse(txtSalesBookId.Text);
            using (var context = new BookLotEntities())
            {
                SalesBook booksToDelete = new SalesBook() { SalesBookId = salesItem };
                context.Entry(booksToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        private void btnSalesItemDB_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {

                var source = context.SalesBook.ToList();
                cboSalesItem.DataSource = source;

                cboSalesItem.ValueMember = "SalesBookId";
                cboSalesItem.DisplayMember = "TitleAction";

                cboSalesItem.Invalidate();
                cboSalesItem.DataBindings.Clear();
                txtSalesBookId.DataBindings.Add("Text", source, "SalesBookId", true);

                txtTitleAction.DataBindings.Add("Text", source, "TitleAction", true);
                txt_BookId.DataBindings.Add("Text", source, "BookId", true);
                //txtSalesBookId.DataBindings.Clear();
                //txtTitleAction.DataBindings.Clear();
                //txt_BookId.DataBindings.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                var items = (from item in context.OrderItems
                             group item.Quantity by item.Books.Authors into g
                             orderby g.Sum() descending
                             select new

                             {
                                 g.Key.AuthorId,
                                 g.Key.AuthorFirstName,
                                 g.Key.AuthorLastName
                                
                             }).Take(5).FirstOrDefault().ToString();
                foreach (var item in items)
                {
                    txtQuery.Text = items.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                var items = (from item in context.OrderItems
                             group item.Quantity by item.Books.Authors into g
                             orderby g.Sum() descending
                             select new

                             {
                                 g.Key.AuthorId,
                                 g.Key.AuthorFirstName,
                                 g.Key.AuthorLastName

                             }).Take(5).ToList();
                foreach (var item in items)
                {

                    listView1.Items.Add(item.AuthorFirstName);
                    listView1.Items.Add(item.AuthorLastName);
                    listView1.Items.Add(item.AuthorId.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                var items = (context.Books.ToList());
                foreach(var item in items)
                {
                    listView1.Items.Add(item.AuthorId.ToString());
                    listView1.Items.Add(item.BookId.ToString());
                    listView1.Items.Add(item.Condition);
                    listView1.Items.Add(item.Genre);
                    listView1.Items.Add(item.ISBN);
                    listView1.Items.Add(item.Price.ToString());
                    listView1.Items.Add(item.PublicationYear);
                    listView1.Items.Add(item.Title);
                }
                
            }
        }


       

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {

                
                var items = (from d in context.OrderItems
                             join d1 in context.Books
                            on d.BookId equals d1.BookId

                             where d.BookId==d1.BookId

                             select new
                             {
                                 d.Books.Authors.AuthorFirstName,
                                 d1.Authors.AuthorLastName
                             }).Take(5).ToList();
                foreach (var item in items)
                {

                    listView1.Items.Add(item.AuthorFirstName);
                    listView1.Items.Add(item.AuthorLastName);
 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label23.Text = "You login as :" + ((Form)this.MdiParent).Controls["label1"].Text;
            if(((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                btnRemove.Enabled = false;
                btnRemoveAction.Enabled = false;
                btnDelete.Enabled = false;
                btnDeleteOrders.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var context = new BookLotEntities())
            {
                var items = (from d in context.Orders
                             join d1 in context.OrderItems
                            on d.OrderId equals d1.OrderId
                             join d2 in context.Books
                             on d1.BookId equals d2.BookId
                             join d3 in context.Authors
                              on d2.AuthorId equals d3.AuthorId
                             //group d1.Quantity by d3.AuthorLastName into g
                             //orderby g.Sum() descending
                             //where d.BookId == d1.BookId
                             //where d.OrderDate == DbFunctions.AddDays(d.OrderDate, +7)
                             where (d.Total==d.OrderItems.Quantity
                             ||d.OrderId==d.OrderItems.OrderId
                             || d.OrderId==d.OrderItems.Price
                             || DateTime.Now<=DbFunctions.AddDays(d.OrderDate, -30))
                             select new
                             {
                                 d.OrderId,
                                 d3.AuthorLastName,
                                 d3.AuthorFirstName
                                 
                             }).Take(5).ToList();
                foreach (var item in items)
                {

                    listView1.Items.Add(item.AuthorFirstName);
                    listView1.Items.Add(item.AuthorLastName);

                }
            }

            //using (var context = new BookLotEntities())
            //{
            //    var items = (from item in context.Orders
            //                 group item.OrderDate by item.OrderItems.Books.Authors.AuthorLastName into g
            //                 orderby g.FirstOrDefault() descending
            //                 select new

            //                 {
            //                     g.Key.,
            //                     g.Key.AuthorFirstName,
            //                     g.Key.AuthorLastName

            //                 }).Take(5).ToList();
            //    foreach (var item in items)
            //    {

            //        listView1.Items.Add(item.AuthorFirstName);
            //        listView1.Items.Add(item.AuthorLastName);
            //        listView1.Items.Add(item.AuthorId.ToString());
            //    }
            //}
        }
        }
    }




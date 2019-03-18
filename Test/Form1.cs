using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookLotDal.Models;
using BookLotDal.EF;
using BookLotDal.Repos;
using System.Data.Entity;

namespace Test
{
    public partial class Form1 : Form
    {
        BookLotEntities _conrext;
        public Form1()
        {
            InitializeComponent();
            //using (var ctx = new BookLotEntities())
            //{
            //    dataGridView1.DataSource = ctx.BookCategories.ToList();
            //}
            Database.SetInitializer(new DataInitializer());

        }
        

        protected override void OnLoad( EventArgs e)
        {
            base.OnLoad(e);
            _conrext = new BookLotEntities();
            _conrext.BookCategories.Load();
            this.repoSalesBookBindingSource.DataSource =
                _conrext.BookCategories.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            foreach(var product in _conrext.BookCategories.Local.ToList())
            {
                if(product.BookId==null)
                {
                    _conrext.BookCategories.Remove(product);
                }
            }
            this._conrext.SaveChanges();
            this.dataGridView1.Refresh();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database.SetInitializer(new DataInitializer());
           
        }
    }
}

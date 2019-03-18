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
using System.Data.Entity;

namespace BookLotTest
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BookLotEntities db = new BookLotEntities();
            //db.Customers.Load();
            //this.orderRepoBindingSource.DataSource = db.Customers.Local.ToBindingList();
            Database.SetInitializer(new DataInitializer());
           
           
        }
    }
}

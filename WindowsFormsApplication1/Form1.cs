using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            productList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDbContext _db = new AppDbContext();
            _db.products.Add(new Product { Price = 4, ProductName = "Product 1" });
            _db.SaveChanges();

            dataGridView1.DataSource = productList();
        }

        private List<Product> productList ()
        {
            AppDbContext _db = new AppDbContext();

            return _db.products.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productList();
            dataGridView1.DataSource = productList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppDbContext _db = new AppDbContext();
            _db.Categories.Add(new Category { Name= "category1", CreationDate = DateTime.Now });
            _db.SaveChanges();
            MessageBox.Show("done");
        }
    }
}

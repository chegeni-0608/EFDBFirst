using EFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDBFirst
{
    public partial class Form1 : Form
    {
        CsharpSampleDBEntities _db = new CsharpSampleDBEntities();

        int _pageItemCount = 10;
        int _currentPage = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = _db.Products.OrderBy(q => q.UnitPrice).Take(10)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice });
            dataGridView1.DataSource = result.ToList();
        }

        private void btnGet3TopExpensive_Click(object sender, EventArgs e)
        {
         var result = _db.Products.OrderByDescending(q => q.UnitPrice).Take(3)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice });
            dataGridView1.DataSource = result.ToList();
        }

        private void btnGetFourthExpensive_Click(object sender, EventArgs e)
        {
            var result =  _db.Products.OrderByDescending(q => q.UnitPrice).Skip(3).Take(1)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice });
            dataGridView1.DataSource = result.ToList(); 
        }

        private void btnTotalProduct_Click(object sender, EventArgs e)
        {
            var result = _db.Products.OrderBy(q => q.ProductName)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice });
            dataGridView1.DataSource=result.ToList();   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createpagination();
        }

        private void createpagination()
        {
            int totalCount = _db.Products.Count();
            int pagecount = Convert.ToInt32(Math.Ceiling((decimal)totalCount / _pageItemCount));

            for(int i = 1; i <= pagecount; i++)
            {
                var button = new Button(); 
                button.Text = i.ToString();
                button.Tag = i;
                button.Width = 30;
                button.Location = new Point((i * 30) + 20, 18);
                button.Click += Pagination_Click;
                gbPagination.Controls.Add(button);
            }
        }

        private void Pagination_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Tag.ToString());
        }
    }
}

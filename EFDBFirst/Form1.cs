using EFDBFirst.Data;
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

        int _pageItemCount = 5;
        int _currentPage = 1;

        public object GenericRipository { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        //10 cheap
        private void button2_Click(object sender, EventArgs e)
        {
            var result = _db.Products.OrderBy(q => q.UnitPrice).Take(10)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice });
            dataGridView1.DataSource = result.ToList();
        }
        //3top expensive product
        private void btnGet3TopExpensive_Click(object sender, EventArgs e)
        {
         var result = _db.Products.OrderByDescending(q => q.UnitPrice).Take(3)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice});
            dataGridView1.DataSource = result.ToList();
        }
         //forth expensive product
        private void btnGetFourthExpensive_Click(object sender, EventArgs e)
        {
            var result =  _db.Products.OrderByDescending(q => q.UnitPrice).Skip(3).Take(1)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice });
            dataGridView1.DataSource = result.ToList(); 
        }
         //total product
        private void btnTotalProduct_Click(object sender, EventArgs e)
        {
            var result = _db.Products.OrderBy(q => q.ProductName)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice });
            dataGridView1.DataSource=result.ToList();   

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         createpagination();
        }

        //pagination
        private void createpagination()
        {
            int totalCount = _db.Products.Count();
            int pageCount = Convert.ToInt32(Math.Ceiling((decimal)totalCount / _pageItemCount));

            for(int i = 1; i <= pageCount; i++)
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
            var page = Convert.ToInt32(((Button)sender).Tag);
            FillGridView(page);
        }
        private void FillGridView(int page = 1)
        {
            var result = _db.Products.OrderBy(q => q.ProductId).Skip((page - 1) * _pageItemCount).Take(_pageItemCount)
                .Select(q => new { q.ProductId, q.ProductName, q.Category.CategoryName, q.UnitPrice });
            dataGridView1.DataSource = result.ToList();


        }

        private void btnInsertWithGenericRepository_Click(object sender, EventArgs e)
        {
            var item = new Product
            {
                CategoryId = 1,
                ProductName = "Test With Ripo",
                UnitPrice = 100
            };

            var repository = new GenericRepository<Product>();
            repository.Insert(item);
        }

        private void btnGetTop10_Click(object sender, EventArgs e)
        {
            var repository = new GenericRepository<Product>();
            var result = repository.GetAsQueryable(
                q => q.CategoryId != 1, //where
                q => q.OrderByDescending(p => p.UnitPrice), //order
                pageItemCount: 12, //take
                currentPage:2 //skip(page 2)
                ).Select(q => new { q.CategoryId, q.ProductName, q.UnitPrice });

            dataGridView1.DataSource=result.ToList();
        }

        private void btnEployeeListBirthDate1964To1999_Click(object sender, EventArgs e)
        {
            var repository = new GenericRepository<Employee>();
            var result = repository.GetAsQueryable(
                  q => q.BirthDate.Value.Year >= 1964 && q.BirthDate.Value.Year <= 1999,
                  q.orderbyDecsending(p => p.BirthDate))
                .Select(q => new { q.FatherName, q.LastName, q.BirthDate, q.CityOfBirth });

            dataGridView1.DataSource = result.ToList();
                
        }
    }
}

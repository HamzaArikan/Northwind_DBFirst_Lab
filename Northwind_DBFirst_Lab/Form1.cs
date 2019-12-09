using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind_DBFirst_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        private void btnToList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice >= 30 && x.UnitPrice <= 60).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice >= 30 && x.UnitPrice <= 60).OrderByDescending(x => x.UnitPrice).Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock
            }).ToList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.Find(7);
            MessageBox.Show($"Category Name: {category.CategoryName}\nDescription: {category.Description}");
        }

        private void btnFirtst_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = db.Categories.First(x => x.CategoryID > 5);
                MessageBox.Show(category.CategoryName);
            }
            catch (Exception)
            {
                MessageBox.Show("Category not found..!");
            }
        }

        private void BtnFirstOrDefault_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.CategoryID > 4);

            if (category == null)
            {
                MessageBox.Show("Category not found..!");
            }
            else
            {
                MessageBox.Show(category.CategoryName);
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock >= 20 && x.UnitsInStock <= 40).OrderByDescending(x => x.UnitPrice).Take(10).Select(x => new {
                x.Category.CategoryName,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock
            }).ToList();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).Skip(5).Take(5).ToList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.Contains("ab")).ToList();
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.StartsWith("a")).ToList();
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.EndsWith("de")).ToList();
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            bool result = db.Categories.Any(x => x.CategoryName.StartsWith("Be"));
            MessageBox.Show(result.ToString());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.Select(x => new
            {
                x.CompanyName,
                x.ContactName,
                x.Phone,
                x.Address
            }).ToList();
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName).Select(y => new
            {
                CategoryName = y.Key,
                TotalStock = y.Sum(x => x.UnitsInStock)
            }).ToList();
        }

        private void btnEmployeeList1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.OrderByDescending(x => SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)).Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.Title,
                Age = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)
            }).ToList();
        }

        private void btnEmployeeList2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Where(x => SqlFunctions.DatePart("Year", x.BirthDate) >= 1950 && SqlFunctions.DatePart("Year", x.BirthDate) <= 1961).Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.Title,
                x.BirthDate
            }).ToList();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Select(x => new
            {
                x.Customer.CompanyName,
                Employee = x.Employee.FirstName + " " + x.Employee.LastName,
                OrderID = x.OrderID,
                OrderDate = x.OrderDate,
                Shipper = x.Shipper.CompanyName
            }).ToList();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice >= 40).OrderByDescending(x => x.UnitPrice).Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitsInStock,
                x.UnitPrice
            }).ToList();
        }
    }
}

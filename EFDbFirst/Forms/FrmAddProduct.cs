using EFDbFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDbFirst.Crud.Forms;
public partial class FrmAddProduct : Form
{
    public FrmAddProduct()
    {
        InitializeComponent();
    }

    private void FrmAddProduct_Load(object sender, EventArgs e)
    {
        NorthwindContext db = new NorthwindContext();
        List<Category> categories = db.Categories.ToList();
        cmbCategory.DataSource = categories;
        cmbCategory.DisplayMember = "CategoryName";
        cmbCategory.ValueMember = "CategoryId";

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        NorthwindContext db = new NorthwindContext();
        Product product = new Product();
        product.ProductName = txtName.Text;
        product.UnitPrice = Convert.ToDecimal(txtPrice.Text);
        product.UnitsInStock = Convert.ToInt16(txtStock.Text);
        product.CategoryId = (int)cmbCategory.SelectedValue;

        db.Products.Add(product);
        db.SaveChanges();
        MessageBox.Show("Product Added Successfully");

    }
}

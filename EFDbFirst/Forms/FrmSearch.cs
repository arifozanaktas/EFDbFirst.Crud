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

namespace EFDbFirst.Forms;
public partial class FrmSearch : Form
{
    public FrmSearch()
    {
        InitializeComponent();
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        ListRefresh();
    }

    private void ListRefresh()
    {
        decimal minPrice = Convert.ToDecimal(txtMin.Text);
        decimal maxPrice = Convert.ToDecimal(txtMax.Text);
        NorthwindContext db = new NorthwindContext();
        List<Product> product = db.Products.Where(x => x.UnitPrice >= minPrice && x.UnitPrice <= maxPrice).ToList();

        dtGridView1.DataSource = product;
    }

    private void dtGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var productId = Convert.ToInt32(dtGridView1.CurrentRow.Cells[0].Value);
        NorthwindContext db = new NorthwindContext();
        Product product = db.Products.FirstOrDefault(x => x.ProductId == productId);

        txtName.Text = product.ProductName;
        txtUnitPrice.Text = product.UnitPrice.ToString();
        txtStock.Text = product.UnitsInStock.ToString();

       
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        var productId = Convert.ToInt32(dtGridView1.CurrentRow.Cells[0].Value);
        NorthwindContext db = new NorthwindContext();
        Product product = db.Products.FirstOrDefault(x => x.ProductId == productId);
        var stock = Convert.ToInt16(txtStock.Text);

        if (stock >= 100 || stock <= 0)
        {
            MessageBox.Show("0 ile 100 arasında bir sayı giriniz.");
            return;
        }

        product.ProductName = txtName.Text;
        product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
        product.UnitsInStock = Convert.ToInt16(txtStock.Text);


        db.SaveChanges();
        ListRefresh();

    }
}

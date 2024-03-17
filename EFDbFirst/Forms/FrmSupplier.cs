using EFDbFirst.Crud.Services;
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
public partial class FrmSupplier : Form
{
    public FrmSupplier()
    {
        InitializeComponent();
    }

    private void FrmSupplier_Load(object sender, EventArgs e)
    {
        SupplierService supplierService = new SupplierService();
        dataGridView1.DataSource = supplierService.GetAll();

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int selectedSupplierId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SupplierService supplierService = new();
            supplierService.DeleteItem(selectedSupplierId);
            dataGridView1.DataSource = supplierService.GetAll();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Supplier Silinemedi!");
        }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int selectedSupplierId = (int)dataGridView1.CurrentRow.Cells[0].Value;
        NorthwindContext db = new NorthwindContext();
        var companyName = db.Suppliers.FirstOrDefault(x => x.SupplierId == selectedSupplierId);
        txtCompany.Text = companyName.CompanyName;
        var contactName = db.Suppliers.FirstOrDefault(x => x.SupplierId == selectedSupplierId);
        txtContact.Text = contactName.ContactName;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        SupplierService supplierService = new SupplierService();
        int selectedSupplierId = (int)dataGridView1.CurrentRow.Cells[0].Value;
        var newCompanyName = txtCompany.Text;
        var newContactName = txtContact.Text;
        supplierService.UpdateItem(selectedSupplierId, newCompanyName, newContactName);
        dataGridView1.DataSource = supplierService.GetAll();

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        SupplierService supplierService = new();
        var companyName = txtCompany.Text;
        var contactName = txtContact.Text;
        supplierService.AddItem(companyName, contactName);
        dataGridView1.DataSource = supplierService.GetAll();
    }
}

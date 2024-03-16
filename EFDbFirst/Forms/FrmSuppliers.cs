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

namespace EFDbFirst.Forms
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
        }

        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }


        void LoadSuppliers()
        {
            NorthwindContext db = new NorthwindContext();
            List<Supplier> suppliers = db.Suppliers.ToList();
            dtGridSuppliers.DataSource = suppliers;
        }

        private void btnOrderByCompanyName_Click(object sender, EventArgs e)
        {
            NorthwindContext db = new NorthwindContext();
            List<Supplier> suppliers = db.Suppliers.OrderBy(x => x.CompanyName).ToList();
            dtGridSuppliers.DataSource = suppliers;
        }

        private void tctCompanyNameSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tctCompanyNameSearch.Text;

            NorthwindContext db = new NorthwindContext();
            List<Supplier> suppliers = db.Suppliers.Where(x => x.CompanyName.StartsWith(search)).ToList();
            dtGridSuppliers.DataSource = suppliers;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            int take = Convert.ToInt32(txtTake.Text);

            NorthwindContext db = new NorthwindContext();
            List<Supplier> suppliers = db.Suppliers.Take(take).ToList();
            dtGridSuppliers.DataSource = suppliers;


        }
    }
}

// where, take, orderBy, orderByDesc

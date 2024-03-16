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
    public partial class FrmOneSupplier : Form
    {
        public FrmOneSupplier()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            NorthwindContext db = new NorthwindContext();
            Supplier supplier = db.Suppliers.FirstOrDefault(x => x.SupplierId == id);
           // Supplier supplier2 = db.Suppliers.Find(id);


            if (supplier == null)
            {
                MessageBox.Show("Supplier not found");
                return;
            }

            lblCompanyName.Text = supplier.CompanyName;
            lblContactName.Text = supplier.ContactName;
            lblContactTitle.Text = supplier.ContactTitle;
        }
    }
}

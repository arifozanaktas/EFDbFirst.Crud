using EFDbFirst.Crud.Forms;
using EFDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirst.Crud.Services;
public class SupplierService
{
    public List<Supplier> GetAll()
    {
        NorthwindContext db = new NorthwindContext();
        List<Supplier> suppliers = db.Suppliers.OrderBy(x=> x.SupplierId).ToList(); 
        return suppliers;
    }

    public void DeleteItem(int id)
    {
        NorthwindContext db = new NorthwindContext();
        var item = db.Suppliers.FirstOrDefault(x => x.SupplierId == id);
        db.Suppliers.Remove(item);
        db.SaveChanges();
    }

    public void UpdateItem(int id, string companyName, string contactName)
    {
        try
        {

        NorthwindContext db = new NorthwindContext();
        var updateItem = db.Suppliers.FirstOrDefault(x=>x.SupplierId == id);
        
        updateItem.CompanyName = companyName;
        updateItem.ContactName = contactName;

        db.SaveChanges();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Güncelleme yapılamadı.");
        }
    }
    public void AddItem(string companyName, string contactName)
    {
        NorthwindContext db = new NorthwindContext();
        Supplier supplier = new Supplier();
        supplier.CompanyName = companyName;
        supplier.ContactName = contactName;
        db.Suppliers.Add(supplier);
        db.SaveChanges();


    }
}

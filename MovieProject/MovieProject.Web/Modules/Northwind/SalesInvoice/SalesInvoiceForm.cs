using MovieProject.Modules;
using Serenity.ComponentModel;
using System;

namespace MovieProject.Northwind.Forms;

[FormScript("Northwind.SalesInvoice")]
[BasedOnRow(typeof(SalesInvoiceRow), CheckNames = true)]
public class SalesInvoiceForm
{
    public DateTime Date { get; set; }
    public string Notes { get; set; }
    [DisplayName("List"), MovieProject.Northwind.SalesInvoiceItemsEditor, IgnoreName]
   public List<SalesInvoiceItemsRow> Rows { get;  set; }
}
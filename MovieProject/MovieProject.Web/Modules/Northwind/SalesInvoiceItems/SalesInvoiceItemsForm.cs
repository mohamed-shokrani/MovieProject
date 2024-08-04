using Serenity.ComponentModel;
using System;

namespace MovieProject.Northwind.Forms;

[FormScript("Northwind.SalesInvoiceItems")]
[BasedOnRow(typeof(SalesInvoiceItemsRow), CheckNames = true)]
public class SalesInvoiceItemsForm
{
    public DateTime Date { get; set; }
    public string Notes { get; set; }
    public int SalesInvoiceId { get; set; }
}
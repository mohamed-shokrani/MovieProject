using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MovieProject.Northwind.Columns;

[ColumnsScript("Northwind.SalesInvoice")]
[BasedOnRow(typeof(SalesInvoiceRow), CheckNames = true)]
public class SalesInvoiceColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int SaleInvoiceId { get; set; }
    public DateTime Date { get; set; }
    [EditLink]
    public string Notes { get; set; }
}
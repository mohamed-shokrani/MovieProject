using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MovieProject.Northwind.Columns;

[ColumnsScript("Northwind.SalesInvoiceItems")]
[BasedOnRow(typeof(SalesInvoiceItemsRow), CheckNames = true)]
public class SalesInvoiceItemsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [EditLink]
    public string Notes { get; set; }
    public string SalesInvoiceNotes { get; set; }
}
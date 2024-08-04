using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieProject.Northwind.Columns;

[ColumnsScript("Northwind.OrderSubtotals")]
[BasedOnRow(typeof(OrderSubtotalsRow), CheckNames = true)]
public class OrderSubtotalsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int OrderId { get; set; }
    public decimal Subtotal { get; set; }
}
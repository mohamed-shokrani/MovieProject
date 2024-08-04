using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieProject.Northwind.Columns;

[ColumnsScript("Northwind.OrderDetailsExtended")]
[BasedOnRow(typeof(OrderDetailsExtendedRow), CheckNames = true)]
public class OrderDetailsExtendedColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    [EditLink]
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
    public decimal ExtendedPrice { get; set; }
}
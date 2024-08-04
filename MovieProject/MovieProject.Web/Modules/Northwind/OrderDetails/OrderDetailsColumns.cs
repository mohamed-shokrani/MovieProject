using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieProject.Northwind.Columns;

[ColumnsScript("Northwind.OrderDetails")]
[BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
public class OrderDetailsColumns
{
    public string OrderCustomerId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int DetailId { get; set; }
}
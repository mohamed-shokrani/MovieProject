using Serenity.ComponentModel;

namespace MovieProject.Northwind.Forms;

[FormScript("Northwind.OrderDetails")]
[BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
public class OrderDetailsForm
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
}
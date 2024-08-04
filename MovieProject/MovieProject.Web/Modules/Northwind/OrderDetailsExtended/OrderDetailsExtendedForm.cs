using Serenity.ComponentModel;

namespace MovieProject.Northwind.Forms;

[FormScript("Northwind.OrderDetailsExtended")]
[BasedOnRow(typeof(OrderDetailsExtendedRow), CheckNames = true)]
public class OrderDetailsExtendedForm
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
    public decimal ExtendedPrice { get; set; }
}
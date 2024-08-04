using Serenity.ComponentModel;

namespace MovieProject.Northwind.Forms;

[FormScript("Northwind.OrderSubtotals")]
[BasedOnRow(typeof(OrderSubtotalsRow), CheckNames = true)]
public class OrderSubtotalsForm
{
    public decimal Subtotal { get; set; }
}
using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieProject.Northwind.Pages;

[PageAuthorize(typeof(OrderSubtotalsRow))]
public class OrderSubtotalsPage : Controller
{
    [Route("Northwind/OrderSubtotals")]
    public ActionResult Index()
    {
        return this.GridPage("@/Northwind/OrderSubtotals/OrderSubtotalsPage",
            OrderSubtotalsRow.Fields.PageTitle());
    }
}
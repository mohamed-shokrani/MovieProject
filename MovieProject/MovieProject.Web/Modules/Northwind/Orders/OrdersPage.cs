using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieProject.Northwind.Pages;

[PageAuthorize(typeof(OrdersRow))]
public class OrdersPage : Controller
{
    [Route("Northwind/Orders")]
    public ActionResult Index()
    {
        return this.GridPage("@/Northwind/Orders/OrdersPage",
            OrdersRow.Fields.PageTitle());
    }
}
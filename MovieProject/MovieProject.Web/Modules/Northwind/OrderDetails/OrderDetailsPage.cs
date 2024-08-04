using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieProject.Northwind.Pages;

[PageAuthorize(typeof(OrderDetailsRow))]
public class OrderDetailsPage : Controller
{
    [Route("Northwind/OrderDetails")]
    public ActionResult Index()
    {
        return this.GridPage("@/Northwind/OrderDetails/OrderDetailsPage",
            OrderDetailsRow.Fields.PageTitle());
    }
}
using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieProject.Northwind.Pages;

[PageAuthorize(typeof(OrdersQryRow))]
public class OrdersQryPage : Controller
{
    [Route("Northwind/OrdersQry")]
    public ActionResult Index()
    {
        return this.GridPage("@/Northwind/OrdersQry/OrdersQryPage",
            OrdersQryRow.Fields.PageTitle());
    }
}
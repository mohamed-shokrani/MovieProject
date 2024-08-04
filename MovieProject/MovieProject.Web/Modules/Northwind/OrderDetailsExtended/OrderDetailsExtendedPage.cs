using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieProject.Northwind.Pages;

[PageAuthorize(typeof(OrderDetailsExtendedRow))]
public class OrderDetailsExtendedPage : Controller
{
    [Route("Northwind/OrderDetailsExtended")]
    public ActionResult Index()
    {
        return this.GridPage("@/Northwind/OrderDetailsExtended/OrderDetailsExtendedPage",
            OrderDetailsExtendedRow.Fields.PageTitle());
    }
}
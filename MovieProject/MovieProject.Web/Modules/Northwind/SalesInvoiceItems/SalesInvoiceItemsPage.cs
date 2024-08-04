using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieProject.Northwind.Pages;

[PageAuthorize(typeof(SalesInvoiceItemsRow))]
public class SalesInvoiceItemsPage : Controller
{
    [Route("Northwind/SalesInvoiceItems")]
    public ActionResult Index()
    {
        return this.GridPage("@/Northwind/SalesInvoiceItems/SalesInvoiceItemsPage",
            SalesInvoiceItemsRow.Fields.PageTitle());
    }
}
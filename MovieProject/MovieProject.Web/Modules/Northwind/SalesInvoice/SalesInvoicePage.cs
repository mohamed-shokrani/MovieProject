using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieProject.Northwind.Pages;

[PageAuthorize(typeof(SalesInvoiceRow))]
public class SalesInvoicePage : Controller
{
    [Route("Northwind/SalesInvoice")]
    public ActionResult Index()
    {
        return this.GridPage("@/Northwind/SalesInvoice/SalesInvoicePage",
            SalesInvoiceRow.Fields.PageTitle());
    }
}
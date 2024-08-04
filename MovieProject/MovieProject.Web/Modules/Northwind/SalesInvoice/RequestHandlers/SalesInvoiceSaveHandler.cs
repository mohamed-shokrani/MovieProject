using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.Northwind.SalesInvoiceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.Northwind.SalesInvoiceRow;

namespace MovieProject.Northwind;

public interface ISalesInvoiceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SalesInvoiceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesInvoiceSaveHandler
{
    public SalesInvoiceSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
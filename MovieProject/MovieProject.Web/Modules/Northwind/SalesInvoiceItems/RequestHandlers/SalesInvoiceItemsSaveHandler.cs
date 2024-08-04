using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.Northwind.SalesInvoiceItemsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.Northwind.SalesInvoiceItemsRow;

namespace MovieProject.Northwind;

public interface ISalesInvoiceItemsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SalesInvoiceItemsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesInvoiceItemsSaveHandler
{
    public SalesInvoiceItemsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
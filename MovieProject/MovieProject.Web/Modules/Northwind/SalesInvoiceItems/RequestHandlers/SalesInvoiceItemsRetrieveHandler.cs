using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Northwind.SalesInvoiceItemsRow>;
using MyRow = MovieProject.Northwind.SalesInvoiceItemsRow;

namespace MovieProject.Northwind;

public interface ISalesInvoiceItemsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SalesInvoiceItemsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesInvoiceItemsRetrieveHandler
{
    public SalesInvoiceItemsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
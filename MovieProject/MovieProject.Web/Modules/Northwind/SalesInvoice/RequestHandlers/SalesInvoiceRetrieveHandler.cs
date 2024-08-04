using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Northwind.SalesInvoiceRow>;
using MyRow = MovieProject.Northwind.SalesInvoiceRow;

namespace MovieProject.Northwind;

public interface ISalesInvoiceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SalesInvoiceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesInvoiceRetrieveHandler
{
    public SalesInvoiceRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
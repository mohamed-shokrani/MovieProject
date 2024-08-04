using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Northwind.SalesInvoiceRow>;
using MyRow = MovieProject.Northwind.SalesInvoiceRow;

namespace MovieProject.Northwind;

public interface ISalesInvoiceListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SalesInvoiceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISalesInvoiceListHandler
{
    public SalesInvoiceListHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Northwind.SalesInvoiceItemsRow>;
using MyRow = MovieProject.Northwind.SalesInvoiceItemsRow;

namespace MovieProject.Northwind;

public interface ISalesInvoiceItemsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SalesInvoiceItemsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISalesInvoiceItemsListHandler
{
    public SalesInvoiceItemsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieProject.Northwind.SalesInvoiceItemsRow;

namespace MovieProject.Northwind;

public interface ISalesInvoiceItemsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SalesInvoiceItemsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISalesInvoiceItemsDeleteHandler
{
    public SalesInvoiceItemsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
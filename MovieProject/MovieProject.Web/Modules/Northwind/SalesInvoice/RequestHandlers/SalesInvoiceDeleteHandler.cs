using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieProject.Northwind.SalesInvoiceRow;

namespace MovieProject.Northwind;

public interface ISalesInvoiceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SalesInvoiceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISalesInvoiceDeleteHandler
{
    public SalesInvoiceDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
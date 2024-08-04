using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieProject.Northwind.OrderDetailsExtendedRow;

namespace MovieProject.Northwind;

public interface IOrderDetailsExtendedDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsExtendedDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsExtendedDeleteHandler
{
    public OrderDetailsExtendedDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
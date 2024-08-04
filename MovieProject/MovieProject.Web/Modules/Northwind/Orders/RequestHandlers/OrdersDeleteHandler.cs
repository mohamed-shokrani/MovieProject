using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieProject.Northwind.OrdersRow;

namespace MovieProject.Northwind;

public interface IOrdersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class OrdersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersDeleteHandler
{
    public OrdersDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieProject.Northwind.OrdersQryRow;

namespace MovieProject.Northwind;

public interface IOrdersQryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class OrdersQryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersQryDeleteHandler
{
    public OrdersQryDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
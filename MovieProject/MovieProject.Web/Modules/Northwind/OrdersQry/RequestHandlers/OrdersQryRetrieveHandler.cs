using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Northwind.OrdersQryRow>;
using MyRow = MovieProject.Northwind.OrdersQryRow;

namespace MovieProject.Northwind;

public interface IOrdersQryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class OrdersQryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersQryRetrieveHandler
{
    public OrdersQryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
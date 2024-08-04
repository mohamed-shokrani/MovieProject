using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Northwind.OrdersRow>;
using MyRow = MovieProject.Northwind.OrdersRow;

namespace MovieProject.Northwind;

public interface IOrdersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class OrdersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersRetrieveHandler
{
    public OrdersRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
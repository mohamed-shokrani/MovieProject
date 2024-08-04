using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Northwind.OrdersRow>;
using MyRow = MovieProject.Northwind.OrdersRow;

namespace MovieProject.Northwind;

public interface IOrdersListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class OrdersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersListHandler
{
    public OrdersListHandler(IRequestContext context)
            : base(context)
    {
    }
}
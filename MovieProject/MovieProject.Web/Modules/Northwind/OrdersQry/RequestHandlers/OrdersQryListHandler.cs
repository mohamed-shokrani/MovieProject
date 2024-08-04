using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Northwind.OrdersQryRow>;
using MyRow = MovieProject.Northwind.OrdersQryRow;

namespace MovieProject.Northwind;

public interface IOrdersQryListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class OrdersQryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersQryListHandler
{
    public OrdersQryListHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Northwind.OrderDetailsRow>;
using MyRow = MovieProject.Northwind.OrderDetailsRow;

namespace MovieProject.Northwind;

public interface IOrderDetailsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsListHandler
{
    public OrderDetailsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
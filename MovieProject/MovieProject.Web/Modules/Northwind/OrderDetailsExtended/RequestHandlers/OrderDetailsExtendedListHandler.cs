using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Northwind.OrderDetailsExtendedRow>;
using MyRow = MovieProject.Northwind.OrderDetailsExtendedRow;

namespace MovieProject.Northwind;

public interface IOrderDetailsExtendedListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsExtendedListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsExtendedListHandler
{
    public OrderDetailsExtendedListHandler(IRequestContext context)
            : base(context)
    {
    }
}
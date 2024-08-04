using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Northwind.OrderSubtotalsRow>;
using MyRow = MovieProject.Northwind.OrderSubtotalsRow;

namespace MovieProject.Northwind;

public interface IOrderSubtotalsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class OrderSubtotalsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrderSubtotalsListHandler
{
    public OrderSubtotalsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
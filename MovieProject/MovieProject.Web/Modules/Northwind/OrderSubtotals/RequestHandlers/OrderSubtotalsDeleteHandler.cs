using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieProject.Northwind.OrderSubtotalsRow;

namespace MovieProject.Northwind;

public interface IOrderSubtotalsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class OrderSubtotalsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrderSubtotalsDeleteHandler
{
    public OrderSubtotalsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
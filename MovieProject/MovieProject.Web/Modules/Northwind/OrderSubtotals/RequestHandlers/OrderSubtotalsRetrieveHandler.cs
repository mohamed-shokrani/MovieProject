using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Northwind.OrderSubtotalsRow>;
using MyRow = MovieProject.Northwind.OrderSubtotalsRow;

namespace MovieProject.Northwind;

public interface IOrderSubtotalsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderSubtotalsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderSubtotalsRetrieveHandler
{
    public OrderSubtotalsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
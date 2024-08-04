using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Northwind.OrderDetailsExtendedRow>;
using MyRow = MovieProject.Northwind.OrderDetailsExtendedRow;

namespace MovieProject.Northwind;

public interface IOrderDetailsExtendedRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsExtendedRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsExtendedRetrieveHandler
{
    public OrderDetailsExtendedRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
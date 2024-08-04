using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Northwind.OrderDetailsRow>;
using MyRow = MovieProject.Northwind.OrderDetailsRow;

namespace MovieProject.Northwind;

public interface IOrderDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsRetrieveHandler
{
    public OrderDetailsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
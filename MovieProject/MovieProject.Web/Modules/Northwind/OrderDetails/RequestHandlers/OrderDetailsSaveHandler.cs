using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.Northwind.OrderDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.Northwind.OrderDetailsRow;

namespace MovieProject.Northwind;

public interface IOrderDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsSaveHandler
{
    public OrderDetailsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.Northwind.OrdersQryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.Northwind.OrdersQryRow;

namespace MovieProject.Northwind;

public interface IOrdersQrySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class OrdersQrySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersQrySaveHandler
{
    public OrdersQrySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
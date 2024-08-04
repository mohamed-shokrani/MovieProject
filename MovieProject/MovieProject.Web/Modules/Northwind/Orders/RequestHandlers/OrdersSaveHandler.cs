using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.Northwind.OrdersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.Northwind.OrdersRow;

namespace MovieProject.Northwind;

public interface IOrdersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class OrdersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrdersSaveHandler
{
    public OrdersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.Northwind.OrderDetailsExtendedRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.Northwind.OrderDetailsExtendedRow;

namespace MovieProject.Northwind;

public interface IOrderDetailsExtendedSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsExtendedSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsExtendedSaveHandler
{
    public OrderDetailsExtendedSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
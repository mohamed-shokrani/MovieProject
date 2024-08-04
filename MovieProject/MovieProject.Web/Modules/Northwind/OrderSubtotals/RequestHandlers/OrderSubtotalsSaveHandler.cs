using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.Northwind.OrderSubtotalsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.Northwind.OrderSubtotalsRow;

namespace MovieProject.Northwind;

public interface IOrderSubtotalsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderSubtotalsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderSubtotalsSaveHandler
{
    public OrderSubtotalsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
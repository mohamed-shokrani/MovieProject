using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieProject.Northwind.OrderDetailsRow;

namespace MovieProject.Northwind;

public interface IOrderDetailsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsDeleteHandler
{
    public OrderDetailsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
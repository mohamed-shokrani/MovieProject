using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Administration.RoleRow>;
using MyRow = MovieProject.Administration.RoleRow;


namespace MovieProject.Administration;
public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    public RoleRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}
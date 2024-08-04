using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Administration.RoleRow>;
using MyRow = MovieProject.Administration.RoleRow;


namespace MovieProject.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}
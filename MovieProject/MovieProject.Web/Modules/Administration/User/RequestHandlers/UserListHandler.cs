using MyRequest = MovieProject.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Administration.UserRow>;
using MyRow = MovieProject.Administration.UserRow;

namespace MovieProject.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.MovieDB.PersonRow>;
using MyRow = MovieProject.MovieDB.PersonRow;

namespace MovieProject.MovieDB;

public interface IPersonListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PersonListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPersonListHandler
{
    public PersonListHandler(IRequestContext context)
            : base(context)
    {
    }
}
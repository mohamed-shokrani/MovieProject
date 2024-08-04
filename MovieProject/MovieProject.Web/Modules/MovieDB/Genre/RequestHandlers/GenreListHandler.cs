using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.MovieDB.GenreRow>;
using MyRow = MovieProject.MovieDB.GenreRow;

namespace MovieProject.MovieDB;

public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
{
    public GenreListHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.MovieDB.MovieRow>;
using MyRow = MovieProject.MovieDB.MovieRow;

namespace MovieProject.MovieDB;

public interface IMovieListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
{
    public MovieListHandler(IRequestContext context)
            : base(context)
    {
    }
}
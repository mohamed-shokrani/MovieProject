using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.MovieDB.MovieGenresRow>;
using MyRow = MovieProject.MovieDB.MovieGenresRow;

namespace MovieProject.MovieDB;

public interface IMovieGenresListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MovieGenresListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresListHandler
{
    public MovieGenresListHandler(IRequestContext context)
            : base(context)
    {
    }
}
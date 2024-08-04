using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.MovieDB.MovieGenresRow>;
using MyRow = MovieProject.MovieDB.MovieGenresRow;

namespace MovieProject.MovieDB;

public interface IMovieGenresRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieGenresRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresRetrieveHandler
{
    public MovieGenresRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.MovieDB.MovieRow>;
using MyRow = MovieProject.MovieDB.MovieRow;

namespace MovieProject.MovieDB;

public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
{
    public MovieRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
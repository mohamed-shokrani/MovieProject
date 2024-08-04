using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.MovieDB.MovieCastRow>;
using MyRow = MovieProject.MovieDB.MovieCastRow;

namespace MovieProject.MovieDB;

public interface IMovieCastRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieCastRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastRetrieveHandler
{
    public MovieCastRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
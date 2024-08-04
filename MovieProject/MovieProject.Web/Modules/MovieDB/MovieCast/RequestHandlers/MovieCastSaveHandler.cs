using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.MovieDB.MovieCastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.MovieDB.MovieCastRow;

namespace MovieProject.MovieDB;

public interface IMovieCastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieCastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastSaveHandler
{
    public MovieCastSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
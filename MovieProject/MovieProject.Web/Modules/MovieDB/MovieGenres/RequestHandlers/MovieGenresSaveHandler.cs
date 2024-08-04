using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.MovieDB.MovieGenresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.MovieDB.MovieGenresRow;

namespace MovieProject.MovieDB;

public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieGenresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresSaveHandler
{
    public MovieGenresSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
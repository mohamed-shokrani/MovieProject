using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.MovieDB.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.MovieDB.MovieRow;

namespace MovieProject.MovieDB;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
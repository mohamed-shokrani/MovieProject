using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.MovieDB.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.MovieDB.GenreRow;

namespace MovieProject.MovieDB;

public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
{
    public GenreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
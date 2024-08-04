using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.MovieDB.GenreRow>;
using MyRow = MovieProject.MovieDB.GenreRow;

namespace MovieProject.MovieDB;

public interface IGenreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class GenreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreRetrieveHandler
{
    public GenreRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
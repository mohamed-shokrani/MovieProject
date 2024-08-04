using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.MovieDB.PersonRow>;
using MyRow = MovieProject.MovieDB.PersonRow;

namespace MovieProject.MovieDB;

public interface IPersonRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PersonRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonRetrieveHandler
{
    public PersonRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
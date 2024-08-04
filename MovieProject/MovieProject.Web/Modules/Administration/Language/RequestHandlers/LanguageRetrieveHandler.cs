using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieProject.Administration.LanguageRow>;
using MyRow = MovieProject.Administration.LanguageRow;


namespace MovieProject.Administration;
public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
{
    public LanguageRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}
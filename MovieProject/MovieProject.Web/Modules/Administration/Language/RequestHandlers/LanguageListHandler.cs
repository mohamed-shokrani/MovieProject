using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.Administration.LanguageRow>;
using MyRow = MovieProject.Administration.LanguageRow;


namespace MovieProject.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}
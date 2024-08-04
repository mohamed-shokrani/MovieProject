using MyRequest = Serenity.Services.SaveRequest<MovieProject.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.Administration.LanguageRow;


namespace MovieProject.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}
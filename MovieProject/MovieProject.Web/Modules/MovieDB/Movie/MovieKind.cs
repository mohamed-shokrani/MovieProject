namespace MovieProject.Modules.MovieDB.Movie;
[EnumKey("MovieDB.MovieKind")]
public enum MovieKind
{
    [Description("Film")]
    Film=1,
    [Description("TV Series")]
    TvSeries,
    [Description("Mini Series")]
    MiniSeries = 3

}

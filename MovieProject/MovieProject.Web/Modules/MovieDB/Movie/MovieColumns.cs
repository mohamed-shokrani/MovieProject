using MovieProject.Modules.MovieDB.Movie;
using MovieTutorial;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieProject.MovieDB.Columns;

[ColumnsScript("MovieDB.Movie")]
[BasedOnRow(typeof(MovieRow), CheckNames = true)]
public class MovieColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    
    public int MovieId { get; set; }
    [EditLink]
    public string Title { get; set; }
    [Width(300)]

    public string Image { get; set; }
    public string Descrition { get; set; }
    public MovieKind Kind { get; set; }
    //public string GenreName { get; set; }
    [Width(200), GenreListFormatter]
    public List<int> GenreList { get; set; }
}

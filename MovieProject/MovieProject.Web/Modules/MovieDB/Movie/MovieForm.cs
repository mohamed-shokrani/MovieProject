using MovieProject.Modules.MovieDB.Movie;
using Serenity.ComponentModel;

namespace MovieProject.MovieDB.Forms;

[FormScript("MovieDB.Movie")]
[BasedOnRow(typeof(MovieRow), CheckNames = true)]
public class MovieForm
{
    public string Title { get; set; }
    public string Image { get; set; }
    public string Descrition { get; set; }
    public MovieKind Kind { get; set; }
    //public int GenreId { get; set; }
    public List<int> GenreList { get; set; }
    [DisplayName("Cast"), MovieCastEditor, IgnoreName]
    public List<MovieCastRow> CastList { get; set; }


}
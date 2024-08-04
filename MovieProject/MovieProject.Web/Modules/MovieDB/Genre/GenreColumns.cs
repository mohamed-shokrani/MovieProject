using Serenity.ComponentModel;
using System.ComponentModel;

namespace MovieProject.MovieDB.Columns;

[ColumnsScript("MovieDB.Genre")]
[BasedOnRow(typeof(GenreRow), CheckNames = true)]
public class GenreColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int GenreId { get; set; }
    [EditLink]
    public string Name { get; set; }
}
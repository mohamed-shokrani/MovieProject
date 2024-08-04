using MovieProject.Modules.MovieDB.Movie;

namespace MovieProject.MovieDB;

[ConnectionKey("Default"), Module("MovieDB"), TableName("Movie")]
[DisplayName("Movie"), InstanceName("Movieeeee")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
{
    const string jGenre = nameof(jGenre);


    //[DisplayName("Genre"), ForeignKey(typeof(GenreRow)), LeftJoin(jGenre)]
    //[LookupEditor(typeof(GenreRow),InplaceAdd =true)]
    //public int? GenreId { get => fields.GenreId[this]; set => fields.GenreId[this] = value; }
    //[DisplayName("Genre"),Expression($"{jGenre}.Name"),QuickSearch]
    //public string GenreName { get => fields.GenreName[this]; set => fields.GenreName[this] = value; }

    // many to many relationship
    
    [DisplayName("Genre"),LookupEditor(typeof(GenreRow),Multiple =true),NotMapped]
    [LinkingSetRelation(typeof(MovieGenresRow),nameof(MovieGenresRow.MovieId),nameof(MovieGenresRow.GenreId))]
    public List<int> GenreList { get => fields.GenreList[this]; set=> fields.GenreList[this]=value; }

    [DisplayName("Movie Id"), Identity, IdProperty]
    public int? MovieId { get => fields.MovieId[this]; set => fields.MovieId[this] = value; }

    [DisplayName("Title (mov title)"), Column("title"), Size(200), NotNull, QuickSearch, NameProperty, QuickFilter()]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Image"), Size(200), NotNull]
    [ImageUploadEditor(FilenameFormat ="uploaded/movies/~")]

    public string Image { get => fields.Image[this]; set => fields.Image[this] = value; }

    [DisplayName("Descrition"), Size(200), NotNull]
    public string Descrition { get => fields.Descrition[this]; set => fields.Descrition[this] = value; }
    [DisplayName("Kind"), NotNull]
    public MovieKind? Kind { get => fields.Kind[this]; set => fields.Kind[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field MovieId;
        public StringField Title;
        public StringField Image;
        public StringField Descrition;
        public EnumField<MovieKind> Kind;
        public ListField<int> GenreList;
        //public Int32Field GenreId;

        //public StringField GenreName;


    }
}
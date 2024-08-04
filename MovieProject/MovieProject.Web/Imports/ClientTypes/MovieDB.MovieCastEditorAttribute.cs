using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieProject.MovieDB;

public partial class MovieCastEditorAttribute : CustomEditorAttribute
{
    public const string Key = "MovieProject.MovieDB.MovieCastEditor";

    public MovieCastEditorAttribute()
        : base(Key)
    {
    }
}
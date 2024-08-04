﻿using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieProject.MovieDB.MovieCastRow>;
using MyRow = MovieProject.MovieDB.MovieCastRow;

namespace MovieProject.MovieDB;

public interface IMovieCastListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MovieCastListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastListHandler
{
    public MovieCastListHandler(IRequestContext context)
            : base(context)
    {
    }
}
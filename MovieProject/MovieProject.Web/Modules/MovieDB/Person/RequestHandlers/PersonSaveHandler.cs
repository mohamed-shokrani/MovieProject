﻿using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieProject.MovieDB.PersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieProject.MovieDB.PersonRow;

namespace MovieProject.MovieDB;

public interface IPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonSaveHandler
{
    public PersonSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
﻿import { fieldsProxy } from "@serenity-is/corelib";
import { MovieKind } from "../Modules/MovieDB.Movie.MovieKind";

export interface MovieRow {
    MovieId?: number;
    Title?: string;
    Image?: string;
    Descrition?: string;
    Kind?: MovieKind;
    GenreList?: number[];
}

export abstract class MovieRow {
    static readonly idProperty = 'MovieId';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'MovieDB.Movie';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MovieRow>();
}
import { MovieCastEditor } from "@/MovieDB/MovieCast/MovieCastEditor";
import { StringEditor, ImageUploadEditor, EnumEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { MovieKind } from "../Modules/MovieDB.Movie.MovieKind";

export interface MovieForm {
    Title: StringEditor;
    Image: ImageUploadEditor;
    Descrition: StringEditor;
    Kind: EnumEditor;
    GenreList: LookupEditor;
    CastList: MovieCastEditor;
}

export class MovieForm extends PrefixedContext {
    static readonly formKey = 'MovieDB.Movie';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MovieForm.init)  {
            MovieForm.init = true;

            var w0 = StringEditor;
            var w1 = ImageUploadEditor;
            var w2 = EnumEditor;
            var w3 = LookupEditor;
            var w4 = MovieCastEditor;

            initFormType(MovieForm, [
                'Title', w0,
                'Image', w1,
                'Descrition', w0,
                'Kind', w2,
                'GenreList', w3,
                'CastList', w4
            ]);
        }
    }
}

[MovieKind]; // referenced types
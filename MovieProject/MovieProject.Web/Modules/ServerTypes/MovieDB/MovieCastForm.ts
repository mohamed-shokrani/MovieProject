import { ServiceLookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface MovieCastForm {
    MovieId: ServiceLookupEditor;
    PersonId: ServiceLookupEditor;
    Character: StringEditor;
}

export class MovieCastForm extends PrefixedContext {
    static readonly formKey = 'MovieDB.MovieCast';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MovieCastForm.init)  {
            MovieCastForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;

            initFormType(MovieCastForm, [
                'MovieId', w0,
                'PersonId', w0,
                'Character', w1
            ]);
        }
    }
}
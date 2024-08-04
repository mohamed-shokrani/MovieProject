import { StringEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PersonForm {
    FirstName: StringEditor;
    LastName: StringEditor;
    BirthDate: DateEditor;
    BirthPlace: StringEditor;
    Gender: IntegerEditor;
    Height: IntegerEditor;
}

export class PersonForm extends PrefixedContext {
    static readonly formKey = 'MovieDB.Person';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PersonForm.init)  {
            PersonForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;

            initFormType(PersonForm, [
                'FirstName', w0,
                'LastName', w0,
                'BirthDate', w1,
                'BirthPlace', w0,
                'Gender', w2,
                'Height', w2
            ]);
        }
    }
}
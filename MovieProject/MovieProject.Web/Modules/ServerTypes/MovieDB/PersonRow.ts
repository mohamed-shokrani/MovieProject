import { fieldsProxy } from "@serenity-is/corelib";

export interface PersonRow {
    PersonId?: number;
    FirstName?: string;
    LastName?: string;
    BirthDate?: string;
    BirthPlace?: string;
    Gender?: number;
    Height?: number;
}

export abstract class PersonRow {
    static readonly idProperty = 'PersonId';
    static readonly nameProperty = 'FirstName';
    static readonly localTextPrefix = 'MovieDB.Person';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PersonRow>();
}
import { fieldsProxy } from "@serenity-is/corelib";

export interface SalesInvoiceItemsRow {
    Id?: number;
    Date?: string;
    Notes?: string;
    SalesInvoiceId?: number;
    SalesInvoiceNotes?: string;
}

export abstract class SalesInvoiceItemsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Notes';
    static readonly localTextPrefix = 'Northwind.SalesInvoiceItems';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SalesInvoiceItemsRow>();
}
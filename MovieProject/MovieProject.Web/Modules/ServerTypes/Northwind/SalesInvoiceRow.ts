import { fieldsProxy } from "@serenity-is/corelib";

export interface SalesInvoiceRow {
    SaleInvoiceId?: number;
    Date?: string;
    Notes?: string;
}

export abstract class SalesInvoiceRow {
    static readonly idProperty = 'SaleInvoiceId';
    static readonly nameProperty = 'Notes';
    static readonly localTextPrefix = 'Northwind.SalesInvoice';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SalesInvoiceRow>();
}
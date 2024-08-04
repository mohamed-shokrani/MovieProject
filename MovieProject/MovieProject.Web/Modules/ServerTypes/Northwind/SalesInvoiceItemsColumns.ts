import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SalesInvoiceItemsRow } from "./SalesInvoiceItemsRow";

export interface SalesInvoiceItemsColumns {
    Id: Column<SalesInvoiceItemsRow>;
    Date: Column<SalesInvoiceItemsRow>;
    Notes: Column<SalesInvoiceItemsRow>;
    SalesInvoiceNotes: Column<SalesInvoiceItemsRow>;
}

export class SalesInvoiceItemsColumns extends ColumnsBase<SalesInvoiceItemsRow> {
    static readonly columnsKey = 'Northwind.SalesInvoiceItems';
    static readonly Fields = fieldsProxy<SalesInvoiceItemsColumns>();
}
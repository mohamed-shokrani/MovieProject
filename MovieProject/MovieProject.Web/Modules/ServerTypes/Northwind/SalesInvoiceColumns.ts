import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SalesInvoiceRow } from "./SalesInvoiceRow";

export interface SalesInvoiceColumns {
    SaleInvoiceId: Column<SalesInvoiceRow>;
    Date: Column<SalesInvoiceRow>;
    Notes: Column<SalesInvoiceRow>;
}

export class SalesInvoiceColumns extends ColumnsBase<SalesInvoiceRow> {
    static readonly columnsKey = 'Northwind.SalesInvoice';
    static readonly Fields = fieldsProxy<SalesInvoiceColumns>();
}
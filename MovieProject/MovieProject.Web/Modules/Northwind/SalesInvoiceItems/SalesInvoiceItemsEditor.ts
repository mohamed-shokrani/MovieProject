//import { SalesInvoiceItemsColumns, SalesInvoiceItemsRow, SalesInvoiceItemsService } from '@/ServerTypes/Northwind';
//import { Decorators, EntityGrid } from '@serenity-is/corelib';
//import { SalesInvoiceItemsDialog } from './SalesInvoiceItemsDialog';

//@Decorators.registerClass('MovieProject.Northwind.SalesInvoiceItemsGrid')
//export class SalesInvoiceItemsGrid extends EntityGrid<SalesInvoiceItemsRow> {
//    protected getColumnsKey() { return SalesInvoiceItemsColumns.columnsKey; }
//    protected getDialogType() { return SalesInvoiceItemsDialog; }
//    protected getRowDefinition() { return SalesInvoiceItemsRow; }
//    protected getService() { return SalesInvoiceItemsService.baseUrl; }
//}
import { Decorators } from "@serenity-is/corelib";
import { GridEditorBase } from "@serenity-is/extensions";
import { SalesInvoiceItemsColumns, SalesInvoiceItemsRow } from "@/ServerTypes/Northwind";

@Decorators.registerEditor("MovieProject.Northwind.SalesInvoiceItemsEditor")
export class SalesInvoiceItemsEditor extends GridEditorBase<SalesInvoiceItemsRow> {
    protected getColumnsKey() { return SalesInvoiceItemsColumns.columnsKey }
    protected getLocalTextPrefix() { return SalesInvoiceItemsRow.localTextPrefix; }

   
}
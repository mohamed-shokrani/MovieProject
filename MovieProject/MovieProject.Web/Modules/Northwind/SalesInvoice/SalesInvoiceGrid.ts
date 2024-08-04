import { SalesInvoiceColumns, SalesInvoiceRow, SalesInvoiceService } from '@/ServerTypes/Northwind';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SalesInvoiceDialog } from './SalesInvoiceDialog';

@Decorators.registerClass('MovieProject.Northwind.SalesInvoiceGrid')
export class SalesInvoiceGrid extends EntityGrid<SalesInvoiceRow> {
    protected getColumnsKey() { return SalesInvoiceColumns.columnsKey; }
    protected getDialogType() { return SalesInvoiceDialog; }
    protected getRowDefinition() { return SalesInvoiceRow; }
    protected getService() { return SalesInvoiceService.baseUrl; }
}
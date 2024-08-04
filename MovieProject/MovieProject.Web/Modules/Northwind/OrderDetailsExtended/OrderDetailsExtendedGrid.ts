import { OrderDetailsExtendedColumns, OrderDetailsExtendedRow, OrderDetailsExtendedService } from '@/ServerTypes/Northwind';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OrderDetailsExtendedDialog } from './OrderDetailsExtendedDialog';

@Decorators.registerClass('MovieProject.Northwind.OrderDetailsExtendedGrid')
export class OrderDetailsExtendedGrid extends EntityGrid<OrderDetailsExtendedRow> {
    protected getColumnsKey() { return OrderDetailsExtendedColumns.columnsKey; }
    protected getDialogType() { return OrderDetailsExtendedDialog; }
    protected getRowDefinition() { return OrderDetailsExtendedRow; }
    protected getService() { return OrderDetailsExtendedService.baseUrl; }
}
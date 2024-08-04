import { OrderDetailsColumns, OrderDetailsRow, OrderDetailsService } from '@/ServerTypes/Northwind';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OrderDetailsDialog } from './OrderDetailsDialog';

@Decorators.registerClass('MovieProject.Northwind.OrderDetailsGrid')
export class OrderDetailsGrid extends EntityGrid<OrderDetailsRow> {
    protected getColumnsKey() { return OrderDetailsColumns.columnsKey; }
    protected getDialogType() { return OrderDetailsDialog; }
    protected getRowDefinition() { return OrderDetailsRow; }
    protected getService() { return OrderDetailsService.baseUrl; }
}
import { OrdersColumns, OrdersRow, OrdersService } from '@/ServerTypes/Northwind';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OrdersDialog } from './OrdersDialog';

@Decorators.registerClass('MovieProject.Northwind.OrdersGrid')
export class OrdersGrid extends EntityGrid<OrdersRow> {
    protected getColumnsKey() { return OrdersColumns.columnsKey; }
    protected getDialogType() { return OrdersDialog; }
    protected getRowDefinition() { return OrdersRow; }
    protected getService() { return OrdersService.baseUrl; }
}
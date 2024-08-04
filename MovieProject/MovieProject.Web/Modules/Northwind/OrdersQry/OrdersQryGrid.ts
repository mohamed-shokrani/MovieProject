import { OrdersQryColumns, OrdersQryRow, OrdersQryService } from '@/ServerTypes/Northwind';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OrdersQryDialog } from './OrdersQryDialog';

@Decorators.registerClass('MovieProject.Northwind.OrdersQryGrid')
export class OrdersQryGrid extends EntityGrid<OrdersQryRow> {
    protected getColumnsKey() { return OrdersQryColumns.columnsKey; }
    protected getDialogType() { return OrdersQryDialog; }
    protected getRowDefinition() { return OrdersQryRow; }
    protected getService() { return OrdersQryService.baseUrl; }
}
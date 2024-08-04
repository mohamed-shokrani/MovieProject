import { OrderSubtotalsColumns, OrderSubtotalsRow, OrderSubtotalsService } from '@/ServerTypes/Northwind';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OrderSubtotalsDialog } from './OrderSubtotalsDialog';

@Decorators.registerClass('MovieProject.Northwind.OrderSubtotalsGrid')
export class OrderSubtotalsGrid extends EntityGrid<OrderSubtotalsRow> {
    protected getColumnsKey() { return OrderSubtotalsColumns.columnsKey; }
    protected getDialogType() { return OrderSubtotalsDialog; }
    protected getRowDefinition() { return OrderSubtotalsRow; }
    protected getService() { return OrderSubtotalsService.baseUrl; }
}
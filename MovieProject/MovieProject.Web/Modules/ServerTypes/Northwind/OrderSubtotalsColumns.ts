import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { OrderSubtotalsRow } from "./OrderSubtotalsRow";

export interface OrderSubtotalsColumns {
    OrderId: Column<OrderSubtotalsRow>;
    Subtotal: Column<OrderSubtotalsRow>;
}

export class OrderSubtotalsColumns extends ColumnsBase<OrderSubtotalsRow> {
    static readonly columnsKey = 'Northwind.OrderSubtotals';
    static readonly Fields = fieldsProxy<OrderSubtotalsColumns>();
}
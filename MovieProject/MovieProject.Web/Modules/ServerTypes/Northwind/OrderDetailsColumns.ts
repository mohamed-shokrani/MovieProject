import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { OrderDetailsRow } from "./OrderDetailsRow";

export interface OrderDetailsColumns {
    OrderCustomerId: Column<OrderDetailsRow>;
    ProductName: Column<OrderDetailsRow>;
    UnitPrice: Column<OrderDetailsRow>;
    Quantity: Column<OrderDetailsRow>;
    Discount: Column<OrderDetailsRow>;
    DetailId: Column<OrderDetailsRow>;
}

export class OrderDetailsColumns extends ColumnsBase<OrderDetailsRow> {
    static readonly columnsKey = 'Northwind.OrderDetails';
    static readonly Fields = fieldsProxy<OrderDetailsColumns>();
}
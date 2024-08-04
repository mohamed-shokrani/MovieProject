import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { OrderDetailsExtendedRow } from "./OrderDetailsExtendedRow";

export interface OrderDetailsExtendedColumns {
    OrderId: Column<OrderDetailsExtendedRow>;
    ProductId: Column<OrderDetailsExtendedRow>;
    ProductName: Column<OrderDetailsExtendedRow>;
    UnitPrice: Column<OrderDetailsExtendedRow>;
    Quantity: Column<OrderDetailsExtendedRow>;
    Discount: Column<OrderDetailsExtendedRow>;
    ExtendedPrice: Column<OrderDetailsExtendedRow>;
}

export class OrderDetailsExtendedColumns extends ColumnsBase<OrderDetailsExtendedRow> {
    static readonly columnsKey = 'Northwind.OrderDetailsExtended';
    static readonly Fields = fieldsProxy<OrderDetailsExtendedColumns>();
}
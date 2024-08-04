import { fieldsProxy } from "@serenity-is/corelib";

export interface OrderSubtotalsRow {
    OrderId?: number;
    Subtotal?: number;
}

export abstract class OrderSubtotalsRow {
    static readonly idProperty = 'OrderId';
    static readonly localTextPrefix = 'Northwind.OrderSubtotals';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<OrderSubtotalsRow>();
}
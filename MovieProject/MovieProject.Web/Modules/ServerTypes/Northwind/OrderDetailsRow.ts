import { fieldsProxy } from "@serenity-is/corelib";

export interface OrderDetailsRow {
    OrderId?: number;
    ProductId?: number;
    UnitPrice?: number;
    Quantity?: number;
    Discount?: number;
    DetailId?: number;
    OrderCustomerId?: string;
    ProductName?: string;
}

export abstract class OrderDetailsRow {
    static readonly idProperty = 'DetailId';
    static readonly localTextPrefix = 'Northwind.OrderDetails';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<OrderDetailsRow>();
}
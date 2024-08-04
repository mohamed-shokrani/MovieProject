import { fieldsProxy } from "@serenity-is/corelib";

export interface OrderDetailsExtendedRow {
    OrderId?: number;
    ProductId?: number;
    ProductName?: string;
    UnitPrice?: number;
    Quantity?: number;
    Discount?: number;
    ExtendedPrice?: number;
}

export abstract class OrderDetailsExtendedRow {
    static readonly idProperty = 'OrderId';
    static readonly nameProperty = 'ProductName';
    static readonly localTextPrefix = 'Northwind.OrderDetailsExtended';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<OrderDetailsExtendedRow>();
}
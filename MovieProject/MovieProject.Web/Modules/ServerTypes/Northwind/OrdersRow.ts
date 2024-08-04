import { fieldsProxy } from "@serenity-is/corelib";

export interface OrdersRow {
    OrderId?: number;
    CustomerId?: string;
    EmployeeId?: number;
    OrderDate?: string;
    RequiredDate?: string;
    ShippedDate?: string;
    ShipVia?: number;
    Freight?: number;
    ShipName?: string;
    ShipAddress?: string;
    ShipCity?: string;
    ShipRegion?: string;
    ShipPostalCode?: string;
    ShipCountry?: string;
    CustomerCompanyName?: string;
    EmployeeFullName?: string;
    ShipViaCompanyName?: string;
}

export abstract class OrdersRow {
    static readonly idProperty = 'OrderId';
    static readonly nameProperty = 'CustomerId';
    static readonly localTextPrefix = 'Northwind.Orders';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<OrdersRow>();
}
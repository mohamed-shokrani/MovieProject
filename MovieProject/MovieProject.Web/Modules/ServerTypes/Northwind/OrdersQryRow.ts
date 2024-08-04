import { fieldsProxy } from "@serenity-is/corelib";

export interface OrdersQryRow {
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
    CompanyName?: string;
    Address?: string;
    City?: string;
    Region?: string;
    PostalCode?: string;
    Country?: string;
}

export abstract class OrdersQryRow {
    static readonly idProperty = 'OrderId';
    static readonly nameProperty = 'CustomerId';
    static readonly localTextPrefix = 'Northwind.OrdersQry';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<OrdersQryRow>();
}
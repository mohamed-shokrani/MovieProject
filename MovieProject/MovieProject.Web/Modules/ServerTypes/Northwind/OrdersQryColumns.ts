import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { OrdersQryRow } from "./OrdersQryRow";

export interface OrdersQryColumns {
    OrderId: Column<OrdersQryRow>;
    CustomerId: Column<OrdersQryRow>;
    EmployeeId: Column<OrdersQryRow>;
    OrderDate: Column<OrdersQryRow>;
    RequiredDate: Column<OrdersQryRow>;
    ShippedDate: Column<OrdersQryRow>;
    ShipVia: Column<OrdersQryRow>;
    Freight: Column<OrdersQryRow>;
    ShipName: Column<OrdersQryRow>;
    ShipAddress: Column<OrdersQryRow>;
    ShipCity: Column<OrdersQryRow>;
    ShipRegion: Column<OrdersQryRow>;
    ShipPostalCode: Column<OrdersQryRow>;
    ShipCountry: Column<OrdersQryRow>;
    CompanyName: Column<OrdersQryRow>;
    Address: Column<OrdersQryRow>;
    City: Column<OrdersQryRow>;
    Region: Column<OrdersQryRow>;
    PostalCode: Column<OrdersQryRow>;
    Country: Column<OrdersQryRow>;
}

export class OrdersQryColumns extends ColumnsBase<OrdersQryRow> {
    static readonly columnsKey = 'Northwind.OrdersQry';
    static readonly Fields = fieldsProxy<OrdersQryColumns>();
}
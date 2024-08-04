import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { OrdersRow } from "./OrdersRow";

export interface OrdersColumns {
    OrderId: Column<OrdersRow>;
    CustomerCompanyName: Column<OrdersRow>;
    EmployeeFullName: Column<OrdersRow>;
    OrderDate: Column<OrdersRow>;
    RequiredDate: Column<OrdersRow>;
    ShippedDate: Column<OrdersRow>;
    ShipViaCompanyName: Column<OrdersRow>;
    Freight: Column<OrdersRow>;
    ShipName: Column<OrdersRow>;
    ShipAddress: Column<OrdersRow>;
    ShipCity: Column<OrdersRow>;
    ShipRegion: Column<OrdersRow>;
    ShipPostalCode: Column<OrdersRow>;
    ShipCountry: Column<OrdersRow>;
}

export class OrdersColumns extends ColumnsBase<OrdersRow> {
    static readonly columnsKey = 'Northwind.Orders';
    static readonly Fields = fieldsProxy<OrdersColumns>();
}
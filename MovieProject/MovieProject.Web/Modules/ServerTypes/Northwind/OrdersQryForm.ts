import { StringEditor, IntegerEditor, DateEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface OrdersQryForm {
    CustomerId: StringEditor;
    EmployeeId: IntegerEditor;
    OrderDate: DateEditor;
    RequiredDate: DateEditor;
    ShippedDate: DateEditor;
    ShipVia: IntegerEditor;
    Freight: DecimalEditor;
    ShipName: StringEditor;
    ShipAddress: StringEditor;
    ShipCity: StringEditor;
    ShipRegion: StringEditor;
    ShipPostalCode: StringEditor;
    ShipCountry: StringEditor;
    CompanyName: StringEditor;
    Address: StringEditor;
    City: StringEditor;
    Region: StringEditor;
    PostalCode: StringEditor;
    Country: StringEditor;
}

export class OrdersQryForm extends PrefixedContext {
    static readonly formKey = 'Northwind.OrdersQry';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OrdersQryForm.init)  {
            OrdersQryForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;
            var w3 = DecimalEditor;

            initFormType(OrdersQryForm, [
                'CustomerId', w0,
                'EmployeeId', w1,
                'OrderDate', w2,
                'RequiredDate', w2,
                'ShippedDate', w2,
                'ShipVia', w1,
                'Freight', w3,
                'ShipName', w0,
                'ShipAddress', w0,
                'ShipCity', w0,
                'ShipRegion', w0,
                'ShipPostalCode', w0,
                'ShipCountry', w0,
                'CompanyName', w0,
                'Address', w0,
                'City', w0,
                'Region', w0,
                'PostalCode', w0,
                'Country', w0
            ]);
        }
    }
}
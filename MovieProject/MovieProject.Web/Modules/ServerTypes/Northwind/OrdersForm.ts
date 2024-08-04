import { StringEditor, LookupEditor, DateEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface OrdersForm {
    CustomerId: StringEditor;
    EmployeeId: LookupEditor;
    OrderDate: DateEditor;
    RequiredDate: DateEditor;
    ShippedDate: DateEditor;
    ShipVia: LookupEditor;
    Freight: DecimalEditor;
    ShipName: StringEditor;
    ShipAddress: StringEditor;
    ShipCity: StringEditor;
    ShipRegion: StringEditor;
    ShipPostalCode: StringEditor;
    ShipCountry: StringEditor;
}

export class OrdersForm extends PrefixedContext {
    static readonly formKey = 'Northwind.Orders';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OrdersForm.init)  {
            OrdersForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;
            var w3 = DecimalEditor;

            initFormType(OrdersForm, [
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
                'ShipCountry', w0
            ]);
        }
    }
}
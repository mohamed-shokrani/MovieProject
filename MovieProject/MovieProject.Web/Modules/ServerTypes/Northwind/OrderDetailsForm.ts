import { ServiceLookupEditor, LookupEditor, DecimalEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface OrderDetailsForm {
    OrderId: ServiceLookupEditor;
    ProductId: LookupEditor;
    UnitPrice: DecimalEditor;
    Quantity: IntegerEditor;
    Discount: DecimalEditor;
}

export class OrderDetailsForm extends PrefixedContext {
    static readonly formKey = 'Northwind.OrderDetails';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OrderDetailsForm.init)  {
            OrderDetailsForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = DecimalEditor;
            var w3 = IntegerEditor;

            initFormType(OrderDetailsForm, [
                'OrderId', w0,
                'ProductId', w1,
                'UnitPrice', w2,
                'Quantity', w3,
                'Discount', w2
            ]);
        }
    }
}
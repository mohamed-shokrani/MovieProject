import { IntegerEditor, StringEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface OrderDetailsExtendedForm {
    ProductId: IntegerEditor;
    ProductName: StringEditor;
    UnitPrice: DecimalEditor;
    Quantity: IntegerEditor;
    Discount: DecimalEditor;
    ExtendedPrice: DecimalEditor;
}

export class OrderDetailsExtendedForm extends PrefixedContext {
    static readonly formKey = 'Northwind.OrderDetailsExtended';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OrderDetailsExtendedForm.init)  {
            OrderDetailsExtendedForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DecimalEditor;

            initFormType(OrderDetailsExtendedForm, [
                'ProductId', w0,
                'ProductName', w1,
                'UnitPrice', w2,
                'Quantity', w0,
                'Discount', w2,
                'ExtendedPrice', w2
            ]);
        }
    }
}
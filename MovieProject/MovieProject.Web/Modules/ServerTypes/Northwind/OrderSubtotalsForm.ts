import { DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface OrderSubtotalsForm {
    Subtotal: DecimalEditor;
}

export class OrderSubtotalsForm extends PrefixedContext {
    static readonly formKey = 'Northwind.OrderSubtotals';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OrderSubtotalsForm.init)  {
            OrderSubtotalsForm.init = true;

            var w0 = DecimalEditor;

            initFormType(OrderSubtotalsForm, [
                'Subtotal', w0
            ]);
        }
    }
}
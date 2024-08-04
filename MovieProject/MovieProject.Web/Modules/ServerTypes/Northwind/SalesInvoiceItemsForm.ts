import { DateEditor, StringEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SalesInvoiceItemsForm {
    Date: DateEditor;
    Notes: StringEditor;
    SalesInvoiceId: ServiceLookupEditor;
}

export class SalesInvoiceItemsForm extends PrefixedContext {
    static readonly formKey = 'Northwind.SalesInvoiceItems';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SalesInvoiceItemsForm.init)  {
            SalesInvoiceItemsForm.init = true;

            var w0 = DateEditor;
            var w1 = StringEditor;
            var w2 = ServiceLookupEditor;

            initFormType(SalesInvoiceItemsForm, [
                'Date', w0,
                'Notes', w1,
                'SalesInvoiceId', w2
            ]);
        }
    }
}
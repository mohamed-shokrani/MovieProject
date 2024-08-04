import { SalesInvoiceItemsEditor } from "@/Northwind/SalesInvoiceItems/SalesInvoiceItemsEditor";
import { DateEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SalesInvoiceForm {
    Date: DateEditor;
    Notes: StringEditor;
    Rows: SalesInvoiceItemsEditor;
}

export class SalesInvoiceForm extends PrefixedContext {
    static readonly formKey = 'Northwind.SalesInvoice';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SalesInvoiceForm.init)  {
            SalesInvoiceForm.init = true;

            var w0 = DateEditor;
            var w1 = StringEditor;
            var w2 = SalesInvoiceItemsEditor;

            initFormType(SalesInvoiceForm, [
                'Date', w0,
                'Notes', w1,
                'Rows', w2
            ]);
        }
    }
}
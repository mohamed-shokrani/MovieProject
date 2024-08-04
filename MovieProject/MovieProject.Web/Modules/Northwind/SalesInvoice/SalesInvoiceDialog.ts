import { SalesInvoiceForm, SalesInvoiceRow, SalesInvoiceService } from '@/ServerTypes/Northwind';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('MovieProject.Northwind.SalesInvoiceDialog')
export class SalesInvoiceDialog extends EntityDialog<SalesInvoiceRow, any> {
    protected getFormKey() { return SalesInvoiceForm.formKey; }
    protected getRowDefinition() { return SalesInvoiceRow; }
    protected getService() { return SalesInvoiceService.baseUrl; }

    protected form = new SalesInvoiceForm(this.idPrefix);
}
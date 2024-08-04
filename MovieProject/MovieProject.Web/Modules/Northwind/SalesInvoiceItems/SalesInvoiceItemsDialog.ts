import { SalesInvoiceItemsForm, SalesInvoiceItemsRow, SalesInvoiceItemsService } from '@/ServerTypes/Northwind';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('MovieProject.Northwind.SalesInvoiceItemsDialog')
export class SalesInvoiceItemsDialog extends EntityDialog<SalesInvoiceItemsRow, any> {
    protected getFormKey() { return SalesInvoiceItemsForm.formKey; }
    protected getRowDefinition() { return SalesInvoiceItemsRow; }
    protected getService() { return SalesInvoiceItemsService.baseUrl; }

    protected form = new SalesInvoiceItemsForm(this.idPrefix);
}
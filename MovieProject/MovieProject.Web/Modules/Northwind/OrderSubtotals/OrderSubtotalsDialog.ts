import { OrderSubtotalsForm, OrderSubtotalsRow, OrderSubtotalsService } from '@/ServerTypes/Northwind';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('MovieProject.Northwind.OrderSubtotalsDialog')
export class OrderSubtotalsDialog extends EntityDialog<OrderSubtotalsRow, any> {
    protected getFormKey() { return OrderSubtotalsForm.formKey; }
    protected getRowDefinition() { return OrderSubtotalsRow; }
    protected getService() { return OrderSubtotalsService.baseUrl; }

    protected form = new OrderSubtotalsForm(this.idPrefix);
}
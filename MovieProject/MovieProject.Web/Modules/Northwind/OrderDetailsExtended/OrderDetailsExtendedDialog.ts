import { OrderDetailsExtendedForm, OrderDetailsExtendedRow, OrderDetailsExtendedService } from '@/ServerTypes/Northwind';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('MovieProject.Northwind.OrderDetailsExtendedDialog')
export class OrderDetailsExtendedDialog extends EntityDialog<OrderDetailsExtendedRow, any> {
    protected getFormKey() { return OrderDetailsExtendedForm.formKey; }
    protected getRowDefinition() { return OrderDetailsExtendedRow; }
    protected getService() { return OrderDetailsExtendedService.baseUrl; }

    protected form = new OrderDetailsExtendedForm(this.idPrefix);
}
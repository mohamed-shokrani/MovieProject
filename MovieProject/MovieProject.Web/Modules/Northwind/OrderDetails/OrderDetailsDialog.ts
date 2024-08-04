import { OrderDetailsForm, OrderDetailsRow, OrderDetailsService } from '@/ServerTypes/Northwind';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('MovieProject.Northwind.OrderDetailsDialog')
export class OrderDetailsDialog extends EntityDialog<OrderDetailsRow, any> {
    protected getFormKey() { return OrderDetailsForm.formKey; }
    protected getRowDefinition() { return OrderDetailsRow; }
    protected getService() { return OrderDetailsService.baseUrl; }

    protected form = new OrderDetailsForm(this.idPrefix);
}
import { OrdersQryForm, OrdersQryRow, OrdersQryService } from '@/ServerTypes/Northwind';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('MovieProject.Northwind.OrdersQryDialog')
export class OrdersQryDialog extends EntityDialog<OrdersQryRow, any> {
    protected getFormKey() { return OrdersQryForm.formKey; }
    protected getRowDefinition() { return OrdersQryRow; }
    protected getService() { return OrdersQryService.baseUrl; }

    protected form = new OrdersQryForm(this.idPrefix);
}
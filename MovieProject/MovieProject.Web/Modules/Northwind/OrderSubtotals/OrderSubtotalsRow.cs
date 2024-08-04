using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MovieProject.Northwind;

[ConnectionKey("Northwind"), Module("Northwind"), TableName("Order Subtotals")]
[DisplayName("Order Subtotals"), InstanceName("Order Subtotals")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class OrderSubtotalsRow : Row<OrderSubtotalsRow.RowFields>, IIdRow
{
    [DisplayName("Order Id"), Column("OrderID"), NotNull, IdProperty]
    public int? OrderId { get => fields.OrderId[this]; set => fields.OrderId[this] = value; }

    [DisplayName("Subtotal"), Size(19), Scale(4)]
    public decimal? Subtotal { get => fields.Subtotal[this]; set => fields.Subtotal[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field OrderId;
        public DecimalField Subtotal;

    }
}
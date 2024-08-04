using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MovieProject.Northwind;

[ConnectionKey("Northwind"), Module("Northwind"), TableName("Order Details Extended")]
[DisplayName("Order Details Extended"), InstanceName("Order Details Extended")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class OrderDetailsExtendedRow : Row<OrderDetailsExtendedRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Order Id"), Column("OrderID"), NotNull, IdProperty]
    public int? OrderId { get => fields.OrderId[this]; set => fields.OrderId[this] = value; }

    [DisplayName("Product Id"), Column("ProductID"), NotNull]
    public int? ProductId { get => fields.ProductId[this]; set => fields.ProductId[this] = value; }

    [DisplayName("Product Name"), Size(40), NotNull, QuickSearch, NameProperty]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    [DisplayName("Unit Price"), Size(19), Scale(4), NotNull]
    public decimal? UnitPrice { get => fields.UnitPrice[this]; set => fields.UnitPrice[this] = value; }

    [DisplayName("Quantity"), NotNull]
    public short? Quantity { get => fields.Quantity[this]; set => fields.Quantity[this] = value; }

    [DisplayName("Discount"), NotNull]
    public float? Discount { get => fields.Discount[this]; set => fields.Discount[this] = value; }

    [DisplayName("Extended Price"), Size(19), Scale(4)]
    public decimal? ExtendedPrice { get => fields.ExtendedPrice[this]; set => fields.ExtendedPrice[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field OrderId;
        public Int32Field ProductId;
        public StringField ProductName;
        public DecimalField UnitPrice;
        public Int16Field Quantity;
        public SingleField Discount;
        public DecimalField ExtendedPrice;

    }
}
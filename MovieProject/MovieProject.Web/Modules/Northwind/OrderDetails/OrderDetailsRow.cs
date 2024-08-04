using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace MovieProject.Northwind;

[ConnectionKey("Northwind"), Module("Northwind"), TableName("Order Details")]
[DisplayName("Order Details"), InstanceName("Order Details")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class OrderDetailsRow : Row<OrderDetailsRow.RowFields>, IIdRow
{
    const string jOrder = nameof(jOrder);
    const string jProduct = nameof(jProduct);

    [DisplayName("Order"), Column("OrderID"), PrimaryKey, NotNull, ForeignKey(typeof(OrdersRow)), LeftJoin(jOrder)]
    [TextualField(nameof(OrderCustomerId)), ServiceLookupEditor(typeof(OrdersRow))]
    public int? OrderId { get => fields.OrderId[this]; set => fields.OrderId[this] = value; }

    [DisplayName("Product"), Column("ProductID"), PrimaryKey, NotNull, ForeignKey(typeof(Serenity.Demo.Northwind.ProductRow))]
    [LeftJoin(jProduct), TextualField(nameof(ProductName)), LookupEditor(typeof(Serenity.Demo.Northwind.ProductRow), Async = true)]
    public int? ProductId { get => fields.ProductId[this]; set => fields.ProductId[this] = value; }

    [DisplayName("Unit Price"), Size(19), Scale(4), NotNull]
    public decimal? UnitPrice { get => fields.UnitPrice[this]; set => fields.UnitPrice[this] = value; }

    [DisplayName("Quantity"), NotNull]
    public short? Quantity { get => fields.Quantity[this]; set => fields.Quantity[this] = value; }

    [DisplayName("Discount"), NotNull]
    public float? Discount { get => fields.Discount[this]; set => fields.Discount[this] = value; }

    [DisplayName("Detail Id"), Column("DetailID"), Identity, IdProperty]
    public int? DetailId { get => fields.DetailId[this]; set => fields.DetailId[this] = value; }

    [DisplayName("Order Customer Id"), Origin(jOrder, nameof(OrdersRow.CustomerId))]
    public string OrderCustomerId { get => fields.OrderCustomerId[this]; set => fields.OrderCustomerId[this] = value; }

    [DisplayName("Product Product Name"), Origin(jProduct, nameof(Serenity.Demo.Northwind.ProductRow.ProductName))]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field OrderId;
        public Int32Field ProductId;
        public DecimalField UnitPrice;
        public Int16Field Quantity;
        public SingleField Discount;
        public Int32Field DetailId;

        public StringField OrderCustomerId;
        public StringField ProductName;
    }
}
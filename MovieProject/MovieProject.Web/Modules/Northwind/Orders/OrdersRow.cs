using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MovieProject.Northwind;

[ConnectionKey("Northwind"), Module("Northwind"), TableName("Orders")]
[DisplayName("Orders"), InstanceName("Orders")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class OrdersRow : Row<OrdersRow.RowFields>, IIdRow, INameRow
{
    const string jCustomer = nameof(jCustomer);
    const string jEmployee = nameof(jEmployee);
    const string jShipVia = nameof(jShipVia);

    [DisplayName("Order Id"), Column("OrderID"), Identity, IdProperty]
    public int? OrderId { get => fields.OrderId[this]; set => fields.OrderId[this] = value; }

    [DisplayName("Customer"), Column("CustomerID"), Size(5), ForeignKey(typeof(Serenity.Demo.Northwind.CustomerRow), "CustomerID")]
    [LeftJoin(jCustomer), QuickSearch, NameProperty, TextualField(nameof(CustomerCompanyName))]
    public string CustomerId { get => fields.CustomerId[this]; set => fields.CustomerId[this] = value; }

    [DisplayName("Employee"), Column("EmployeeID"), ForeignKey(typeof(Serenity.Demo.Northwind.EmployeeRow)), LeftJoin(jEmployee)]
    [TextualField(nameof(EmployeeFullName)), LookupEditor(typeof(Serenity.Demo.Northwind.EmployeeRow), Async = true)]
    public int? EmployeeId { get => fields.EmployeeId[this]; set => fields.EmployeeId[this] = value; }

    [DisplayName("Order Date")]
    public DateTime? OrderDate { get => fields.OrderDate[this]; set => fields.OrderDate[this] = value; }

    [DisplayName("Required Date")]
    public DateTime? RequiredDate { get => fields.RequiredDate[this]; set => fields.RequiredDate[this] = value; }

    [DisplayName("Shipped Date")]
    public DateTime? ShippedDate { get => fields.ShippedDate[this]; set => fields.ShippedDate[this] = value; }

    [DisplayName("Ship Via"), ForeignKey(typeof(Serenity.Demo.Northwind.ShipperRow)), LeftJoin(jShipVia)]
    [TextualField(nameof(ShipViaCompanyName)), LookupEditor(typeof(Serenity.Demo.Northwind.ShipperRow), Async = true)]
    public int? ShipVia { get => fields.ShipVia[this]; set => fields.ShipVia[this] = value; }

    [DisplayName("Freight"), Size(19), Scale(4)]
    public decimal? Freight { get => fields.Freight[this]; set => fields.Freight[this] = value; }

    [DisplayName("Ship Name"), Size(40)]
    public string ShipName { get => fields.ShipName[this]; set => fields.ShipName[this] = value; }

    [DisplayName("Ship Address"), Size(60)]
    public string ShipAddress { get => fields.ShipAddress[this]; set => fields.ShipAddress[this] = value; }

    [DisplayName("Ship City"), Size(15)]
    public string ShipCity { get => fields.ShipCity[this]; set => fields.ShipCity[this] = value; }

    [DisplayName("Ship Region"), Size(15)]
    public string ShipRegion { get => fields.ShipRegion[this]; set => fields.ShipRegion[this] = value; }

    [DisplayName("Ship Postal Code"), Size(10)]
    public string ShipPostalCode { get => fields.ShipPostalCode[this]; set => fields.ShipPostalCode[this] = value; }

    [DisplayName("Ship Country"), Size(15)]
    public string ShipCountry { get => fields.ShipCountry[this]; set => fields.ShipCountry[this] = value; }

    [DisplayName("Customer Company Name"), Origin(jCustomer, nameof(Serenity.Demo.Northwind.CustomerRow.CompanyName))]
    public string CustomerCompanyName { get => fields.CustomerCompanyName[this]; set => fields.CustomerCompanyName[this] = value; }

    [DisplayName("Employee"), Origin(jEmployee, nameof(Serenity.Demo.Northwind.EmployeeRow.FullName))]
    public string EmployeeFullName { get => fields.EmployeeFullName[this]; set => fields.EmployeeFullName[this] = value; }

    [DisplayName("Ship Via Company Name"), Origin(jShipVia, nameof(Serenity.Demo.Northwind.ShipperRow.CompanyName))]
    public string ShipViaCompanyName { get => fields.ShipViaCompanyName[this]; set => fields.ShipViaCompanyName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field OrderId;
        public StringField CustomerId;
        public Int32Field EmployeeId;
        public DateTimeField OrderDate;
        public DateTimeField RequiredDate;
        public DateTimeField ShippedDate;
        public Int32Field ShipVia;
        public DecimalField Freight;
        public StringField ShipName;
        public StringField ShipAddress;
        public StringField ShipCity;
        public StringField ShipRegion;
        public StringField ShipPostalCode;
        public StringField ShipCountry;

        public StringField CustomerCompanyName;
        public StringField EmployeeFullName;
        public StringField ShipViaCompanyName;
    }
}
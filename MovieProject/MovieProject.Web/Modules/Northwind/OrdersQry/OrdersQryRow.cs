using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MovieProject.Northwind;

[ConnectionKey("Northwind"), Module("Northwind"), TableName("Orders Qry")]
[DisplayName("Orders Qry"), InstanceName("Orders Qry")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class OrdersQryRow : Row<OrdersQryRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Order Id"), Column("OrderID"), NotNull, IdProperty]
    public int? OrderId { get => fields.OrderId[this]; set => fields.OrderId[this] = value; }

    [DisplayName("Customer Id"), Column("CustomerID"), Size(5), QuickSearch, NameProperty]
    public string CustomerId { get => fields.CustomerId[this]; set => fields.CustomerId[this] = value; }

    [DisplayName("Employee Id"), Column("EmployeeID")]
    public int? EmployeeId { get => fields.EmployeeId[this]; set => fields.EmployeeId[this] = value; }

    [DisplayName("Order Date")]
    public DateTime? OrderDate { get => fields.OrderDate[this]; set => fields.OrderDate[this] = value; }

    [DisplayName("Required Date")]
    public DateTime? RequiredDate { get => fields.RequiredDate[this]; set => fields.RequiredDate[this] = value; }

    [DisplayName("Shipped Date")]
    public DateTime? ShippedDate { get => fields.ShippedDate[this]; set => fields.ShippedDate[this] = value; }

    [DisplayName("Ship Via")]
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

    [DisplayName("Company Name"), Size(40), NotNull]
    public string CompanyName { get => fields.CompanyName[this]; set => fields.CompanyName[this] = value; }

    [DisplayName("Address"), Size(60)]
    public string Address { get => fields.Address[this]; set => fields.Address[this] = value; }

    [DisplayName("City"), Size(15)]
    public string City { get => fields.City[this]; set => fields.City[this] = value; }

    [DisplayName("Region"), Size(15)]
    public string Region { get => fields.Region[this]; set => fields.Region[this] = value; }

    [DisplayName("Postal Code"), Size(10)]
    public string PostalCode { get => fields.PostalCode[this]; set => fields.PostalCode[this] = value; }

    [DisplayName("Country"), Size(15)]
    public string Country { get => fields.Country[this]; set => fields.Country[this] = value; }

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
        public StringField CompanyName;
        public StringField Address;
        public StringField City;
        public StringField Region;
        public StringField PostalCode;
        public StringField Country;

    }
}
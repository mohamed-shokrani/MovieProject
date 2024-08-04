using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MovieProject.Northwind;

[ConnectionKey("Northwind"), Module("Northwind"), TableName("SalesInvoice")]
[DisplayName("Sales Invoice"), InstanceName("Sales Invoice")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class SalesInvoiceRow : Row<SalesInvoiceRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Sale Invoice Id"), Identity, IdProperty]
    public int? SaleInvoiceId { get => fields.SaleInvoiceId[this]; set => fields.SaleInvoiceId[this] = value; }

    [DisplayName("Date"), NotNull]
    public DateTime? Date { get => fields.Date[this]; set => fields.Date[this] = value; }

    [DisplayName("Notes"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Notes { get => fields.Notes[this]; set => fields.Notes[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field SaleInvoiceId;
        public DateTimeField Date;
        public StringField Notes;

    }
}
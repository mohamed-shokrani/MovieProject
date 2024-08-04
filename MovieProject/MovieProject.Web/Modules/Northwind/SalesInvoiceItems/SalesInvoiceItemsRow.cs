using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MovieProject.Northwind;

[ConnectionKey("Northwind"), Module("Northwind"), TableName("SalesInvoiceItems")]
[DisplayName("Sales Invoice Items"), InstanceName("Sales Invoice Items")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class SalesInvoiceItemsRow : Row<SalesInvoiceItemsRow.RowFields>, IIdRow, INameRow
{
    const string jSalesInvoice = nameof(jSalesInvoice);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Date"), NotNull]
    public DateTime? Date { get => fields.Date[this]; set => fields.Date[this] = value; }

    [DisplayName("Notes"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Notes { get => fields.Notes[this]; set => fields.Notes[this] = value; }

    [DisplayName("Sales Invoice"), NotNull, ForeignKey(typeof(SalesInvoiceRow)), LeftJoin(jSalesInvoice)]
    [TextualField(nameof(SalesInvoiceNotes)), ServiceLookupEditor(typeof(SalesInvoiceRow))]
    public int? SalesInvoiceId { get => fields.SalesInvoiceId[this]; set => fields.SalesInvoiceId[this] = value; }

    [DisplayName("Sales Invoice Notes"), Origin(jSalesInvoice, nameof(SalesInvoiceRow.Notes))]
    public string SalesInvoiceNotes { get => fields.SalesInvoiceNotes[this]; set => fields.SalesInvoiceNotes[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public DateTimeField Date;
        public StringField Notes;
        public Int32Field SalesInvoiceId;

        public StringField SalesInvoiceNotes;
    }
}
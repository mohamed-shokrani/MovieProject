using FluentMigrator;

namespace MovieProject.Migrations.NorthWind;
[ConnectionKey("Northwind"), Migration(20240804_1405)]

public class Northwind_20240804_1405_SalesInvoice : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("SalesInvoice").WithColumn("SaleInvoiceId").AsInt32().PrimaryKey().NotNullable().Identity()
              .WithColumn("Date").AsDateTime().NotNullable()
              .WithColumn("Notes").AsString(500).NotNullable();


    }
}

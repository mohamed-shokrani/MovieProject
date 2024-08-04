using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MovieProject.Northwind.Columns;

[ColumnsScript("Northwind.Orders")]
[BasedOnRow(typeof(OrdersRow), CheckNames = true)]
public class OrdersColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int OrderId { get; set; }
    [EditLink]
    public string CustomerCompanyName { get; set; }
    public string EmployeeFullName { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime ShippedDate { get; set; }
    public string ShipViaCompanyName { get; set; }
    public decimal Freight { get; set; }
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
    public string ShipRegion { get; set; }
    public string ShipPostalCode { get; set; }
    public string ShipCountry { get; set; }
}
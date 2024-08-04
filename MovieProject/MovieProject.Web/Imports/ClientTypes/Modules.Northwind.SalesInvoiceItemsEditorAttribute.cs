using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieProject.Modules.Northwind;

public partial class SalesInvoiceItemsEditorAttribute : CustomEditorAttribute
{
    public const string Key = "MovieProject.Modules.Northwind.SalesInvoiceItems";

    public SalesInvoiceItemsEditorAttribute()
        : base(Key)
    {
    }
}
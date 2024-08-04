using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieProject.Northwind;

public partial class SalesInvoiceItemsEditorAttribute : CustomEditorAttribute
{
    public const string Key = "MovieProject.Northwind.SalesInvoiceItemsEditor";

    public SalesInvoiceItemsEditorAttribute()
        : base(Key)
    {
    }
}
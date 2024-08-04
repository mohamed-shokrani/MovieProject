using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieProject.Modules;

public partial class SalesInvoiceItemsEditorAttribute : CustomEditorAttribute
{
    public const string Key = "MovieProject.Modules.SalesInvoiceItemsEditor";

    public SalesInvoiceItemsEditorAttribute()
        : base(Key)
    {
    }
}
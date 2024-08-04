using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieProject.Administration;

public partial class RoleCheckEditorAttribute : CustomEditorAttribute
{
    public const string Key = "MovieProject.Administration.RoleCheckEditor";

    public RoleCheckEditorAttribute()
        : base(Key)
    {
    }
}
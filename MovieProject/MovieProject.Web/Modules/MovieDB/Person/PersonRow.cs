﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MovieProject.MovieDB;

[ConnectionKey("Default"), Module("MovieDB"), TableName("Person")]
[DisplayName("Person"), InstanceName("Person")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Person Id"), Identity, IdProperty]
    public int? PersonId { get => fields.PersonId[this]; set => fields.PersonId[this] = value; }

    [DisplayName("First Name"), Size(50), NotNull, QuickSearch, NameProperty]
    public string FirstName { get => fields.FirstName[this]; set => fields.FirstName[this] = value; }

    [DisplayName("Last Name"), Size(50), NotNull]
    public string LastName { get => fields.LastName[this]; set => fields.LastName[this] = value; }

    [DisplayName("Birth Date")]
    public DateTime? BirthDate { get => fields.BirthDate[this]; set => fields.BirthDate[this] = value; }

    [DisplayName("Birth Place"), Size(100)]
    public string BirthPlace { get => fields.BirthPlace[this]; set => fields.BirthPlace[this] = value; }

    [DisplayName("Gender")]
    public int? Gender { get => fields.Gender[this]; set => fields.Gender[this] = value; }

    [DisplayName("Height")]
    public int? Height { get => fields.Height[this]; set => fields.Height[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field PersonId;
        public StringField FirstName;
        public StringField LastName;
        public DateTimeField BirthDate;
        public StringField BirthPlace;
        public Int32Field Gender;
        public Int32Field Height;

    }
}
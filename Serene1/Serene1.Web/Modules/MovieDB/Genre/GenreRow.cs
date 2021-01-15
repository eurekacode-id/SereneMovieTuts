using Newtonsoft.Json;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serene1.MovieDB.Entities
{
    [ConnectionKey("Default"), Module("MovieDB"), TableName("[mov].[Genre]")]
    [DisplayName("Genre"), InstanceName("Genre")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("MovieDB.Genre")]
    public sealed class GenreRow : Row<GenreRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Genre Id"), Identity, IdProperty]
        public Int32? GenreId
        {
            get => fields.GenreId[this];
            set => fields.GenreId[this] = value;
        }

        [DisplayName("Genre Name"), Size(100), NotNull, QuickSearch, NameProperty]
        public String GenreName
        {
            get => fields.GenreName[this];
            set => fields.GenreName[this] = value;
        }

        public GenreRow()
            : base()
        {
        }

        public GenreRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field GenreId;
            public StringField GenreName;
        }
    }
}

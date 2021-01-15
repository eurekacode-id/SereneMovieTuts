using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using Serenity.Data.Mapping;

namespace Serene1.MovieDB.Columns
{
    [ColumnsScript("MovieDB.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow))]
    public class MovieCastColumns
    {
        [EditLink, Width(150)]
        public String Character { get; set; }
        [EditLink, Width(220)]
        public String PersonFullName { get; set; }
    }
}
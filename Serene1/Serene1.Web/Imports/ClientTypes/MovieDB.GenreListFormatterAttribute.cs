using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serene1.MovieDB
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Serene1.MovieDB.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}

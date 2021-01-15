using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serenity.ComponentModel
{
    public partial class MovieCastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serenity.MovieCastEditor";

        public MovieCastEditorAttribute()
            : base(Key)
        {
        }
    }
}

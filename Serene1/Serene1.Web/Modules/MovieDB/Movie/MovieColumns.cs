using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serene1.MovieDB.Columns
{
    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        
        [EditLink, Width(250)]
        public String Title { get; set; }
        
        public String Description { get; set; }
        
        public String Storyline { get; set; }
        
        public Int32 Year { get; set; }

        [DisplayName("Release Date"), DisplayFormat("dd-MMM-yyyy"), Width(100), AlignCenter]
        public DateTime ReleaseDate { get; set; }
        
        public MovieKind Kind { get; set; }

        [Width(200), GenreListFormatter, QuickFilter]
        public List<Int32> GenreList { get; set; }
        
        [DisplayName("Runtime in Minutes"), Width(150), AlignRight]
        public Int32 Runtime { get; set; }
    }
}
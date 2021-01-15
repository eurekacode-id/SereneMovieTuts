using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20210114190600)]
    public class DefaultDB_20210114_190600_SampleGenres : AutoReversingMigration
    {
        public override void Up()
        {
            Insert.IntoTable("Genre").InSchema("mov")
                .Row(new { GenreName = "Action" })
                .Row(new { GenreName = "Sci-Fi" })
                .Row(new { GenreName = "Anime" })
                .Row(new { GenreName = "Family" });
        }
    }
}
using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20210114185300)]
    public class DefaultDB_20210114_185300_GenreTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Genre").InSchema("mov")
                .WithColumn("GenreId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("GenreName").AsString(100).NotNullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("GenreId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId");

        }
    }
}
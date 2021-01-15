using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20210115144800)]
    public class DefaultDB_20210115_144800_PersonMovieImages : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Person").InSchema("mov")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

            Alter.Table("Movie").InSchema("mov")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
        }
    }
}
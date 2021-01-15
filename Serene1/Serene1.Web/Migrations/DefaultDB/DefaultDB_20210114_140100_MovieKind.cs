using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20210114140100)]
    public class DefaultDB_20210114_140100_MovieKind : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                    .WithDefaultValue(1);
        }
    }
}
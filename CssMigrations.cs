using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Contrib.Ace
{
    public class CssMigrations : DataMigrationImpl
    {

        public int Create()
        {
            SchemaBuilder.CreateTable(
                "CssPartRecord",
                table => table
                            .ContentPartRecord()
                            .Column<string>("Css", column => column.Unlimited())
                            );

            ContentDefinitionManager.AlterPartDefinition("CssPart", builder => builder.Attachable());

            ContentDefinitionManager.AlterTypeDefinition("HtmlWidget", 
                cfg => cfg
                    .WithPart("CssPart")
                );

            ContentDefinitionManager.AlterTypeDefinition("Page", 
                cfg => cfg
                    .WithPart("CssPart")
                );

            return 1;
        }
    }
}
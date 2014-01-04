using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Contrib.Ace
{
    public class JsMigrations : DataMigrationImpl
    {

        public int Create()
        {
            SchemaBuilder.CreateTable(
                "JsPartRecord",
                table => table
                            .ContentPartRecord()
                            .Column<string>("Js", column => column.Unlimited())
                            );

            ContentDefinitionManager.AlterPartDefinition("JsPart", builder => builder
                .Attachable()
                .WithDescription("Allows the inline editing of Javascript using Ace editor."));

            ContentDefinitionManager.AlterTypeDefinition("HtmlWidget", 
                cfg => cfg
                    .WithPart("JsPart")
                );

            ContentDefinitionManager.AlterTypeDefinition("Page", 
                cfg => cfg
                    .WithPart("JsPart")
                );

            return 1;
        }
    }
}
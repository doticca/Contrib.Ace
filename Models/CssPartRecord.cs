using Orchard.ContentManagement.Records;
using Orchard.Data.Conventions;

namespace Contrib.Ace.Models
{
    public class CssPartRecord : ContentPartRecord
    {
        [StringLengthMax]
        public virtual string Css { get; set; }
    }
}
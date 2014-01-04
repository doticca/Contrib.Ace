using Orchard.ContentManagement.Records;
using Orchard.Data.Conventions;

namespace Contrib.Ace.Models
{
    public class JsPartRecord : ContentPartRecord
    {
        [StringLengthMax]
        public virtual string Js { get; set; }
    }
}
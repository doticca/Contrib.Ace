using Orchard.ContentManagement;

namespace Contrib.Ace.Models
{
    public class CssPart : ContentPart<CssPartRecord>
    {
        public string Css
        {
            get { return Record.Css; }
            set { Record.Css = value; }
        }
    }
}

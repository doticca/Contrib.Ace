using Orchard.ContentManagement;

namespace Contrib.Ace.Models
{
    public class JsPart : ContentPart<JsPartRecord>
    {
        public string Js
        {
            get { return Record.Js; }
            set { Record.Js = value; }
        }
    }
}

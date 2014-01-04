using System;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Contrib.Ace.Models;

namespace Contrib.Ace.Handlers
{
    public class JsPartHandler : ContentHandler
    {

        public JsPartHandler(IRepository<JsPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}

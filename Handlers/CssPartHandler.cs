using System;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Contrib.Ace.Models;

namespace Contrib.Ace.Handlers
{
    public class CssPartHandler : ContentHandler
    {

        public CssPartHandler(IRepository<CssPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}

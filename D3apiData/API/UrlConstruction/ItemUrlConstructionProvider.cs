﻿using System;
using D3apiData.API.Objects.Item;

namespace D3apiData.API.UrlConstruction
{
    /// <summary>
    /// item url construction
    /// </summary>
    public class ItemUrlConstructionProvider : BasicUrlConstructionProvider, IUrlConstructionProvider
    {
        /// <summary />
        public ItemUrlConstructionProvider(Locales locale) : base(locale)
        {
        }

        /// <summary />
        /// <param name="id"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public string ConstructUrlFromId(ApiId id)
        {
            return base.HostLookup[Locale] + Apihost + Apipath + "data/item/" + Uri.EscapeUriString(id.Id);
        }
    }
}
using System;
using D3apiData.API.Objects.Hero;

namespace D3apiData.API.UrlConstruction
{
    /// <summary>
    /// hero url construction
    /// </summary>
    public class HeroUrlConstructionProvider : BasicUrlConstructionProvider, IUrlConstructionProvider
    {
        /// <summary />
        public HeroUrlConstructionProvider(Locales locale) : base(locale)
        {
        }

        /// <summary />
        /// <param name="id"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public string ConstructUrlFromId(ApiId id)
        {
            return base.HostLookup[Locale] + Apihost + Apipath + "profile/" + Uri.EscapeUriString(id.GetFormattedBattletag() + "/hero/" + id.Id2);
        }
    }
}
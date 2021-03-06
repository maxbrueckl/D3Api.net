using System;

namespace D3ApiDotNet.DataAccess.API.UrlConstruction
{
    /// <summary>
    /// follower url construction
    /// </summary>
    public class FollowerUrlConstructionProvider : BasicUrlConstructionProvider, IUrlConstructionProvider
    {

        /// <summary />
        public FollowerUrlConstructionProvider(Locales locale) : base(locale)
        {
        }

        /// <summary />
        /// <param name="id"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        public string ConstructUrlFromId(ApiId id)
        {
            return base.HostLookup[Locale] + Apihost + Apipath + "data/follower/" + Uri.EscapeUriString(id.Id);
        }
    }
}
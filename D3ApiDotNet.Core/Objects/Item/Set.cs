#region

using System;
using System.Runtime.Serialization;

#endregion

namespace D3ApiDotNet.Core.Objects.Item
{
    /// <summary>
    /// D3ApiServiceExample: Set
    /// </summary>
    [DataContract]
    public class Set : ErrorObject
    {
        /// <summary />
        [DataMember(Name = "slug")]
        public String Slug;

        /// <summary />
        [DataMember(Name = "name")]
        public String Name;

        /// <summary />
        [DataMember(Name = "ranks")]
        public SetRank[] Ranks;

        /// <summary />
        [DataMember(Name = "items")]
        public ItemSummary[] Items;


    }
}
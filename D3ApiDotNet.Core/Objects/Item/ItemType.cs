﻿using System.Runtime.Serialization;

namespace D3ApiDotNet.Core.Objects.Item
{
    /// <summary>
    /// D3ApiServiceExample: ItemType
    /// </summary>
    [DataContract]
    public class ItemType : ErrorObject
    {
        /// <summary />
        [DataMember(Name = "twoHanded")]
        public bool TwoHanded { get; set; }

        /// <summary />
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
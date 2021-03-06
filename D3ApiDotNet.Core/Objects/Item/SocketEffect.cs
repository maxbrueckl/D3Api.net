﻿#region

using System;
using System.Runtime.Serialization;

#endregion

namespace D3ApiDotNet.Core.Objects.Item
{
    /// <summary>
    /// D3ApiServiceExample: SocketEffect
    /// </summary>
    [DataContract]
    public class SocketEffect : ErrorObject
    {
        /// <summary />
        [DataMember(Name = "itemTypeId")]
        public String ItemTypeId;

        /// <summary />
        [DataMember(Name = "itemTypeName")]
        public String ItemTypeName;

        /// <summary />
        [DataMember(Name = "attributesRaw")]
        public ItemAttributes AttributesRaw;

        /// <summary />
        [DataMember(Name = "attributes")]
        public ItemTextAttributes Attributes;
    }
}
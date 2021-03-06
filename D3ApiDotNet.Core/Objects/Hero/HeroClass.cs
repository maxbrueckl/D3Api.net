﻿using System.Runtime.Serialization;

namespace D3ApiDotNet.Core.Objects.Hero
{
    /// <summary>
    /// D3ApiServiceExample: HeroClass enum
    /// </summary>
    [DataContract]
    public enum HeroClass
    {
        /// <summary />
        [EnumMember(Value = "barbarian")] Barbarian,

        /// <summary />
        [EnumMember(Value = "crusader")] Crusader,

        /// <summary />
        [EnumMember(Value = "demon-hunter")] Demonhunter,

        /// <summary />
        [EnumMember(Value = "monk")] Monk,

        /// <summary />
        [EnumMember(Value = "witch-doctor")] Witchdoctor,

        /// <summary />
        [EnumMember(Value = "wizard")] Wizard
    };
}

﻿using System.Collections.Generic;
using System.Linq;
using D3apiData.API.Objects.Item;

namespace D3Calculation.AttributeFetchers
{
    public abstract class BasicAttributeAdditiveFetcher : BasicAttributeFetcher
    {
        public override double GetBonusDamage(IEnumerable<ItemAttributes> attributes)
        {
            return attributes.Select(o => GetBonusDamage(GetBonusDamage((ItemAttributes) o))).Sum();
        }

        protected override double GetBonusDamage(ItemValueRange range)
        {
            return range == null ? 0.0 : range.GetValue();
        }

        public override double GetBonusDamage(IEnumerable<Item> items)
        {
            return GetBonusDamage(items.Select(o => o.AttributesRaw)) + GetBonusDamage(items.SelectMany(o => o.Gems.Select(a => a.AttributesRaw)));
        }
    }
}
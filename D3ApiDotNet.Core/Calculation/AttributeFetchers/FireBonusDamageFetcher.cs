using D3ApiDotNet.Core.Objects.Item;

namespace D3ApiDotNet.Core.Calculation.AttributeFetchers
{
    public class FireBonusDamageFetcher : BasicAttributeAdditiveFetcher
    {
        protected override ItemValueRange GetBonusDamage(ItemAttributes attributes)
        {
            return attributes.damageDealtPercentBonusFire;
        }
    }
}
using D3ApiDotNet.Core.Objects.Item;

namespace D3ApiDotNet.Core.Calculation.AttributeFetchers
{
    public class PercentWeaponDamageFetcher : BasicAttributeAdditiveFetcher
    {
        protected override ItemValueRange GetBonusDamage(ItemAttributes attributes)
        {
            return
                attributes.damageWeaponPercentBonus_Arcane +
                attributes.damageWeaponPercentBonus_Cold +
                attributes.damageWeaponPercentBonus_Fire +
                attributes.damageWeaponPercentBonus_Holy +
                attributes.damageWeaponPercentBonus_Lightning +
                attributes.damageWeaponPercentBonus_Physical +
                attributes.damageWeaponPercentBonus_Poison;
        }
    }
}
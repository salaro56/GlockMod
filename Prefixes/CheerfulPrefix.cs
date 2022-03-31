using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace GlockMod.Prefixes
{
    public class CheerfulPrefix : ModPrefix
    {
        public float modDamageMult = 1.10f;
        public float modKnockbackMult = 1f;
        public int modCritBonus = 2;
        public int modValue = (int)1.1f;
        public int modRare = 1;
        public float modUseTimeMult = 1f;

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Cheerful");
        }

        public override void Apply(Item item)
        {
            item.damage = (int)Math.Round((float)item.damage * modDamageMult);
            item.crit += modCritBonus;
            item.knockBack *= modKnockbackMult;
            item.useAnimation = (int)Math.Round((float)item.useAnimation * modUseTimeMult);
            item.useTime = (int)Math.Round((float)item.useTime * modUseTimeMult);
            item.reuseDelay = (int)Math.Round((float)item.reuseDelay * modUseTimeMult);

            item.value *= modValue;
            item.rare += modRare;
        }
    }
}

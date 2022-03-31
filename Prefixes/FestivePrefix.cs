using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.HJD;
using GlockMod;

namespace GlockMod.Prefixes
{
    class FestivePrefix : ModPrefix
    {
        public float modDamageMult = 1.15f;
        public float modKnockbackMult = 1.15f;
        public int modCritBonus = 5;
        public int modValue = (int)1.3f;
        public int modRare = 2;
        public float modUseTimeMult = 0.9f;

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Festive");
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

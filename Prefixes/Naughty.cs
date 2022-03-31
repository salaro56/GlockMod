using GlockMod.HJD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GlockMod.Prefixes
{
    class Naughty : ModPrefix
    {
        public float modDamageMult = .90f;
        public float modKnockbackMult = .95f;
        public int modCritBonus = -1;
        public int modValue = (int).9f;
        public int modRare = -1;
        public float modUseTimeMult = 1.1f;

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Naughty");
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

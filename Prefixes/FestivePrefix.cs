using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GlockMod.Prefixes
{
    class FestivePrefix : ModPrefix
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Festive");
        }

        public override void Apply(Item item)
        {
            item.damage = (int)(item.damage * 1.15f);
            item.crit += 15;
            item.knockBack *= 1.15f;
        }
    }
}

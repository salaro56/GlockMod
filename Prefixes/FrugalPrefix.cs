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
    class FrugalPrefix : ModPrefix
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Frugal");
        }

        public override void Apply(Item item)
        {
            item.damage = (int)(item.damage * 0.95f);
            item.crit += 5;
        }
    }
}

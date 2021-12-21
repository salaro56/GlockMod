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
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Cheerful");
        }

        public override void Apply(Item item)
        {
            item.damage = (int)(item.damage * 1.05f);
        }
    }
}

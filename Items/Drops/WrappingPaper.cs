using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GlockMod.Items.Drops
{
    class WrappingPaper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wrapping Paper");
            Tooltip.SetDefault("Wrap all kinds of things with this!");
        }

        public override void SetDefaults()
        {
            item.height = 32;
            item.width = 32;
            item.value = Item.sellPrice(0, 0, 6, 25);
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
        }
    }
}

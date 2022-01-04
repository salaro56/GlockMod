using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GlockMod.Items.Drops
{
    class chestnut : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chestnut");
        }

        public override void SetDefaults()
        {
            //item configs
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 0, 10);
            item.rare = ItemRarityID.Blue;
        }
    }
}

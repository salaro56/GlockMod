using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Terraria.DataStructures;
using System.Drawing;

namespace GlockMod.Items.Drops
{
    class ChristmasCheer : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Christmas Cheer");
            Tooltip.SetDefault("Time for that holiday spirit!");

            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 6));
            ItemID.Sets.AnimatesAsSoul[item.type] = false;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
        public override void SetDefaults()
        {
            //item configs
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 0, 5);
            item.rare = ItemRarityID.White;
        }
    }
}

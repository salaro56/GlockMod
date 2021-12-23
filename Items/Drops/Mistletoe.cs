using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace GlockMod.Items.Drops
{
    class Mistletoe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mistletoe");
            Tooltip.SetDefault("I didn't know Planterra grew berries");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 27;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 12, 0, 0);
            item.rare = ItemRarityID.Lime;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, .88f, .34f, .13f);
        }
    }
}

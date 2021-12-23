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
    class SilverBell : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Bells");
            Tooltip.SetDefault("Silent night, holy night");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 40, 0, 0);
            item.rare = ItemRarityID.Red;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, 1, 1, 1);
        }
    }
}

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
    class StarB : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star of Bethlehem");
            Tooltip.SetDefault("Follow the North Star to your next mark");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = ItemRarityID.Cyan;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, .88f, .34f, .13f);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentNebula, 5);
            recipe.AddIngredient(ItemID.FragmentSolar, 5);
            recipe.AddIngredient(ItemID.FragmentStardust, 5);
            recipe.AddIngredient(ItemID.FragmentVortex, 5);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

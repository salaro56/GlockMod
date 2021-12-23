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
    class GlockAttachments : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glock Attachments");
            Tooltip.SetDefault("I don't see how this is related to Christmas anymore");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = ItemRarityID.LightPurple;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, .88f, .34f, .13f);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<GlockSights>());
            recipe.AddIngredient(ModContent.ItemType<GlockAmmoBelt>());
            recipe.AddIngredient(ModContent.ItemType<GlockLaser>());
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    class GlockSights : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glock Sights");
            Tooltip.SetDefault("Which one of the Twins did you take this from?");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = ItemRarityID.Pink;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, .88f, .34f, .13f);
        }
    }

    class GlockAmmoBelt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ammo Belt");
            Tooltip.SetDefault("The Destroyer is like one big ammo belt right?");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = ItemRarityID.Pink;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, .88f, .34f, .13f);
        }
    }

    class GlockLaser : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Laser Sight");
            Tooltip.SetDefault("Perfect for keeping your cats away from the Christmas Tree");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = ItemRarityID.Pink;
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Lighting.AddLight(item.position, .88f, .34f, .13f);
        }
    }
}



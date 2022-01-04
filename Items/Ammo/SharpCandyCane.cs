using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.HJD;
using GlockMod.Projectiles.Friendly;

namespace GlockMod.Items.Ammo
{
    class SharpCandyCane : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sharpened Candy Cane");
            Tooltip.SetDefault("Sharpness not included");
        }

        public override void SafeSetDefaults()
        {
            item.damage = 5;
            item.width = 20;
            item.height = 26;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1f;
            item.value = Item.buyPrice(0, 0, 0, 15);
            item.rare = ItemRarityID.Green;
            item.shoot = ModContent.ProjectileType<candyCaneProj>();
            item.shootSpeed = 8f;
            item.ammo = ModContent.ItemType<GlintRound>();
            item.consumable = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<GlintRound>(), 70);
            recipe.AddIngredient(ItemID.CandyCaneBlock, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

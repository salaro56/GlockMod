using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.Projectiles;
using GlockMod.HJD;
using GlockMod.Items.Drops;

namespace GlockMod.Items.Craftables
{
    class SantaSnowglobe : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Snowglobe");
            Tooltip.SetDefault("The comfort of Santa in a single snowglobe!");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.Shuriken);
            //item stats
            item.value = Item.buyPrice(0, 0, 0, 50);
            item.rare = ItemRarityID.White;
            item.damage = 2;
            item.crit = 0;
            //item configs
            item.width = 26;
            item.height = 26;
            item.consumable = true;
            item.shoot = ModContent.ProjectileType<Projectiles.SantaSnowglobe>();
            item.maxStack = 99;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 1);
            recipe.AddIngredient(ItemID.Glass, 5);
            recipe.AddIngredient(ItemID.SnowBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

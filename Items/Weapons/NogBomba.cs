using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.HJD;
using GlockMod.Projectiles.Friendly.Explosives;
using GlockMod.Items.Drops;

namespace GlockMod.Items.Weapons
{
    class NogBomba : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nog Bomba");
            Tooltip.SetDefault("Everyone is weak when it comes to Eggnog");
        }

        public override void SafeSetDefaults()
        {
            //item stats
            item.damage = 50;
            item.knockBack = 10;
            item.crit = 8;
            item.value = Item.buyPrice(0, 0, 10, 0);
            //item configs
            item.CloneDefaults(ItemID.Grenade);
            item.width = 18;
            item.height = 28;
            item.shoot = ModContent.ProjectileType<nogGrenade>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Eggnog);
            recipe.AddIngredient(ItemID.Grenade, 10);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}

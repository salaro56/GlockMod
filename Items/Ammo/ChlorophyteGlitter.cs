using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.HJD;
using GlockMod.Projectiles;

namespace GlockMod.Items.Ammo
{
    class ChlorophyteGlitter : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Glitter");
        }

        public override void SafeSetDefaults()
        {
            //item stats
            item.width = 7;
            item.height = 15;
            item.knockBack = 1.5f;
            item.value = Item.buyPrice(0, 0, 20, 0);
            item.shootSpeed = 16f;
            item.damage = 16;

            //item configs
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Lime;
            item.ammo = ModContent.ItemType<GlintRound>();
            item.shoot = ModContent.ProjectileType<chlorophyteGlitter>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<GlintRound>(), 70);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
            recipe.SetResult(this, 70);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddRecipe();
        }
    }
}

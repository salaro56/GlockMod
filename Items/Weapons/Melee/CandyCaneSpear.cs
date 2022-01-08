using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.HJD;
using GlockMod.Projectiles.Friendly.Spears;
using GlockMod.Items.Drops;

namespace GlockMod.Items.Weapons.Melee
{
    class CandyCaneSpear : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Candy Cane Spear");
            Tooltip.SetDefault("Licked to sharpened perfection");
        }

        public override void SafeSetDefaults()
        {
            //item stats
            item.damage = 30;
            item.shootSpeed = 3.7f;
            item.knockBack = 6.5f;
            item.rare = ItemRarityID.Orange;
            item.value = Item.sellPrice(gold: 2);
            //item configs
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useAnimation = 18;
            item.useAnimation = 24;
            item.width = 56;
            item.height = 68;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.shoot = ModContent.ProjectileType<caneSpear>();
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Present, 10);
            recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

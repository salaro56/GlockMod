using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlockMod.HJD;
using GlockMod.Projectiles.Friendly;
using Microsoft.Xna.Framework;
using GlockMod.Items.Drops;

namespace GlockMod.Items.Weapons.Ranged
{
    class ChippedGingerbread : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chipped Gingerbread Cookie");
            Tooltip.SetDefault("You're a monster");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.WoodenBoomerang);
            //item stats
            item.damage = 12;
            item.knockBack = 4;
            item.crit = 4;
            item.value = Item.sellPrice(0, 0, 10, 50);
            item.rare = ItemRarityID.Blue;
            item.shoot = ModContent.ProjectileType<gingerbread>();
            item.shootSpeed = 8f;

            //item configs
            item.width = 26;
            item.height = 32;
            item.useAnimation = 15;
            item.useTime = 15;
            item.autoReuse = false;
            item.UseSound = SoundID.Item7;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.maxStack = 5;
            item.consumable = false;
            item.useStyle = ItemUseStyleID.SwingThrow;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.ownedProjectileCounts[ModContent.ProjectileType<gingerbread>()] < item.stack)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 5);
            recipe.AddIngredient(ItemID.GingerbreadCookie);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

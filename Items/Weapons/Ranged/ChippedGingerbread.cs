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
            item.damage = 16;
            item.knockBack = 4;
            item.crit = 6;
            item.value = Item.sellPrice(0, 0, 3, 50);
            item.rare = ItemRarityID.Blue;
            item.shoot = ModContent.ProjectileType<gingerbread>();
            item.shootSpeed = 10f;

            //item configs
            item.width = 26;
            item.height = 32;
            item.useAnimation = 8;
            item.useTime = 8;
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
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

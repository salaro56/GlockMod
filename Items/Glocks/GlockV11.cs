using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlockMod.Projectiles;
using GlockMod.HJD;
using GlockMod.Items.Drops;
using Terraria.Utilities;
using GlockMod.Items.Ammo;

namespace GlockMod.Items.Glocks
{
    public class GlockV11 : HollyJollyItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Glock V.11");
            Tooltip.SetDefault("Aim for the tree tops");
        }

        public override void SafeSetDefaults()
        {
            // item stats
            item.damage = 82;
            item.useTime = 10;
            item.useAnimation = 10;
            item.value = Item.buyPrice(0, 25, 0, 0);
            item.shootSpeed = 20f;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.useAmmo = ModContent.ItemType<GlintRound>();
            item.crit = 22;

            // item configs
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.knockBack = 1f;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.rare = ItemRarityID.Red;
            item.autoReuse = true;
            item.UseSound = SoundID.Item27;
        }

        public override bool ConsumeAmmo(Player p) //Tells the game whether the item consumes ammo or not
        {
            if (Main.rand.NextFloat() < .40f)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 5);
            recipe.AddIngredient(ItemID.FragmentVortex, 5);
            recipe.AddIngredient(ModContent.ItemType<StarB>());
            recipe.AddIngredient(ModContent.ItemType<GlockV10>());
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
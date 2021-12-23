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
    public class GlockV10 : HollyJollyItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Glock V.10");
            Tooltip.SetDefault("Throwing hands this year instead of snow");
        }

        public override void SafeSetDefaults()
        {
            // item stats
            item.damage = 69;
            item.useTime = 12;
            item.useAnimation = 12;
            item.value = Item.buyPrice(0, 22, 50, 0);
            item.shootSpeed = 18f;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.useAmmo = ModContent.ItemType<GlintRound>();
            item.crit = 20;

            // item configs
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.knockBack = 1f;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.rare = ItemRarityID.Cyan;
            item.autoReuse = true;
            item.UseSound = SoundID.Item27;
        }

        public override bool ConsumeAmmo(Player p) //Tells the game whether the item consumes ammo or not
        {
            if (Main.rand.NextFloat() < .30f)
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
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddIngredient(ModContent.ItemType<KnittedMittens>());
            recipe.AddIngredient(ModContent.ItemType<GlockV9>());
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
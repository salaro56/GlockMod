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
    public class GlockV8 : HollyJollyItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Glock V.8");
            Tooltip.SetDefault("Right in the kisser");
        }

        public override void SafeSetDefaults()
        {
            // item stats
            item.damage = 58;
            item.useTime = 14;
            item.useAnimation = 14;
            item.value = Item.buyPrice(0, 12, 20, 0);
            item.shootSpeed = 16f;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.useAmmo = ModContent.ItemType<GlintRound>();
            item.crit = 18;

            // item configs
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.knockBack = 1f;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.rare = ItemRarityID.Lime;
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
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 5);
            recipe.AddIngredient(ModContent.ItemType<Mistletoe>());
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddIngredient(ModContent.ItemType<GlockV7>());
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
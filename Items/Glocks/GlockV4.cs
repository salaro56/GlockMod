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
    public class GlockV4 : HollyJollyItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Glock V.4");
            Tooltip.SetDefault("Float like a reindeer," +
                "\nsting like a giant queen bee");
        }

        public override void SafeSetDefaults()
        {
            // item stats
            item.damage = 22;
            item.useTime = 17;
            item.useAnimation = 17;
            item.value = Item.buyPrice(0, 0, 10, 50);
            item.shootSpeed = 12f;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.useAmmo = ModContent.ItemType<GlintRound>();
            item.crit = 12;

            // item configs
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.knockBack = 1f;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.rare = ItemRarityID.Green;
            item.autoReuse = false;
            item.UseSound = SoundID.Item27;
        }

        public override bool ConsumeAmmo(Player p) //Tells the game whether the item consumes ammo or not
        {
            if (Main.rand.Next(2) == 1)
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
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddIngredient(ModContent.ItemType<ChristmasWallet>());
            recipe.AddIngredient(ModContent.ItemType<GlockV3>());
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
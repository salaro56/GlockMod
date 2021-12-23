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
    public class GlockV9 : HollyJollyItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Glock V.9");
            Tooltip.SetDefault("The fire looks so delightful");
        }

        public override void SafeSetDefaults()
        {
            // item stats
            item.damage = 65;
            item.useTime = 14;
            item.useAnimation = 14;
            item.value = Item.buyPrice(0, 20, 0, 0);
            item.shootSpeed = 18f;
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
            item.rare = ItemRarityID.Yellow;
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
            recipe.AddIngredient(ItemID.BeetleHusk, 2);
            recipe.AddIngredient(ModContent.ItemType<FireSticker>());
            recipe.AddIngredient(ModContent.ItemType<GlockV8>());
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
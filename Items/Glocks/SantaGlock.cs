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
    public class SantaGlock : HollyJollyItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Holly Jolly Santa Glock");
            Tooltip.SetDefault("Up on the rooftop" +
                "\nClick" +
                "\nClick" +
                "\nBANG");
        }

        public override void SafeSetDefaults()
        {
            // item stats
            item.damage = 110;
            item.useTime = 12;
            item.useAnimation = 12;
            item.value = Item.buyPrice(0, 69, 0, 0);
            item.shootSpeed = 10f;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.useAmmo = ModContent.ItemType<GlintRound>();

            // item configs
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.knockBack = 4f;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.rare = ItemRarityID.White;
            item.autoReuse = true;
            item.UseSound = SoundID.Item27;
        }

        public override bool AllowPrefix(int pre)
        {
            return true;
        }

        public override bool? PrefixChance(int pre, UnifiedRandom rand)
        {
            pre = -1;
            if(pre == -1)
            {
                return true;
            }
            else if(pre == 3)
            {
                return true;
            }
            else
            {
                return true;
            }
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
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddRecipeGroup("IronBar", 10);
            recipe.AddIngredient(ItemID.Coal, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
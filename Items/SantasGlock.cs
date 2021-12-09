using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlockMod.Projectiles;

namespace GlockMod.Items
{
    public class SantasGlock : ModItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Glock");
            Tooltip.SetDefault("Looks like the naughty kids are getting lead this year");
        }

        public override void SetDefaults()
        {
            item.damage = 69;
            item.ranged = true;
            item.width = 60;
            item.height = 60;
            item.maxStack = 1;
            item.useTime = 12;
            item.useAnimation = 12;
            item.knockBack = 1f;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.value = Item.buyPrice(0,12,25,0);
            item.rare = ItemRarityID.Cyan;
            item.shootSpeed = 10f;
            item.autoReuse = true;
            item.UseSound = SoundID.Item27;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.useAmmo = AmmoID.Bullet;
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
            recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlockMod.Projectiles;

namespace GlockMod.Items
{

    public class GlintRound : ModItem
    {

        public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Glint Round");
            Tooltip.SetDefault("Fills you with cheer! And holes");
        }
    
        public override void SetDefaults()
        {
            item.damage = 31;
            item.ranged = true;
            item.width = 15;
            item.height = 15;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1f;
            item.value = 50;
            item.rare = 2;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.shootSpeed = 10f;
            item.ammo = AmmoID.Bullet;
            item.consumable = true;
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

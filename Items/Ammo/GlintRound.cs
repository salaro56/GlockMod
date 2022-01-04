using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlockMod.Projectiles;
using GlockMod.HJD;
using GlockMod.Items.Drops;

namespace GlockMod.Items.Ammo
{

    public class GlintRound : HollyJollyItem
    {

        public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Glint Round");
            Tooltip.SetDefault("Fills you with cheer! And holes");
        }
    
        public override void SafeSetDefaults()
        {
            item.damage = 8;
            item.width = 7;
            item.height = 15;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1f;
            item.value = Item.buyPrice(0,0,0,10);
            item.rare = ItemRarityID.White;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.shootSpeed = 10f;
            item.ammo = item.type;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 5);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }
}

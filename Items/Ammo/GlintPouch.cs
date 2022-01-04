using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlockMod.Projectiles;
using GlockMod.HJD;
using GlockMod.Items.Drops;

namespace GlockMod.Items.Ammo
{

    public class GlintPouch : HollyJollyItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Glint Pouch");
            Tooltip.SetDefault("Endless Christmas Cheer");
        }

        public override void SafeSetDefaults()
        {
            item.damage = 8;
            item.width = 26;
            item.height = 34;
            item.maxStack = 1;
            item.consumable = false;
            item.knockBack = 1f;
            item.value = Item.buyPrice(39960);
            item.rare = ItemRarityID.Green;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.shootSpeed = 10f;
            item.ammo = ModContent.ItemType<GlintRound>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<GlintRound>(), 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

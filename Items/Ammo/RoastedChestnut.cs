using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlockMod.Projectiles;
using GlockMod.HJD;
using GlockMod.Items.Drops;
using GlockMod.Projectiles.Friendly;

namespace GlockMod.Items.Ammo
{

    public class RoastedChestnut : HollyJollyItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Roasted Chestnut");
            Tooltip.SetDefault("Who knew they made such good bullets?");
        }

        public override void SafeSetDefaults()
        {
            item.damage = 5;
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2f;
            item.value = Item.buyPrice(0, 0, 0, 18);
            item.rare = ItemRarityID.Green;
            item.shoot = ModContent.ProjectileType<chestnutProj>();
            item.shootSpeed = 10f;
            item.ammo = ModContent.ItemType<GlintRound>();
            item.consumable = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<chestnut>());
            recipe.AddIngredient(ModContent.ItemType<GlintRound>(), 70);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 70);
            recipe.AddRecipe();
        }
    }
}

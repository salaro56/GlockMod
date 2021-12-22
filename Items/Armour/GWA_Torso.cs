using GlockMod.HJD;
using GlockMod.Items.Drops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GlockMod.Items.Armour
{
    [AutoloadEquip(EquipType.Body)]
    class GWA_Torso : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Gift Wrapped Breastplate");
            Tooltip.SetDefault("It's you, you're the gift" +
                "\n2% increased Holly Jolly");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 18;
            item.value = Item.buyPrice(0, 0, 5, 0);
            item.defense = 4;
            item.rare = ItemRarityID.Blue;
        }

        public override void UpdateEquip(Player player)
        {
            DamagePlayer modPlayer = DamagePlayer.ModPlayer(player);
            modPlayer.hjdDamageMult *= 1.02f; 
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 15);
            recipe.AddIngredient(ModContent.ItemType<WrappingPaper>(), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

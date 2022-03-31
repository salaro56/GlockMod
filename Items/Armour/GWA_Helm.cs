using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.HJD;
using GlockMod.Items.Drops;

namespace GlockMod.Items.Armour
{
    [AutoloadEquip(EquipType.Head)]
    class GWA_Helm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gift Wrapped Helmet");
            Tooltip.SetDefault("2% increased Holly Jolly");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.value = Item.buyPrice(0, 0, 2, 50);
            item.rare = ItemRarityID.Blue;
            item.defense = 2;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<GWA_Torso>() && legs.type == ModContent.ItemType<GWA_Legs>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "2 defense";
            player.statDefense += 2;
        }

        public override void UpdateEquip(Player player)
        {
            DamagePlayer modPlayer = DamagePlayer.ModPlayer(player);
            modPlayer.modDamageMult *= 1.02f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddIngredient(ModContent.ItemType<WrappingPaper>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

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
            modPlayer.modDamageMult *= 1.02f;
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

    [AutoloadEquip(EquipType.Legs)]
    class GWA_Legs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gift Wrapped Leggings");
            Tooltip.SetDefault("4% increased movement speed");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.value = Item.buyPrice(0, 0, 3, 0);
            item.rare = ItemRarityID.Blue;
            item.defense = 3;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.04f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 12);
            recipe.AddIngredient(ModContent.ItemType<WrappingPaper>(), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

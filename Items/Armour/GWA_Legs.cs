﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.Items.Drops;

namespace GlockMod.Items.Armour
{
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
            player.moveSpeed += 0.04f;
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
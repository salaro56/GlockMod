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
    [AutoloadEquip(EquipType.Head)]
    class WorkerElfHat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Worker Elf's Hat");
            Tooltip.SetDefault("6% increased Holly Jolly" +
                "\n10% increased critical strike chance");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.rare = ItemRarityID.Blue;
            item.defense = 5;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<WorkerElfLeggings>() && legs.type == ModContent.ItemType<WorkerElfTunic>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "4% increased health regen";
            player.lifeRegen *= (int)1.04f;

        }

        public override void UpdateEquip(Player player)
        {
            DamagePlayer modPlayer = DamagePlayer.ModPlayer(player);
            modPlayer.modDamageMult *= 1.06f;
            modPlayer.modCritBonus *= (int)1.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 10);
            recipe.AddIngredient(ItemID.ShadowScale, 15);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 10);
            recipe.AddIngredient(ItemID.TissueSample, 15);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Legs)]
    class WorkerElfLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Worker Elf's Leggings");
            Tooltip.SetDefault("6% increased Holly Jolly");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.rare = ItemRarityID.Blue;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            DamagePlayer modPlayer = DamagePlayer.ModPlayer(player);
            modPlayer.modDamageMult *= 1.06f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 12);
            recipe.AddIngredient(ItemID.ShadowScale, 18);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 12);
            recipe.AddIngredient(ItemID.TissueSample, 18);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Body)]
    class WorkerElfTunic : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Worker Elf Tunic");
            Tooltip.SetDefault("You've got more than toys to make" +
                "\n6% increased Holly Jolly");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 18;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.defense = 5;
            item.rare = ItemRarityID.Blue;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
        }

        public override void UpdateEquip(Player player)
        {
            DamagePlayer modPlayer = DamagePlayer.ModPlayer(player);
            modPlayer.modDamageMult *= 1.06f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
            recipe.AddIngredient(ItemID.ShadowScale, 20);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 15);
            recipe.AddIngredient(ItemID.TissueSample, 20);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 10);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

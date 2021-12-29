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

namespace GlockMod.Items.Weapons.Ranged
{
    class GiftBow : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gift Bow");
            Tooltip.SetDefault("Not the kind you put on top of a gift");
        }

        public override void SafeSetDefaults()
        {
            item.width = 16;
            item.height = 32;
            item.shoot = ProjectileID.WoodenArrowFriendly;
            item.damage = 22;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 14f;
            item.autoReuse = true;
            item.knockBack = 3;
            item.crit = 5;
            item.UseSound = SoundID.Item5;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.rare = ItemRarityID.Blue;
            item.useTurn = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.maxStack = 1;
            item.useStyle = ItemUseStyleID.HoldingOut;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CandyCaneBlock, 15);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 5);
            recipe.AddIngredient(ItemID.ShadowScale, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CandyCaneBlock, 15);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 5);
            recipe.AddIngredient(ItemID.TissueSample, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

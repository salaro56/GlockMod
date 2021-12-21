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

namespace GlockMod.Items.Weapons
{
    class WrappingTube : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Empty Wrapping Paper Tube");
            Tooltip.SetDefault("I don't care how old you are this is always fun");
        }

        public override void SafeSetDefaults()
        {
            //item stats
            item.autoReuse = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.rare = ItemRarityID.White;
            item.damage = 7;
            item.knockBack = 0.4f;
            item.value = Item.buyPrice(0, 0, 0, 20);
            item.UseSound = SoundID.Item1;

            //item configs
            item.height = 64;
            item.width = 64;
            item.maxStack = 1;
            item.useTurn = false;
            item.useStyle = ItemUseStyleID.SwingThrow;
        }

        public override void OnHitNPC(Player player, Terraria.NPC target, int damage, float knockBack, bool crit)
        {
            if(Main.rand.Next(0,25) == 1)
            {
                target.AddBuff(BuffID.Confused, 20);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ChristmasCheer>(), 5);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

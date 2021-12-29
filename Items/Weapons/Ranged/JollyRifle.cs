using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GlockMod.Projectiles;
using GlockMod.HJD;
using GlockMod.Items.Drops;
using Terraria.Utilities;
using GlockMod.Items.Ammo;

namespace GlockMod.Items.Weapons.Ranged
{
    public class JollyRifle : HollyJollyItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jolly Rifle");
            Tooltip.SetDefault("We're hunting big game");
        }

        public override void SafeSetDefaults()
        {
            // item stats
            item.damage = 38;
            item.useTime = 12;
            item.useAnimation = 12;
            item.reuseDelay = 20;
            item.value = Item.buyPrice(0, 5, 50, 0);
            item.shootSpeed = 30f;
            item.shoot = ModContent.ProjectileType<glintround>();
            item.useAmmo = ModContent.ItemType<GlintRound>();
            item.crit = 10;

            // item configs
            item.width = 62;
            item.height = 24;
            item.maxStack = 1;
            item.knockBack = 5f;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.rare = ItemRarityID.Orange;
            item.autoReuse = false;
            item.UseSound = SoundID.Item27;
        }

        public override Vector2? HoldoutOffset()
        {
            return (new Vector2(item.position.X - 3, item.position.Y));
        }

        public override bool ConsumeAmmo(Player p) //Tells the game whether the item consumes ammo or not
        {
            if (Main.rand.Next(10) == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
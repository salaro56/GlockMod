using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.HJD;

namespace GlockMod.Items.Weapons
{
    class FragileOrnament : HollyJollyItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fragile Ornament");
            Tooltip.SetDefault("It IS made of glass afterall");
        }

        public override void SafeSetDefaults()
        {
            item.CloneDefaults(ItemID.ThrowingKnife);
            //item stats
            item.damage = 8;
            item.crit = 2;
            item.value = Item.buyPrice(0, 0, 0, 10);
            item.rare = ItemRarityID.White;

            //item configs
            item.width = 20;
            item.height = 30;
            item.maxStack = 999;
            item.consumable = true;
            item.shoot = ProjectileID.OrnamentFriendly;
        }
    }
}

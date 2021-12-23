using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.HJD;

namespace GlockMod.Items.Accessories
{
    class SaintEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Saint's Emblem");
            Tooltip.SetDefault("15% increased Holly Jolly");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.accessory = true;
            item.rare = ItemRarityID.LightRed;
            item.value = Item.sellPrice(0, 0, 2, 0);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            DamagePlayer modPlayer = DamagePlayer.ModPlayer(player);
            modPlayer.hjdDamageMult *= 1.15f;
        }
    }
}

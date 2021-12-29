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
    [AutoloadEquip(EquipType.Face)]
    public class SantaBeard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Beard");
            Tooltip.SetDefault("Still smells like milk and cookies" +
                "\n5% increased Holly Jolly");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 28;
            item.accessory = true;
            item.rare = ItemRarityID.Green;
            item.value = Item.sellPrice(0, 0, 3, 20);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            DamagePlayer modPlayer = DamagePlayer.ModPlayer(player);
            modPlayer.hjdDamageMult *= 1.05f;
        }
    }
}

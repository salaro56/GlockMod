using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.Items.Accessories;

namespace GlockMod
{
    class MyGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if(item.type == ItemID.Coal)
            {
                item.maxStack = 999;
            }
        }

        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag && Main.rand.NextFloat() < .5f)
            {
                player.QuickSpawnItem(ModContent.ItemType<SaintEmblem>());
            }
        }
    }
}

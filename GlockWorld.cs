using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.IO;
using GlockMod.Items.Weapons.Ranged;

namespace GlockMod
{
    class GlockWorld : ModWorld
    {
        public override void PostWorldGen()
        {
            int[] itemsToPlaceInLockedChests = { ModContent.ItemType<JollyRifle>() };
            int itemsToPlaceInLockedChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 2 * 36)
                {
                    if (Main.rand.NextFloat() < .15f)
                    {
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        {
                            if (chest.item[inventoryIndex].type == ItemID.None)
                            {
                                chest.item[inventoryIndex].SetDefaults(itemsToPlaceInLockedChests[itemsToPlaceInLockedChestsChoice]);
                                itemsToPlaceInLockedChestsChoice = (itemsToPlaceInLockedChestsChoice + 1) % itemsToPlaceInLockedChests.Length;
                                // Alternate approach: Random instead of cyclical: chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInIceChests));
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}

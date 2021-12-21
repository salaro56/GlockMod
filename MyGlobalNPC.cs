using GlockMod.Items.Ammo;
using GlockMod.Items.Drops;
using GlockMod.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GlockMod
{
    public class MyGlobalNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:
                {
                        if(Main.hardMode == true)
                        {

                        }
                        else
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<FragileOrnament>());
                            nextSlot++;
                        }

                        break;
                }

                case NPCID.ArmsDealer:
                    {
                        if(Main.hardMode == true)
                        {

                        }
                        else
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<GlintRound>());
                            nextSlot++;
                        }
                        break;
                    }
            }
        }

        public override void NPCLoot(Terraria.NPC npc)
        {
            if (npc.type == NPCID.PresentMimic && Main.rand.NextFloat() < .50f)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Present);
            }
            else if (npc.type == NPCID.SnowmanGangsta)
            {
                if(Main.rand.NextFloat() < .35f)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Present);
                }
                else if(Main.rand.NextFloat() < .01f)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ToySled);
                }

            }
            else if (npc.type == NPCID.MisterStabby)
            {
                if (Main.rand.NextFloat() < .35f)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Present);
                }
                else if (Main.rand.NextFloat() < .01f)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ToySled);
                }

            }
        }
    }
}

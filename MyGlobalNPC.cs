﻿using GlockMod.Items.Ammo;
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

                        if(NPC.downedBoss1 == true)
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<WrappingPaper>());
                            nextSlot++;
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<FragileOrnament>());
                            nextSlot++;
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

            if (npc.type == NPCID.EyeofCthulhu)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<NaughtyList>());
            }
            else if (npc.boss && System.Array.IndexOf(new int[] { NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail }, npc.type) > -1)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<CoalInfusedLead>());
            }
            else if(npc.type == NPCID.QueenBee)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<ChristmasWallet>());
            }
            else if(npc.type == NPCID.SkeletronHead)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<EnhancedGrip>());
            }
            else if(npc.type == NPCID.WallofFlesh)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<GiftWrapping>());
            }
        }
    }
}

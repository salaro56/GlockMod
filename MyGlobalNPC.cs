using GlockMod.Items.Accessories;
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
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<FragileOrnament>());
                        nextSlot++;
                        if (NPC.downedBoss1 == true)
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<WrappingPaper>());
                            nextSlot++;
                        }
                        break;
                }

                case NPCID.ArmsDealer:
                    {
                        shop.item[nextSlot].SetDefaults(ModContent.ItemType<GlintRound>());
                        nextSlot++;
                        if(NPC.downedPlantBoss == true)
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<ChlorophyteGlitter>());
                            nextSlot++;
                        }
                        if(Main.hardMode == true)
                        {
                            shop.item[nextSlot].SetDefaults(ModContent.ItemType<RoastedChestnut>());
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
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<NaughtyList>(), 1, true);
            }
            else if (npc.boss && System.Array.IndexOf(new int[] { NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail }, npc.type) > -1)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<CoalInfusedLead>(), 1, true);
            }
            else if (npc.type == NPCID.QueenBee)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<ChristmasWallet>(), 1, true);
            }
            else if (npc.type == NPCID.SkeletronHead)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<EnhancedGrip>(), 1, true);
            }
            else if (npc.type == NPCID.WallofFlesh)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<GiftWrapping>(), 1, true);
            }
            else if (npc.type == NPCID.Retinazer && !NPC.AnyNPCs(NPCID.Spazmatism) || npc.type == NPCID.Spazmatism && !NPC.AnyNPCs(NPCID.Retinazer))
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<GlockSights>(), 1, true);
            }
            else if (npc.type == NPCID.TheDestroyer)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<GlockAmmoBelt>(), 1, true);
            }
            else if (npc.type == NPCID.SkeletronPrime)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<GlockLaser>(), 1, true);
            }
            else if (npc.type == NPCID.Plantera)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<Mistletoe>(), 1, true);
            }
            else if (npc.type == NPCID.Golem)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<FireSticker>(), 1, true);
            }
            else if (npc.type == NPCID.CultistBoss)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<KnittedMittens>(), 1, true);
            }
            else if (npc.type == NPCID.MoonLordCore)
            {
                npc.DropItemInstanced(npc.position, npc.Size, ModContent.ItemType<SilverBell>(), 1, true);
            }

            if (npc.type == NPCID.WallofFlesh && Main.rand.NextFloat() < .50f && Main.expertMode == false)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SaintEmblem>());
            }

            if(npc.type == NPCID.ManEater && Main.rand.NextFloat() < 60f)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<chestnut>());
            }
            if (npc.type == NPCID.Snatcher && Main.rand.NextFloat() < 60f)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<chestnut>());
            }
            if (npc.type == NPCID.AngryTrapper && Main.rand.NextFloat() < 60f)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<chestnut>());
            }
        }
    }
}

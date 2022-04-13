using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.Items.Drops;

namespace GlockMod.NPCs.Mobs
{
    class ChopSanta : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chop Santa");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.SantaClaus];
        }

        public override void SetDefaults()
        {
            npc.height = 42;
            npc.width = 56;
            npc.damage = 100;
            npc.defense = 40;
            npc.lifeMax = 500;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = Item.buyPrice(0,0,10,0);
            npc.knockBackResist = 2f;
            npc.aiStyle = 3;
            aiType = NPCID.Butcher;
            animationType = NPCID.SantaClaus;
        }

        public override void NPCLoot()
        {
            if(Main.rand.NextFloat() <= .1f)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<ChristmasCheer>(), 5);
            }
            else if(Main.rand.NextFloat() <= .35f)
            {
                Item.NewItem(npc.getRect(), ItemID.Coal);
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if(!Main.dayTime && Main.hardMode && spawnInfo.player.ZoneOverworldHeight)
            {
                return .05f;
            }
            else
            {
                return 0f;
            }
        }
    }
}

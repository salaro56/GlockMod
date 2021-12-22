using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.Items.Accessories;

namespace GlockMod.NPCs.Mobs
{
    class MallSanta : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mall Santa");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.SantaClaus];
        }

        public override void SetDefaults()
        {
            npc.height = 42;
            npc.width = 56;
            npc.damage = 30;
            npc.defense = 12;
            npc.lifeMax = 140;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 3000f;
            npc.knockBackResist = 0.6f;
            npc.aiStyle = 3;
            aiType = NPCID.UndeadMiner;
            animationType = NPCID.SantaClaus;
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < .35f)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SantaBeard>());
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneRockLayerHeight ? .1f : 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.Items.Drops;
using Microsoft.Xna.Framework;

namespace GlockMod.NPC.Mobs
{
    class Elf1 : ModNPC
    {
        private const bool V = false;

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elf");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ZombieElf];
		}

		public override void SetDefaults()
		{
			npc.width = 46;
			npc.height = 48;
			npc.damage = 10;
			npc.defense = 2;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.ArmoredSkeleton;
			animationType = NPCID.ZombieElf;
			banner = Item.NPCtoBanner(NPCID.ZombieElf);
			bannerItem = Item.BannerToItem(banner);
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.player.ZoneSnow)
				return SpawnCondition.Overworld.Chance * 0.7f;
			return 0;
        }

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, DustID.Blood, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Gore_Elf1"), 1f);
				Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 8), Main.rand.Next(npc.height / 2));
				Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/Gore_ElfTorso"), 1f);
			}
		}

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < .35f)
            {
				Item.NewItem(npc.getRect(), ModContent.ItemType<ChristmasCheer>(), 3 + Main.rand.Next(3));
			}
			else if (Main.rand.NextFloat() < .70f)
			{
				Item.NewItem(npc.getRect(), ItemID.Present);
			}
			else if (Main.rand.NextFloat() < .10f)
			{
				Item.NewItem(npc.getRect(), ItemID.Coal);
			}
		}
    }

	class Elf2 : ModNPC
	{
		private const bool V = false;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elf");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ZombieElfBeard];
		}

		public override void SetDefaults()
		{
			npc.width = 46;
			npc.height = 48;
			npc.damage = 10;
			npc.defense = 2;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.ArmoredSkeleton;
			animationType = NPCID.ZombieElfBeard;
			banner = Item.NPCtoBanner(NPCID.ZombieElfBeard);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.player.ZoneSnow)
				return SpawnCondition.Overworld.Chance * 0.7f;
			return 0;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, DustID.Blood, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Gore_Elf2"), 1f);
				Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width - 8), Main.rand.Next(npc.height / 2));
				Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/Gore_ElfTorso"), 1f);
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextFloat() < .35f)
			{
				Item.NewItem(npc.getRect(), ModContent.ItemType<ChristmasCheer>(), 3 + Main.rand.Next(3));
			}
			else if (Main.rand.NextFloat() < .70f)
			{
				Item.NewItem(npc.getRect(), ItemID.Present);
			}
			else if (Main.rand.NextFloat() < .10f)
			{
				Item.NewItem(npc.getRect(), ItemID.Coal);
			}
		}
	}

	class Elf3 : ModNPC
	{
		private const bool V = false;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elf");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ZombieElfGirl];
		}

		public override void SetDefaults()
		{
			npc.width = 46;
			npc.height = 48;
			npc.damage = 10;
			npc.defense = 2;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.ArmoredSkeleton;
			animationType = NPCID.ZombieElfGirl;
			banner = Item.NPCtoBanner(NPCID.ZombieElfGirl);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.player.ZoneSnow)
				return SpawnCondition.Overworld.Chance * 0.7f;
			return 0;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, DustID.Blood, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Gore_Elf3"), 1f);
				Vector2 pos = npc.position + new Vector2(Main.rand.Next(npc.width), Main.rand.Next(npc.height));
				Gore.NewGore(pos, npc.velocity, mod.GetGoreSlot("Gores/Gore_ElfTorso"), 1f);

			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextFloat() < .35f)
			{
				Item.NewItem(npc.getRect(), ModContent.ItemType<ChristmasCheer>(), 3 + Main.rand.Next(3));
			}
			else if (Main.rand.NextFloat() < .70f)
			{
				Item.NewItem(npc.getRect(), ItemID.Present);
			}
			else if(Main.rand.NextFloat() < .10f)
            {
				Item.NewItem(npc.getRect(), ItemID.Coal);
            }
		}
	}
}

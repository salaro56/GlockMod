using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GlockMod.Items.Craftables;
using Microsoft.Xna.Framework;

namespace GlockMod.Projectiles
{
    class SantaSnowglobe : ModProjectile
    {
        Player player;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa's Snowglobe");
        }

        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 26;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            aiType = ProjectileID.Shuriken;
            projectile.ranged = false;
            projectile.thrown = false;
            projectile.damage = 2;
        }

        public override void Kill(int timeLeft)
        {
            Main.xMas = true;
            if (!Terraria.NPC.AnyNPCs(NPCID.SantaClaus))
            {
                for (int i = 0; i < 50; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.PurpleCrystalShard, speed * 5, Scale: 1.5f);
                    d.noGravity = true;
                }
                Terraria.NPC.NewNPC((int)projectile.Center.X, (int)projectile.Center.Y, NPCID.SantaClaus);
                Main.PlaySound(SoundID.Item6);
            }
            else
            {
                for (int i = 0; i < 50; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.Snow, speed * 5, Scale: 1.5f);
                    d.noGravity = true;
                }
                Main.PlaySound(SoundID.Item27);
            }    
        }
    }
}

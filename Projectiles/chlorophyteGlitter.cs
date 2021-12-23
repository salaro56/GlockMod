using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GlockMod.Projectiles
{ 
    class chlorophyteGlitter : ModProjectile
    {
        private int merry_colour;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Glitter");
        }

        public override void SetDefaults()
        {
            projectile.width = 12;
            projectile.height = 12;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.damage = 16;
            aiType = ProjectileID.ChlorophyteBullet;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            return false;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 10);
            if (merry_colour == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.Snow, speed * 8, Scale: 1.5f);
                    d.noGravity = true;
                    d.color = Color.Green;
                }
                Main.PlaySound(SoundID.Item27);
            }
            else if (merry_colour == 2)
            {
                for (int i = 0; i < 100; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.Snow, speed * 8, Scale: 1.5f);
                    d.noGravity = true;
                    d.color = Color.DarkGreen;
                }
                Main.PlaySound(SoundID.Item27);
            }
            else if (merry_colour == 3)
            {
                for (int i = 0; i < 100; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.Snow, speed * 8, Scale: 1.5f);
                    d.noGravity = true;
                    d.color = Color.LightGreen;
                }
                Main.PlaySound(SoundID.Item27);
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.Snow, speed * 8, Scale: 1.5f);
                    d.noGravity = true;
                    d.color = Color.GreenYellow;
                }
                Main.PlaySound(SoundID.Item27);
            }
        }
    }
}

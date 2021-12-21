using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna;
using Microsoft.Xna.Framework.Graphics;
using GlockMod.Projectiles;

namespace GlockMod.Projectiles
{
    class glintround : ModProjectile
    {
        int merry_colour = Main.rand.Next(0, 4);

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glint Round");
        }
        public override void SetDefaults()
        {
            // projectile.CloneDefaults(ProjectileID.Bullet);
            aiType = ProjectileID.Bullet;
            projectile.ranged = true;
            projectile.friendly = true;
            projectile.width = 7;
            projectile.height = 15;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.scale = 1;
            projectile.penetrate = 1;
            projectile.type = ModContent.ProjectileType<glintround>();
        }

        public override void AI()
        {
            for (int i = 0; i < 5; i++)
            {
                int glintDust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 76, projectile.velocity.X * 0, projectile.velocity.Y * 0, 150, default(Color), 1f);
                Main.dust[glintDust].noGravity = true;

                if (merry_colour == 1)
                {
                    Main.dust[glintDust].color = Color.Red;
                    Lighting.AddLight(projectile.position, 1, 0, 0);
                }
                else if (merry_colour == 2)
                {
                    Main.dust[glintDust].color = Color.LightBlue;
                    Lighting.AddLight(projectile.position, .67f, .84f, .90f);
                }
                else if (merry_colour == 3)
                {
                    Main.dust[glintDust].color = Color.White;
                    Lighting.AddLight(projectile.position, 1, 1, 1);
                }
                else
                {
                    Main.dust[glintDust].color = Color.Gold;
                    Lighting.AddLight(projectile.position, .8314f, .6863f, .2157f);
                }
                projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
            }
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item, (int)projectile.position.X, (int)projectile.position.Y, 10);
            if(merry_colour == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.Snow, speed * 8, Scale: 1.5f);
                    d.noGravity = true;
                    d.color = Color.Red;
                }
                Main.PlaySound(SoundID.Item27);
            }
            else if(merry_colour == 2)
            {
                for (int i = 0; i < 100; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.Snow, speed * 8, Scale: 1.5f);
                    d.noGravity = true;
                    d.color = Color.LightBlue;
                }
                Main.PlaySound(SoundID.Item27);
            }
            else if(merry_colour == 3)
            {
                for (int i = 0; i < 100; i++)
                {
                    Vector2 speed = Main.rand.NextVector2CircularEdge(1f, 1f);
                    Dust d = Dust.NewDustPerfect(projectile.Center, DustID.Snow, speed * 8, Scale: 1.5f);
                    d.noGravity = true;
                    d.color = Color.White;
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
                    d.color = Color.Gold;
                }
                Main.PlaySound(SoundID.Item27);
            }            
        }
    }
}
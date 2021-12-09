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
                    Main.dust[glintDust].color = Color.Blue;
                    Lighting.AddLight(projectile.position, 0, 0, 1);
                }
                else if (merry_colour == 3)
                {
                    Main.dust[glintDust].color = Color.LightGreen;
                    Lighting.AddLight(projectile.position, 0, 1, 0);
                }
                else
                {
                    Main.dust[glintDust].color = Color.White;
                    Lighting.AddLight(projectile.position, 1, 1, 1);
                    projectile.light = 1f;
                }
                projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
            }
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);

            for (int d = 0; d < 100; d++)
            {
                int dust = Dust.NewDust((projectile.position), 50, 50, 76, projectile.velocity.X * 0, projectile.velocity.Y * 0, 55, default(Color), 1);
                int dust2 = Dust.NewDust(new Vector2(projectile.position.X - 16, projectile.position.Y + 16), 90, 10, 76, projectile.velocity.X * 0, projectile.velocity.Y * 0, 55, default(Color), 1);
                int dust3 = Dust.NewDust(new Vector2(projectile.position.X + 16, projectile.position.Y - 16), 10, 90, 76, projectile.velocity.X * 0, projectile.velocity.Y * 0, 55, default(Color), 1);
                Main.dust[dust].noGravity = true;
                Main.dust[dust2].noGravity = true;
                Main.dust[dust3].noGravity = true;
                if (merry_colour == 1)
                {
                    Main.dust[dust].color = Color.Red;
                    Main.dust[dust2].color = Color.Red;
                    Main.dust[dust3].color = Color.Red;
                }
                else if (merry_colour == 2)
                {
                    Main.dust[dust].color = Color.Blue;
                    Main.dust[dust2].color = Color.Blue;
                    Main.dust[dust3].color = Color.Blue;
                }
                else if (merry_colour == 3)
                {
                    Main.dust[dust].color = Color.LightGreen;
                    Main.dust[dust2].color = Color.LightGreen;
                    Main.dust[dust3].color = Color.LightGreen;
                }
                else
                {
                    Main.dust[dust].color = Color.White;
                    Main.dust[dust2].color = Color.White;
                    Main.dust[dust3].color = Color.White;
                }
            }

        }
    }



}
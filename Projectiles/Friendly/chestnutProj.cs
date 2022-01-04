using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GlockMod.Projectiles.Friendly
{
    class chestnutProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chestnut");
        }

        public override void SetDefaults()
        {
            aiType = ProjectileID.Bullet;
            projectile.friendly = true;
            projectile.width = 12;
            projectile.height = 12;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.penetrate = 1;
            projectile.knockBack = 2f;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);

            float speedX = projectile.velocity.X;
            float speedY = projectile.velocity.Y;

            for (int i = 0; i < Main.rand.Next(2,5); i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(12));
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, perturbedSpeed.X, perturbedSpeed.Y, ModContent.ProjectileType<chestnutShard>(), (int)(projectile.damage * 0.3f), projectile.knockBack, projectile.owner);
            }
        }

        public override void AI()
        {
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, DustID.Fire, projectile.velocity.X * -.01f, projectile.velocity.Y * -0.01f, 0, default, 1f);
        }
    }
}

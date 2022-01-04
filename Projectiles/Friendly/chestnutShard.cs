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
    class chestnutShard : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chestnut");
        }

        public override void SetDefaults()
        {
            //proj stats
            projectile.damage = 12;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.knockBack = 0f;
            //proj configs
            aiType = ProjectileID.Bullet;
            projectile.width = 6;
            projectile.height = 6;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.timeLeft = 600;
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, DustID.Smoke, projectile.velocity.X * -.01f, projectile.velocity.Y * -0.01f, 0, default, 1f);
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);
        }
    }
}

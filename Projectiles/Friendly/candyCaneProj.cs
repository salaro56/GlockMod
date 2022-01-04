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
    class candyCaneProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pointy Candy Cane");
        }

        public override void SetDefaults()
        {
            aiType = ProjectileID.Bullet;
            projectile.friendly = true;
            projectile.width = 9;
            projectile.height = 16;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.penetrate = 4;
            projectile.knockBack = 1f;
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);
        }
    }
}

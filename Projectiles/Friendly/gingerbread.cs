using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace GlockMod.Projectiles.Friendly
{
    class gingerbread : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gingerbread Cookie");
        }

        public override void SetDefaults()
        {
            //proj stats


            //proj configs
            projectile.width = 26;
            projectile.height = 32;
            projectile.friendly = true;
            aiType = ProjectileID.WoodenBoomerang;
            projectile.CloneDefaults(ProjectileID.WoodenBoomerang);
        }
    }
}

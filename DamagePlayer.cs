using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GlockMod.HJD
{
    class DamagePlayer : ModPlayer
    {
        public static DamagePlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<DamagePlayer>();
        }

        public float modDamageMult = 1f;
        public float modKnockbackMult = 1f;
        public int modCritBonus = 0;

        public override void ResetEffects()
        {
            ResetVariables();
        }

        public override void UpdateDead()
        {
            ResetVariables();
        }

        private void ResetVariables()
        {
            modDamageMult = 1f;
            modKnockbackMult = 1f;
            modCritBonus = 0;
        }
    }
}

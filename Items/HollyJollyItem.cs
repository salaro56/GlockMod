using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace GlockMod.HJD
{
    public abstract class HollyJollyItem : ModItem
    {
        public override bool CloneNewInstances => true;


        public float modDamageMult = 1f;
        public float modKnockbackMult;
        public int modCritBonus;

        public virtual void SafeSetDefaults()
        {

        }

        public sealed override void SetDefaults()
        {
            SafeSetDefaults();
            item.melee = false;
            item.ranged = false;
            item.magic = false;
            item.summon = false;
            item.thrown = false;
        }

        public override int ChoosePrefix(UnifiedRandom rand)
        {
            var prefixChooser = new WeightedRandom<int>();
            prefixChooser.Add(mod.PrefixType("CheefulPrefix"), 3);
            prefixChooser.Add(mod.PrefixType("FrugalPrefix"), 2);
            prefixChooser.Add(mod.PrefixType("Naughty"), 2);
            prefixChooser.Add(mod.PrefixType("FestivePrefix"), 1);
            prefixChooser.Add(PrefixID.Damaged, 2);
            prefixChooser.Add(PrefixID.Keen, 3);
            prefixChooser.Add(PrefixID.Strong, 3);
            prefixChooser.Add(PrefixID.Weak, 2);
            int choice = prefixChooser;
            if((item.damage > 0) && item.maxStack == 1)
            {
                return choice;
            }
            return -1;
        }

        public override bool ReforgePrice(ref int reforgePrice, ref bool canApplyDiscount)
        {
            return true;
        }
        public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat)
        {
            mult *= DamagePlayer.ModPlayer(player).modDamageMult;
        }

        public override void GetWeaponKnockback(Player player, ref float knockback)
        {
            knockback *= DamagePlayer.ModPlayer(player).modKnockbackMult;
        }

        public override void GetWeaponCrit(Player player, ref int crit)
        {
            crit += DamagePlayer.ModPlayer(player).modCritBonus;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
            if(tt != null)
            {
                string[] splitText = tt.text.Split(' ');
                string damageValue = splitText.First();
                string damageWord = splitText.Last();

                tt.text = damageValue + " Holly Jolly " + damageWord;
            }
        }
    }
}

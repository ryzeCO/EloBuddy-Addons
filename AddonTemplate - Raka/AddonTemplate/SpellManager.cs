using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace AddonTemplate
{
    public static class SpellManager
    {   /*
         * 
         * Soraka Spellbook
         * 
         * Q - Starcall (Skillshot)
         * 
         * W - Astral Infustion (Targeted)
         * 
         * E - Equinox (Skillshot)
         * 
         * R - Wish (Active)
         * 
         */
        public static Spell.Skillshot Q { get; private set; }
        public static Spell.Targeted W { get; private set; }
        public static Spell.Skillshot E { get; private set; }
        public static Spell.Active R { get; private set; }

        static SpellManager()
        {
            /*
             * Sell data ripped from 
             * https://github.com/KarmaPanda/EloBuddy/blob/master/SorakaBuddy/Program.cs
             * 
             */
            Q = new Spell.Skillshot(SpellSlot.Q, 950, SkillShotType.Circular, 283, 1100, 210);
            W = new Spell.Targeted(SpellSlot.W, 550);
            E = new Spell.Skillshot(SpellSlot.E, 925, SkillShotType.Circular, 500, 1750, 70);
            R = new Spell.Active(SpellSlot.R, int.MaxValue);
        }

        public static void Initialize()
        {
            // Let the static initializer do the job, this way we avoid multiple init calls aswell
        }
    }
}
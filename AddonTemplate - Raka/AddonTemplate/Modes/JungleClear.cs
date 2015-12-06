using System;
using System.Linq;
using EloBuddy.SDK;

namespace AddonTemplate.Modes
{
    public sealed class JungleClear : ModeBase
    {
        private static bool leashOn = true;

        public override bool ShouldBeExecuted()
        {
            // Only execute this mode when the orbwalker is on jungleclear mode
            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.JungleClear);
        }

        public override void Execute()
        {
            // TODO: Add jungleclear logic here
            //
            // Rule 1
            // turn off autoattack?
            //  Help ADC/JG take first camp (use heal on jungler)

            if (leashOn)
            {
                leashCamp();
            }
            // 
            // Rule 2
            //
            //  Help ADC/JG take dragon
            //
            if (leashOn)
            {
                leashDrag();
            }
            // Rule 3 - updateJungleTimers
        }

        private static void leashCamp()
        {
            //
            // Move to location? check how autobuddy finds bottomm lanehere hold on
            //
            Console.WriteLine("Leashing bottom..");
            var minion = EntityManager.MinionsAndMonsters.GetJungleMonsters();
            var jungler = null;

            //Break out
            // what if she gets there before minions and jungler
            if (minion == null || jungler == null)
            {
                leashOn = false;
                return;
            }


        }

        private static void leashDrag()
        {
            Console.WriteLine("Leashing dragonn..");
            leashOn = false;

        }
    }
}

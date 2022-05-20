using System;
using Verse;
using RimWorld;
using System.Reflection;

namespace GeneticRimAddOn
{
    public class HediffComp_Ager : HediffComp
    {


        public HediffCompProperties_Ager Props
        {
            get
            {
                return (HediffCompProperties_Ager)this.props;
            }
        }

        public override void CompPostPostAdd(DamageInfo? dinfo)
        {


            this.parent.pawn.ageTracker. DebugMakeOlder(3600000L);
            MethodInfo CalculateGrowth = typeof(Pawn_AgeTracker).GetMethod("CalculateGrowth", BindingFlags.NonPublic | BindingFlags.Instance);
            CalculateGrowth.Invoke(this.parent.pawn.ageTracker, new object[] { 3600000 });

        }






    }
}


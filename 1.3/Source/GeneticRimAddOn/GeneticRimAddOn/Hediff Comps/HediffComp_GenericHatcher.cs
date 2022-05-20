using System;
using Verse;
using RimWorld;


namespace GeneticRimAddOn
{
    public class HediffComp_GenericHatcher : HediffComp
    {

        private int hatchingTicker = 0;

        public HediffCompProperties_GenericHatcher Props
        {
            get
            {
                return (HediffCompProperties_GenericHatcher)this.props;
            }
        }

        public override void CompExposeData()
        {
            base.CompExposeData();
            Scribe_Values.Look(ref hatchingTicker, "hatchingTicker",0);
        }

        public override void CompPostTick(ref float severityAdjustment)
        {
            Hatch();
        }

        public void Hatch()
        {
            if (hatchingTicker < (Props.hatcherDaystoHatch * 60000))
            {
                hatchingTicker++;
            }
            else
            {
                if ((this.parent.pawn.Map != null) && ((this.parent.pawn.Faction == Faction.OfPlayer) || ((this.parent.pawn.IsPrisoner) && (this.parent.pawn.Map.IsPlayerHome))))
                {
                    for (int i = 0; i < this.Props.amount; i++)
                    {
                        GenSpawn.Spawn(Props.thingToHatch, this.parent.pawn.Position, this.parent.pawn.Map);
                    }

                }
                hatchingTicker = 0;

            }


        }


    }
}

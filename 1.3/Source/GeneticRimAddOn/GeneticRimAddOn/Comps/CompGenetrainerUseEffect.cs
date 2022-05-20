using System;
using Verse;
using RimWorld;
using System.Collections.Generic;



namespace GeneticRimAddOn
{
    public class CompGenetrainerUseEffect : CompUseEffect
    {
        private bool addHediffOnce = true;


        public CompProperties_GenetrainerUseEffect Props
        {
            get
            {
                return (CompProperties_GenetrainerUseEffect)this.props;
            }
        }

        public override void DoEffect(Pawn user)
        {
            List<HediffDef> listHediffs = new List<HediffDef>() { InternalDefOf.GR_UrsineGenetrainerEffect, InternalDefOf.GR_BoomGenetrainerEffect, InternalDefOf.GR_FelineGenetrainerEffect, InternalDefOf.GR_AvianGenetrainerEffect, 
                InternalDefOf.GR_MuffaloGenetrainerEffect, InternalDefOf.GR_CanineGenetrainerEffect, InternalDefOf.GR_RodentGenetrainerEffect, InternalDefOf.GR_ReptileGenetrainerEffect, InternalDefOf.GR_InsectoidGenetrainerEffect, 
                InternalDefOf.GR_EquineGenetrainerEffect, InternalDefOf.GR_ColossalGenetrainerEffect};

            if (addHediffOnce)
            {

               
                bool genetrainerPresent = false;

                foreach(HediffDef hediff in listHediffs) {
                    if (user.health.hediffSet.HasHediff(Props.hediff))
                    {
                        genetrainerPresent = true;
                    }
                
                }

                if(!genetrainerPresent)
                {
                    user.health.AddHediff(Props.hediff);
                    addHediffOnce = false;
                }
                else
                {
                    Messages.Message("GR_CantUseMoreGenetrainers".Translate(), user, MessageTypeDefOf.NeutralEvent);
                }




            }
        }


    }
}

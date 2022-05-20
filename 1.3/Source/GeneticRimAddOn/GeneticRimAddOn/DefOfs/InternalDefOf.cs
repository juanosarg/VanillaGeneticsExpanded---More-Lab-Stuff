using System;
using RimWorld;
using Verse;
using System.Collections.Generic;

namespace GeneticRimAddOn
{
    [DefOf]
    public static class InternalDefOf
    {
        static InternalDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOf));
        }

      

        public static HediffDef GR_UrsineGenetrainerEffect;
        public static HediffDef GR_BoomGenetrainerEffect;
        public static HediffDef GR_FelineGenetrainerEffect;
        public static HediffDef GR_AvianGenetrainerEffect;
        public static HediffDef GR_MuffaloGenetrainerEffect;
        public static HediffDef GR_CanineGenetrainerEffect;
        public static HediffDef GR_RodentGenetrainerEffect;
        public static HediffDef GR_ReptileGenetrainerEffect;
        public static HediffDef GR_InsectoidGenetrainerEffect;
        public static HediffDef GR_EquineGenetrainerEffect;
        public static HediffDef GR_ColossalGenetrainerEffect;



    }
}

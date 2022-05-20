using Verse;

namespace GeneticRimAddOn
{
    public class HediffCompProperties_Ager : HediffCompProperties
    {

        public int daysToAdvance = 1;

        public HediffCompProperties_Ager()
        {
            this.compClass = typeof(HediffComp_Ager);
        }
    }
}

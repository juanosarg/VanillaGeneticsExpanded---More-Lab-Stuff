
using RimWorld;
using System.Collections.Generic;
using Verse;
namespace GeneticRimAddOn
{
	public class Recipe_AddHediff : Recipe_Surgery
	{
		public override bool AvailableOnNow(Thing thing, BodyPartRecord part = null)
		{
			Pawn pawn;
			if ((pawn = (thing as Pawn)) == null)
			{
				return false;
			}
			if (part != null && (pawn.health.WouldDieAfterAddingHediff(recipe.addsHediff, part, 1f) || pawn.health.WouldLosePartAfterAddingHediff(recipe.addsHediff, part, 1f)))
			{
				return false;
			}
			if (pawn.health.hediffSet.HasHediff(recipe.addsHediff))
			{
				return false;
			}
			if (pawn.BillStack.Bills.Any((Bill b) => b.recipe == recipe))
			{
				return false;
			}
			return true;
		}

		public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients, Bill bill)
		{
			if (billDoer != null)
			{
				if (CheckSurgeryFail(billDoer, pawn, ingredients, null, bill))
				{
					return;
				}
				TaleRecorder.RecordTale(TaleDefOf.DidSurgery, billDoer, pawn);
			}
			bool num = IsViolationOnPawn(pawn, null, Faction.OfPlayerSilentFail);
			pawn.health.AddHediff(recipe.addsHediff);
			if (num)
			{
				ReportViolation(pawn, billDoer, pawn.HomeFaction, -70);
			}
		}
	}
}

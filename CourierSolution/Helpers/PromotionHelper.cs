using System.Collections.Generic;
using System.Linq;
using CourierSolution.Interfaces;
using CourierSolution.Models;

namespace CourierSolution.Helpers
{
    public static class PromotionHelper
    {
        public static List<IParcel> Promo = new List<IParcel>();

        public static IList<IParcel> GetPromotions(this IList<IParcel> parcels)
        {

            var smallParcelMania = parcels.OrderBy((p => (p.Cost + p.AdditionalWeightCharge)))
                .Skip(1)
                .Where((x, i) => i % 3 == 0 && x.GetType() == typeof(SmallParcel))
                .ToList();

            var mediumParcelMania = parcels.OrderBy((p => (p.Cost + p.AdditionalWeightCharge)))
                .Skip(1)
                .Where((x, i) => i % 4 == 0 && x.GetType() == typeof(MediumParcel))
                .ToList();

            Promo.AddRange(smallParcelMania);
            Promo.AddRange(mediumParcelMania);

            return Promo;
        }
    }
}
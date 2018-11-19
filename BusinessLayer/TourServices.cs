using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TourServices
    {
        public static List<TourModel> GetAllTours()
        {
            List<TourModel> tours = null;//
            var dbTours = TourDBprovider.GetAllTours();
            if (dbTours != null && dbTours.Count > 0)
            {
                foreach (var dbTour in dbTours)
                {
                    var tour = ConvetDbTourToTourModel(dbTour);
                    tours.Add(tour);
                }
            }

            return tours;
        }
        private static TourModel ConvetDbTourToTourModel(Tour dbTour)
        {
            var tour = new TourModel
            {
                TourID = dbTour.TourID,
                TourName = dbTour.TourName,
                TourDescription = dbTour.TourDescription,
                CategoryID = dbTour.CategoryID,
                CategoryName = dbTour.CategoryID.HasValue ? TourDBprovider.GetCategoryNameById(dbTour.CategoryID.Value) : string.Empty,
                Price = dbTour.ClassID.HasValue ? TourDBprovider.GetTourPriceByTourClassId(dbTour.ClassID.Value) : 0
            };
            var discount = TourDBprovider.GetDiscountByTourId(tour.TourID);
            tour.FinalPrice = tour.Price * discount;
            return tour;
        }
    }
}

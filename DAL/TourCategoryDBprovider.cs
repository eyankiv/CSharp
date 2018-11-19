using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TourCategoryDBprovider
    {
        
        public static List<tourCategory> getAllTourCategories()
        {
            List<tourCategory> lst = null;
            using (ToursDBContext db = new ToursDBContext())
            {
                lst = (from tourCategory in db.tourCategories select tourCategory).ToList();
            }

            return lst;
        }

        public static List<Tour> getToursByCategoryID(int categoryID)
        {
            List<Tour> lst = null;
            using (ToursDBContext db = new ToursDBContext())
            {
               // lst = (from Tour in db.Tours where Tour.CategoryID == categoryID select Tour).ToList();
                lst = db.Tours.Where(t => t.CategoryID == categoryID).ToList();
            }

            return lst;
        }
    }
}

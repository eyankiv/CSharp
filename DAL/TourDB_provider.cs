using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TourDB_provider
    {
        public static List<Tour> GetAllTours()
        {
            List<Tour> lst = null;
            using (ToursDBContext db = new ToursDBContext())
            {
                lst = (from tour in db.Tours select tour).ToList();
            }
            return lst;
            
        }
    }
}

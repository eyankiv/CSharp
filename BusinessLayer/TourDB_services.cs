using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TourDB_services
    {
        public static List<Tour> GetAllTours()
        {
            return TourDB_provider.GetAllTours();
        }
    }
}

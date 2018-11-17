using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TourDBprovider
    {
public static List<Tour> GetAllTours()//todo - check if this should be static. read when to use static
    {
        List<Tour> lst = null;
        using (ToursDBContext db = new ToursDBContext())
        {
            lst = (from tour in db.Tours select tour).ToList();
        }
        return lst;
    }
    public static string GetCategoryNameById(int id)
    {
        var name = string.Empty;
        using (ToursDBContext db = new ToursDBContext())
        {
            var category = db.tourCategories.FirstOrDefault(x => x.CategoryId == id);
            if (category != null)
            {
                name = category.CategoryName;
            }
        }
        return name;
    }
    public static int GetTourPriceByTourClassId(int id)
    {
        int price = 0;
        using (ToursDBContext db = new ToursDBContext())
        {
            var tourClass = db.tourClasses.FirstOrDefault(x => x.ClassID == id);
            if (tourClass != null)
            {
                price = tourClass.ClassPrice;
            }
        }
        return price;
    }
    public static double GetDiscountByTourId(int id)
    {
        return 1;
    }
}
}

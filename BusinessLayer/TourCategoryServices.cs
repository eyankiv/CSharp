using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BusinessLayer
{
    public class TourCategoryServices
    {
        public static List<TourCategoryModel> getAllCategories()
        {
            List<TourCategoryModel> categories = null;

            var dbTourCategories = TourCategoryDBprovider.getAllTourCategories();
            if (dbTourCategories != null && dbTourCategories.Count>0)
            {
                foreach (var tourCategory in dbTourCategories)
                {
                    //TODO: convert Tourcategory to tourCategorymodel
                    //TODO: add to categories
                    var tourCategoryModel = ConvetDbTourCategoryToTourCategoryModel(tourCategory);
                    categories.Add(tourCategoryModel);
                }
            }

            return categories;
        }  

        private static TourCategoryModel ConvetDbTourCategoryToTourCategoryModel(tourCategory dbTourCategory)
        {


            var tourCategory = new TourCategoryModel
            {
                CategoryId = dbTourCategory.CategoryId,
                CategoryName = dbTourCategory.CategoryName,
                CategoryDescription = dbTourCategory.CategoryDescription,
                CategoryPhotoLink = dbTourCategory.CategoryPhotoLink
            };

            return tourCategory;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class TourMetaData
    {
        public int TourID { get; set; }
        public string TourName { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string MainPhotoLink { get; set; }
        public string TourDescription { get; set; }
        public Nullable<int> GalleryId { get; set; }
        public Nullable<int> ClassID { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<int> AvailDatesID { get; set; }

        public virtual tourCategory tourCategory { get; set; }
        public virtual tourGallery tourGallery { get; set; }
    }
    
    public partial class TourCategoryMetaData
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryPhotoLink { get; set; }
  
        public virtual ICollection<Tour> Tours { get; set; }
    }
}

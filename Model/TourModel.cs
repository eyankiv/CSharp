using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TourModel
    {
        public int TourID { get; set; }
        public string TourName { get; set; }
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string MainPhotoLink { get; set; }
        public string TourDescription { get; set; }
        public int Price { get; set; }
        public double FinalPrice { get; set; }
    }
}

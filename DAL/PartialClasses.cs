using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [MetadataType(typeof(TourMetaData))]
    public partial class Tour
    {

    }

    [MetadataType(typeof(TourCategoryMetaData))]
    public partial class tourCategory
    {

    }
}

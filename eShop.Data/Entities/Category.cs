using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Category
    {
        public int CategoryId { set; get; }
        public int DisplayOrder { set; get; }
        public bool IsShowHome { set; get; }
        public int? ParentId { set; get; }
        public ReviewStatus ReviewStatusId { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}

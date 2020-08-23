using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class CategoryTranslation
    {
        public int CategoryTranslationId { set; get; }
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }
        public string CategoryDesc { set; get; } 
        public string LanguageId { set; get; }
        public string SeoAlias { set; get; }
        public int AppSeoId { set; get; }

        public Category Category { get; set; }

        public Language Language { get; set; }


    }
}

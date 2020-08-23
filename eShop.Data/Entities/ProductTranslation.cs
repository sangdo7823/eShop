﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class ProductTranslation
    {
        public int ProductTranslationId { set; get; }
        public int ProductId { set; get; }
        public string Name { set; get; } 
        public string Description { set; get; }
        public string Details { set; get; }
        public string LanguageId { set; get; }
        public string SeoAlias { set; get; } 
        public int AppSeoId { get; set; }
        public Product Product { get; set; } 
        public Language Language { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class AppSeo
    {
        public int AppSeoId { set; get; }
        public string SeoTitle { set; get; }
        public string SeoDescription { set; get; }
        public string SeoKeyword { set; get; }
        public string Canonical { set; get; }
        public string ImagePath { set; get; }

        public int ProductTranslationId { set; get; }
        public ProductTranslation ProductTranslation { set; get; } 

        public int CategoryTranslationId { set; get; }
        public CategoryTranslation CategoryTranslation { set; get; }
    }
}

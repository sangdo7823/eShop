using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
   public class ArticleTranslation
    {
        public int ArticleTranslationId { set; get; }
        public int ArticleId { set; get; }
        public string ArticleTitle { set; get; }
        public string ArticleSummary { set; get; }
        public string ArticleContent { set; get; }
        public int AppSeoId { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; } 
        public Article Article { get; set; }
        public Language Language { get; set; }
    }
}

using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Article
    {
        public int ArticleId { set; get; } 
        public int ViewCount { set; get; }
        public DateTime CrDateTime { set; get; }
        public int CrUserId { set; get; }
        public DateTime? UpDateTime { set; get; }
        public int UpUserId { set; get; }
        public DataType DataTypeId { set; get; }
        public DateTime? PublishTime { set; get; }
        public int DisplayOrder { set; get; }
        public int ShowTop { set; get; }
        public ReviewStatus ReviewStatusId { set; get; }
        public List<ArticleInCategory> ArticleInCategories { get; set; } 
        public List<ArticleTranslation> ArticleTranslations { get; set; }
        public List<ArticleRelate> ArticleRelates { get; set; }
        public List<ArticleMedia> ArticleMedias { get; set; }
    }
}

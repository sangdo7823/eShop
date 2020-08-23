using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class ArticleMedia
    {
        public int ArticleMediaId { set; get; }
        public int ArticleId { set; get; }
        public int MediaId { set; get; }
        public MediaType? MediaTypeId { set; get; }
        public int DisplayOrder { set; get; }
        public int FilePath { set; get; }
        public string Caption { get; set; } 
        public bool IsDefault { get; set; }
        public int CrUserId { set; get; }
        public DateTime CrDateTime { set; get; } 
        public Article Article { set; get; }
    }
}

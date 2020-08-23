using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class ArticleRelate
    {
        public int ArticleRelateId { set; get; }
        public int ArticleId { set; get; }
        public int DisplayOrder { set; get; }
        public int ArticleReferenceId { set; get; }
        public int CrUserId { set; get; }
        public DateTime CrDateTime { set; get; } 
        public Article ArticleReference { set; get; }

    }
}

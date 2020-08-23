using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{ 
    public class ArticleInCategory
    {
        public int ArticleId { get; set; }

        public Article Article { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}

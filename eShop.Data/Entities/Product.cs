using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Product
    {
        public int ProductId { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime CrDateTime { set; get; }
        public int CrUserId { set; get; }
        public DateTime? UpDateTime { set; get; }
        public int UpUserId { set; get; } 
        public ReviewStatus ReviewStatusId { set; get; } 
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductMedia> ProductMedias { get; set; }

    }
}

using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class ProductMedia
    {
        public int ProductMediaId { get; set; }
        public int ProductId { get; set; }
        public int MediaId { set; get; }
        public string FilePath { get; set; }
        public MediaType? MediaTypeId { set; get; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int DisplayOrder { get; set; }
        public long FileSize { get; set; }
        public Product Product { get; set; }
    }
}

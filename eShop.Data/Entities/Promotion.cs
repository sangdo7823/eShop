﻿using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Promotion
    {
        public int PromotionId { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public bool ApplyForAll { set; get; }
        public int? DiscountPercent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public string ProductIds { set; get; }
        public string ProductCategoryIds { set; get; }
        public ReviewStatus ReviewStatusId { set; get; }
        public string Name { set; get; }

    }
}

using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class MenuItem
    {
        public int MenuItemId { set; get; }
        public int MenuId { set; get; }
        public string ItemName { set; get; }
        public string ItemDesc { set; get; }
        public string IconPath { set; get; }
        public string Url { set; get; }
        public int TreeOrder { set; get; }
        public int ParentItemId { set; get; }
        public int ItemLevel { set; get; }
        public int DisplayOrder { set; get; }
        public ReviewStatus ReviewStatusId { set; get; }
        public int CrUserId { set; get; }
        public DateTime CrDateTime { set; get; }
        public Menu Menu { set; get; }
    }
}

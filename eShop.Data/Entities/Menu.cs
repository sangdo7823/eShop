using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Menu
    {
        public int MenuId { set; get; }
        public string MenuName { set; get; }
        public string MenuDesc { set; get; }
        public int CategoryId { set; get; }
        public int CrUserId { set; get; }
        public DateTime CrDateTime { set; get; }

        public List<MenuItem> MenuItems { set; get; }
    }
}

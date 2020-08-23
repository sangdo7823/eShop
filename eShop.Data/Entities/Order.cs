using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Order
    {
        public int OrderId { set; get; }
        public DateTime CrDateTime { set; get; } 
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public OrderStatus OrderStatusId { set; get; }
        public DateTime? UpDateTime { set; get; }  
        public List<OrderDetail> OrderDetails { set; get; }

    }
}

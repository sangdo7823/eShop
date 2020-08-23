using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Contact
    {
        public int ContactId { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public DateTime CrDateTime { set; get; }
        public ReviewStatus ReviewStatusId { set; get; }

    }
}

using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class AppMedia
    {
        public int MediaId { set; get; }
        public int SiteId { set; get; }
        public MediaType MediaTypeId { set; get; }
        public MediaGroup MediaGroupId { set; get; }
        public string MediaName { set; get; }
        public string MediaDesc { set; get; }
        public string FilePath { set; get; }
        public int FileSize { set; get; }
        public int CrUserId { set; get; }
        public DateTime CrDateTime { set; get; }
    }
}

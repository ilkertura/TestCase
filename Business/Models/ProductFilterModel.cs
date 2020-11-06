using System;

namespace Business.Models
{
    public class ProductFilterModel :RequestBase
    {
        public string Name { get; set; }       
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Count { get; set; }

    }
}

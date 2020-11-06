using System;

namespace Business.Models
{
    public class UserFilterModel : RequestBase
    {
        public string UserName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Count { get; set; }
    }
}

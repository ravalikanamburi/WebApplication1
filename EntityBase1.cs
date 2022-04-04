using System;

namespace WebApplication1
{
    public class WebService
    {
        public class EntityBase
        {
            public DateTime? CreatedAt { get; set; }
            public int CreatedByUserId { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public int UpdatedByUserId { get; set; }
        }
    }
}

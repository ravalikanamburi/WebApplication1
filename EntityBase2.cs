using System;

namespace WebApplication1
{
    public partial class WebService1
    {
        public class EntityBase
        {
            public DateTime? CreatedAt { get; set; }

            private User createdBy;

            public User GetCreatedBy()
            {
                return createdBy;
            }

            public void SetCreatedBy(User value)
            {
                createdBy = value;
            }

            public DateTime? UpdatedAt { get; set; }
            public User UpdatedBy { get; set; }
        }
    }
}

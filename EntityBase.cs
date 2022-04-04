using System;
using System.Web.Services;

namespace WebApplication1
{
    public partial class WebService
    {
        [WebMethod]
        public class EntityBase
        {
            public DateTime? CreatedAt { get; set; }
            public User CreatedBy { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public User UpdatedBy { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
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

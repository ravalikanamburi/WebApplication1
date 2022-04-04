namespace WebApplication1
{
    public partial class WebService
    {
        public class User : EntityBase
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}

using UserLoginPrac.Areas.Identity.Data;

namespace UserLoginPrac.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        public string? UserId { get; set; }

        public UserLoginPracUser? user {  get; set; }
    }
}

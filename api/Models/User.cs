using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class User
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime? created_at { get; set; } = DateTime.Now;
    }
}

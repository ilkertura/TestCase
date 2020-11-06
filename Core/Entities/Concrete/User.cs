using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testapicore6.Data
{
    [Table("User")]
    public class Test
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace testapicore6.Models
{
    public class TestModel
    {
        public string Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}

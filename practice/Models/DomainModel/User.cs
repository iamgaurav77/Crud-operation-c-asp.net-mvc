using System.ComponentModel.DataAnnotations;

namespace practice.Models.DomainModel
{
    public class User
    {

        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}






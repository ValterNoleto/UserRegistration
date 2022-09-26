using System.ComponentModel.DataAnnotations;

namespace UserRegistration.Api.Models
{
    public class User
    {
        [Key]
        //[Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }
        public float? Height { get; set; }
        [Required]
        public string Cpf{ get; set; }
    }
}

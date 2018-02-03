using System.ComponentModel.DataAnnotations;

namespace Lab5.Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public string Username { get; set; }

        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [StringLength(20)]
        [Required]
        public string Name { get; set; }

        [StringLength(20)]
        [Required]
        public string Surname { get; set; }
    }
}
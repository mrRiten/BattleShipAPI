using System.ComponentModel.DataAnnotations;

namespace UserMicroService.Core.Models
{
    public class Raitimg
    {
        [Key]
        public int IdRaitimg { get; set; }

        [Required]
        [StringLength(64)]
        public required string RaitimgName { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}

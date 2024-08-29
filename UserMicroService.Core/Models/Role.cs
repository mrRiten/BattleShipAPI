using System.ComponentModel.DataAnnotations;

namespace UserMicroService.Core.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [StringLength(64)]
        public required string RoleName { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}

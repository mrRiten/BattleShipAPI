using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UserMicroService.Core.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(128)]
        public required string Login { get; set; }

        [Required]
        [StringLength(64)]
        public required string UserName { get; set; }

        [Required]
        public required string Password { get; set; }

        public string? ImagePath { get; set; }

        [DefaultValue(1)]
        public int RoleId { get; set; }

        [DefaultValue(1)]
        public int RaitingId { get; set; }

        [DefaultValue(0)]
        public float Score { get; set; }

        public Raitimg? Raitimg { get; set; }

        public Role? Role { get; set; }
    }
}

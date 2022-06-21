using System.ComponentModel.DataAnnotations;

namespace ProtectedWebAPI.Models
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}
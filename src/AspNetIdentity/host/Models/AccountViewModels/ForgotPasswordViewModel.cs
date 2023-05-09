using System.ComponentModel.DataAnnotations;

namespace IdentityServerZoe.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

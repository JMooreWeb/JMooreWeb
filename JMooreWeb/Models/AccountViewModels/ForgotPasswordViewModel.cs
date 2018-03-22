using System.ComponentModel.DataAnnotations;

namespace JMooreWeb.Models.AccountViewModels
{
	public class ForgotPasswordViewModel
    {
		[Required]
		[Display(Name = "Email Address")]
		public string Email { get; set; }
	}
}

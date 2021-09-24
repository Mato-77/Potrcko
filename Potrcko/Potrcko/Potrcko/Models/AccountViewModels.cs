using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Potrcko.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Емаил")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Лозинката {0} е потребно {2} карактери долга.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Лозинка")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потврди лозинка")]
        [Compare("Password", ErrorMessage = "Лозинката и потврдата за лозинка не се совпаѓаат")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Профилна слика")]
        public string ImageURL { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Име")]

        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Презиме")]
        public string Surname { get; set; }


        [Required]
        [Display(Name = "Адреса")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Град")]
        public string City { get; set; }



        [Required]
        [Display(Name = "Број на трансакциска сметка")]
        [RegularExpression("^(210)[0-9]{12}", ErrorMessage = "Невалиден внес на трансакциска  сметка ")]

        public string TransactionNumber { get; set; }

        [Required]
        [Display(Name = "Банка")]
        public string Bank { get; set; }

        [Required]
        [Display(Name = "Телефонски број")]
        [RegularExpression("^(0|[+]389)7[^34] [0-9]{3} [0-9]{3}$", ErrorMessage = "Невалиден внес на телефонски број!")]
        public string PhoneNumber { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

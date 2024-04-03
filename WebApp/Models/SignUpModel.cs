using System.ComponentModel.DataAnnotations;
using WebApp.Helper;

namespace WebApp.Models;

public class SignUpModel
{
    [Display(Name = "First Name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email Address", Prompt = "Enter your email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    
    public string Email { get; set; } = null!;


    [Display(Name = "Password", Prompt = "Enter your password", Order = 3)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]
    
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm password", Prompt = "Confirm your password", Order = 4)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Fields does not match")]
    public string ConfirmPassword { get; set; } = null!;




    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]

    [CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions")]
    public bool TermsAndConditions { get; set; } = false;
}

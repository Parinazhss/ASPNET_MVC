using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class AccountDetailsAddressInfoModel
{
    [Display(Name = "Addressline_1", Prompt = "Enter your Address", Order = 0)]
    [Required(ErrorMessage = "Address is required")]
    public string Addressline_1 { get; set; } = null!;

    [Display(Name = "Addreessline_2", Prompt = "Enter your Address", Order = 1)]

    public string? Addressline_2 { get; set; } 

    [Display(Name = "Postal Code", Prompt = "Enter your postal code", Order = 2)]
    [Required(ErrorMessage = "Postal Code is required")]
    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City", Prompt = "Enter your city", Order = 3)]
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = null!;
}

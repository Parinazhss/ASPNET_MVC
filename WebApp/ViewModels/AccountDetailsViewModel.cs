using WebApp.Models;

namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
       {
         ProfileImage = "images/image-account.svg",
         FirstName="Parinaz",
         LastName="Zadeh",
         Email="parinaz@gmail.com"
       };

    public  AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
    
}

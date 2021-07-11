using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Acme.FakZan2a.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Volo.Abp.Account;
using Volo.Abp.Account.Web.Pages.Account;
using Volo.Abp.Data;
using static Volo.Abp.Account.Web.Pages.Account.LoginModel;
using static Volo.Abp.Account.Web.Pages.Account.RegisterModel;

namespace Acme.FakZan2a.Web.Pages.Account
{
    public class CustomRegisterModel : RegisterModel
    {
        private readonly IAccountAppService _accountAppService;

        public CustomRegisterModel(IAccountAppService accountAppService) :base(accountAppService)
        {
            this._accountAppService = accountAppService;
        }
        [BindProperty]
        public PostInputExtendedModel LoginInputExtended { get; set; }

        protected async override Task RegisterLocalUserAsync()
        {
            Dictionary<string, object> extraProperties = new Dictionary<string, object>();
            extraProperties.Add(nameof(LoginInputExtended.FullNameArabic), LoginInputExtended.FullNameArabic);
            ExtraPropertyDictionary dic = new ExtraPropertyDictionary(extraProperties);

            var registerObject = new RegisterDtoExtended
            (
                emailAddress : LoginInputExtended.EmailAddress,
                password : LoginInputExtended.Password,
                userName : LoginInputExtended.UserName,
                appName: "FakZan2a",
                extraProperties: dic
            );

            try
            {

            
            var result = await AccountAppService.RegisterAsync(registerObject);
           var t =  result.ExtraProperties.Count();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
    public class PostInputExtendedModel : PostInput
    {
        [Required]
        [MaxLength(256)]
        [Display(Name = "Full Name Arabic")]
        public string FullNameArabic { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "Full Name English")]
        public string FullNameEnglish { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "WhatsApp Number")]
        public string WhatsAppNumber { get; set; }

    }
    public class RegisterDtoExtended: RegisterDto
    {
        public RegisterDtoExtended(string userName,string emailAddress,string password, ExtraPropertyDictionary extraProperties, string appName = "")
        {
            this.UserName = userName;
            this.Password = password;
            this.EmailAddress = emailAddress;
            this.ExtraProperties = extraProperties;
            this.AppName = appName;
        }
    }
}

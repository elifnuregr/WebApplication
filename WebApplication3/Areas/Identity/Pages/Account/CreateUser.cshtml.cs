using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;

namespace WebApplication3.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class CreateUserModel : PageModel
    {
        #region Members   





        [BindProperty]
        public UserModel userModel { get; set; }

        private readonly CreateUserModel createUserModel;

        public CreateUserModel GetCreateUserModel()
        {
            return createUserModel;
        }
        #endregion
        #region Constructor     
        public CreateUserModel(
            CreateUserModel userModel)
        { createUserModel = userModel; }
        #endregion

        public void OnGet()
        {
        }
        UserModel model = new UserModel();
        public async Task<ActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {

                //error                
            }
            else
            {
                //success

            }
            return Page();
        }

    }
}


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SocialBlogWebApp.Models;

namespace SocialBlogWebApp.Pages
{
    [Authorize(Roles ="user")]
    public class UserModel : PageModel
    {
       
        public void OnGet()
        {
            
        }
    }
}

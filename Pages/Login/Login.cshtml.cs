using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LA.Models.User;
using LA.Service.Login;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LA.Pages.Login
{
    public class LoginModel : PageModel
    {
        private readonly ILoginService m_LoginService;
        public User pageLogin { get; set; }
        public LoginModel(ILoginService loginService)
        {
            m_LoginService = loginService;
        }

        public void OnGet()
        {

        }
        public void OnPost(User loginUser)
        {
            var test = loginUser;            
        }

    }
}
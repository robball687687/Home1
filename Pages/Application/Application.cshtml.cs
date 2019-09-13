using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LA.Models.Tenant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LA.Pages.Application
{
    public class ApplicationModel : PageModel
    {
        public TenantApplication pageApplication { get; set; }

        public void OnGet()
        {

        }
    }
}
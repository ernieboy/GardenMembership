using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GardenMembership.SharedKernel.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace GardenMembership.UI.Pages.Baskets
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationSecrets _applicationSecrets;

        public IndexModel(IOptions<ApplicationSecrets> applicationSecrets)
        {
            _applicationSecrets = applicationSecrets.Value;
        }

        public void OnGet()
        {
        }
    }
}

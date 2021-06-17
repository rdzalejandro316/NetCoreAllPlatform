using CoreApp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        Main main = new Main();
        public CoreApp.Models.Tercero tercero = new CoreApp.Models.Tercero();
        public IndexModel(ILogger<IndexModel> logger)
        {
            tercero = main.LoadTercero();
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

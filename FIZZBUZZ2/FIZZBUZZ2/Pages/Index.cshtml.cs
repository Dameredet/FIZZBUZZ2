using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FIZZBUZZ2.Models;

namespace FIZZBUZZ2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Wynik { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;        
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                FizzBuzz.Wynik = FizzBuzz.CzyFizzBuzz(FizzBuzz.Liczba);
                HttpContext.Session.SetString("SessionOstatnioSzukane", JsonConvert.SerializeObject(FizzBuzz));
                
            }
            return RedirectToPage("Index", new { Wynik = FizzBuzz.Wynik});
        }

        

    }
}

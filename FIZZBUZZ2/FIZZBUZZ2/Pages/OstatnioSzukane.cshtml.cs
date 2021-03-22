using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FIZZBUZZ2.Models;

namespace FIZZBUZZ2.Pages
{
    public class OstatnioSzukaneModel : PageModel
    {
        public FizzBuzz FizzBuzz;
        public void OnGet()
        {
            var SessionOstatnioSzukane = HttpContext.Session.GetString("SessionOstatnioSzukane");
            if (SessionOstatnioSzukane != null) FizzBuzz = JsonConvert.DeserializeObject<FizzBuzz>(SessionOstatnioSzukane);

        }
    }
}

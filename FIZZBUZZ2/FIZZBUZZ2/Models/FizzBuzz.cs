using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FIZZBUZZ2.Models
{
    public class FizzBuzz
    {
        [Range(1,1000,ErrorMessage ="Out of range, please choose beetween 1-1000"), Required(ErrorMessage = "Proszę podać liczbę.")]
        public int Liczba { get; set; }

        public string Wynik{ get; set; }

        public string CzyFizzBuzz(int Liczba)
        {
            if(Liczba%3 == 0)
            {
                if (Liczba % 5 == 0) return "FizzBuzz";
                return "Fizz";
            }
            if (Liczba % 5 == 0) return "Buzz";
            string msg = "" + Liczba;
            return msg;
        }
    }
}

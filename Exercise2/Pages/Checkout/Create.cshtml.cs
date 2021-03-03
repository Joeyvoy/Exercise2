using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Exercise2.Models;

namespace Exercise2.Pages.Checkout
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }

        //GET handler
        public void OnGet(string name, string checkIn, string checkOut, string address, string roomNumber, string emailAddress, string billing)
        {
            
        }

       
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect("/Index");
            
        }
    }
}
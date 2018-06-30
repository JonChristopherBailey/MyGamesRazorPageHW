using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyGames.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MyGames.Pages.GamePages
{
    public class CreateModel : PageModel
    {
        public class createModel : PageModel
        {
            private ApplicationDbContext _db;

            [TempData]
            public string afterAddMessages { get; set; }

            public createModel(ApplicationDbContext db)
            {
                _db = db;
            }

            [TempData]
            public string afterAddMessage { get; set; }

            [BindProperty]
            public MyGames Games { get; set; }

            public void OnGet()
            {
            }

            public async Task<IActionResult> OnPost()
            {
                if (!ModelState.IsValid)
                {
                    //return to the page
                    return Page();
                }
                else
                {
                    // if it is valid, then we'll add our connection
                    _db.GamesItems.Add(Connection);
                    await _db.SaveChangesAsync();
                    afterAddMessage = "New Connection Made";

                    return RedirectToPage("index");
                }
            }
        }
    }
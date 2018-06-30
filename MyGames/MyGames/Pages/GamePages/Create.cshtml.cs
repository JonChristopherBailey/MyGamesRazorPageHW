using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyGames.Models;

namespace MyGames.Pages.GamePages
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContext _db;


        public CreateModel(ApplicationDbContext db)

        {
            _db = db;
        }

        [BindProperty]
        public GetGames Game { get; set; }

        public void OnGet()
        {

        }

        public async Task<IactionResult> OnPost()
        {
            if(!ModelState.IsValid)
                //return to page not view
            {
                return Page();
            }
            else
            {
                //if valid add game item to table
                _db.GamesItems.Add(Game);
            }
        }
    }
}
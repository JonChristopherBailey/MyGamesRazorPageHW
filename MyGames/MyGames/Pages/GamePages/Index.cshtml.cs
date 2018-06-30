using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyGames.Models;

namespace MyGames.Pages.MyGames
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Models.MyGames> MyGames { get; set; }

        public async Task OnGet()
        {
            MyGames = await _db.GamesItems.ToListAsync();
        }

    }

}

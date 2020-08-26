using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCoreSQLSampleApplication.Data;
using RazorPagesMovie.Models;

namespace AspNetCoreSQLSampleApplication.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly AspNetCoreSQLSampleApplication.Data.AspNetCoreSQLSampleApplicationContext _context;

        public IndexModel(AspNetCoreSQLSampleApplication.Data.AspNetCoreSQLSampleApplicationContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class nepolnyArhiveModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public nepolnyArhiveModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> results { get; set; }
        public void OnGet()
        {
            results = _context.Movie.ToList();
        }

        public void OnPost(DateTime startdate)
        {
            DateTime Now = DateTime.Now;
            

            startdate = Now.AddMinutes(-1);
            results = (from x in _context.Movie where (x.ReleaseDate >= startdate) select x).ToList();
        }

    }
}

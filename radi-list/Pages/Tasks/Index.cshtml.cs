using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using radi_list.Data;
using radi_list.Models;

namespace radi_list.Pages.Tasks
{
    public class IndexModel : PageModel
    {
        private readonly radi_list.Data.radi_listContext _context;

        public IndexModel(radi_list.Data.radi_listContext context)
        {
            _context = context;
        }

        public IList<RadiologyTask> RadiologyTask { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.RadiologyTask != null)
            {
                RadiologyTask = await _context.RadiologyTask.ToListAsync();
            }
        }
    }
}

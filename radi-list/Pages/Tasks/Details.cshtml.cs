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
    public class DetailsModel : PageModel
    {
        private readonly radi_list.Data.radi_listContext _context;

        public DetailsModel(radi_list.Data.radi_listContext context)
        {
            _context = context;
        }

      public RadiologyTask RadiologyTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RadiologyTask == null)
            {
                return NotFound();
            }

            var radiologytask = await _context.RadiologyTask.FirstOrDefaultAsync(m => m.Id == id);
            if (radiologytask == null)
            {
                return NotFound();
            }
            else 
            {
                RadiologyTask = radiologytask;
            }
            return Page();
        }
    }
}

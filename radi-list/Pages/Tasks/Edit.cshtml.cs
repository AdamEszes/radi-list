using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using radi_list.Data;
using radi_list.Models;

namespace radi_list.Pages.Tasks
{
    public class EditModel : PageModel
    {
        private readonly radi_list.Data.radi_listContext _context;

        public EditModel(radi_list.Data.radi_listContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RadiologyTask RadiologyTask { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RadiologyTask == null)
            {
                return NotFound();
            }

            var radiologytask =  await _context.RadiologyTask.FirstOrDefaultAsync(m => m.Id == id);
            if (radiologytask == null)
            {
                return NotFound();
            }
            RadiologyTask = radiologytask;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RadiologyTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RadiologyTaskExists(RadiologyTask.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RadiologyTaskExists(int id)
        {
          return _context.RadiologyTask.Any(e => e.Id == id);
        }
    }
}

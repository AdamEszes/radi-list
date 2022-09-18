using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using radi_list.Data;
using radi_list.Models;

namespace radi_list.Pages.Tasks
{
    public class CreateModel : PageModel
    {
        private readonly radi_list.Data.radi_listContext _context;

        public CreateModel(radi_list.Data.radi_listContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RadiologyTask RadiologyTask { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RadiologyTask.Add(RadiologyTask);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

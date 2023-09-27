using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FleetManagementSignalR.Data;
using FleetManagementSignalR.Models;

namespace FleetManagementSignalR.Pages.Makes
{
    public class EditModel : PageModel
    {
        private readonly FleetManagementSignalR.Data.FleetManagementSignalRContext _context;

        public EditModel(FleetManagementSignalR.Data.FleetManagementSignalRContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Make Make { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Make == null)
            {
                return NotFound();
            }

            var make =  await _context.Make.FirstOrDefaultAsync(m => m.Id == id);
            if (make == null)
            {
                return NotFound();
            }
            Make = make;
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

            _context.Attach(Make).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MakeExists(Make.Id))
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

        private bool MakeExists(int id)
        {
          return (_context.Make?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

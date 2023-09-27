using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FleetManagementSignalR.Data;
using FleetManagementSignalR.Models;

namespace FleetManagementSignalR.Pages.Makes
{
    public class DeleteModel : PageModel
    {
        private readonly FleetManagementSignalR.Data.FleetManagementSignalRContext _context;

        public DeleteModel(FleetManagementSignalR.Data.FleetManagementSignalRContext context)
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

            var make = await _context.Make.FirstOrDefaultAsync(m => m.Id == id);

            if (make == null)
            {
                return NotFound();
            }
            else 
            {
                Make = make;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Make == null)
            {
                return NotFound();
            }
            var make = await _context.Make.FindAsync(id);

            if (make != null)
            {
                Make = make;
                _context.Make.Remove(Make);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

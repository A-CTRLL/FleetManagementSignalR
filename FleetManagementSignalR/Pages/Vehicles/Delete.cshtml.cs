using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FleetManagementSignalR.Data;
using FleetManagementSignalR.Models;

namespace FleetManagementSignalR.Pages.Vehicles
{
    public class DeleteModel : PageModel
    {
        private readonly FleetManagementSignalR.Data.FleetManagementSignalRContext _context;

        public DeleteModel(FleetManagementSignalR.Data.FleetManagementSignalRContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Vehicle Vehicle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vehicle == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FirstOrDefaultAsync(m => m.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }
            else 
            {
                Vehicle = vehicle;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Vehicle == null)
            {
                return NotFound();
            }
            var vehicle = await _context.Vehicle.FindAsync(id);

            if (vehicle != null)
            {
                Vehicle = vehicle;
                _context.Vehicle.Remove(Vehicle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

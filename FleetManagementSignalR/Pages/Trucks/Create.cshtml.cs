using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FleetManagementSignalR.Data;
using FleetManagementSignalR.Models;

namespace FleetManagementSignalR.Pages.Trucks
{
    public class CreateModel : PageModel
    {
        private readonly FleetManagementSignalR.Data.FleetManagementSignalRContext _context;

        public CreateModel(FleetManagementSignalR.Data.FleetManagementSignalRContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MakeId"] = new SelectList(_context.Make, "Id", "Id");
        ViewData["ModelId"] = new SelectList(_context.Model, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Truck Truck { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Truck_1 == null || Truck == null)
            {
                return Page();
            }

            _context.Truck_1.Add(Truck);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

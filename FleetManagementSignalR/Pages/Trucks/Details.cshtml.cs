using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FleetManagementSignalR.Data;
using FleetManagementSignalR.Models;

namespace FleetManagementSignalR.Pages.Trucks
{
    public class DetailsModel : PageModel
    {
        private readonly FleetManagementSignalR.Data.FleetManagementSignalRContext _context;

        public DetailsModel(FleetManagementSignalR.Data.FleetManagementSignalRContext context)
        {
            _context = context;
        }

      public Truck Truck { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Truck_1 == null)
            {
                return NotFound();
            }

            var truck = await _context.Truck_1.FirstOrDefaultAsync(m => m.Id == id);
            if (truck == null)
            {
                return NotFound();
            }
            else 
            {
                Truck = truck;
            }
            return Page();
        }
    }
}

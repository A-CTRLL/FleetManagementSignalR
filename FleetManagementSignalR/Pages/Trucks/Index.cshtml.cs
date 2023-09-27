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
    public class IndexModel : PageModel
    {
        private readonly FleetManagementSignalR.Data.FleetManagementSignalRContext _context;

        public IndexModel(FleetManagementSignalR.Data.FleetManagementSignalRContext context)
        {
            _context = context;
        }

        public IList<Truck> Truck { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Truck_1 != null)
            {
                Truck = await _context.Truck_1
                .Include(t => t.Make)
                .Include(t => t.Model).ToListAsync();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineCoursePlatform.Web.Data;
using OnlineCoursePlatform.Web.Models;

namespace OnlineCoursePlatform.Web.Pages_Subscriptions
{
    public class DetailsModel : PageModel
    {
        private readonly OnlineCoursePlatform.Web.Data.ApplicationDbContext _context;

        public DetailsModel(OnlineCoursePlatform.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Subscription Subscription { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Subscriptions == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscriptions.FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }
            else 
            {
                Subscription = subscription;
            }
            return Page();
        }
    }
}

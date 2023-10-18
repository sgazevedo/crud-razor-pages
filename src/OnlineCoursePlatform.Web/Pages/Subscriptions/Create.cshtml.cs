using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineCoursePlatform.Web.Data;
using OnlineCoursePlatform.Web.Models;

namespace OnlineCoursePlatform.Web.Pages_Subscriptions
{
    public class CreateModel : PageModel
    {
        private readonly OnlineCoursePlatform.Web.Data.ApplicationDbContext _context;

        public CreateModel(OnlineCoursePlatform.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Email");
            return Page();
        }

        [BindProperty]
        public Subscription Subscription { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Subscriptions == null || Subscription == null)
            {
                return Page();
            }

            _context.Subscriptions.Add(Subscription);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

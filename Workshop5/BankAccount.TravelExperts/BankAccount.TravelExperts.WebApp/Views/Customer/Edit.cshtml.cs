using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankAccount.TravelExperts.Data.Domain;

namespace BankAccount.TravelExperts.WebApp.Views.Customer
{
    public class EditModel : PageModel
    {
        private readonly BankAccount.TravelExperts.Data.Domain.TravelExpertsContext _context;

        public EditModel(BankAccount.TravelExperts.Data.Domain.TravelExpertsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customers Customers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customers = await _context.Customers
                .Include(c => c.Agent).FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customers == null)
            {
                return NotFound();
            }
           ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Customers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomersExists(Customers.CustomerId))
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

        private bool CustomersExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
    }
}

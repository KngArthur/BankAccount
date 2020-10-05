using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BankAccount.TravelExperts.Data.Domain;

namespace BankAccount.TravelExperts.WebApp.Views.Customer
{
    public class CreateModel : PageModel
    {
        private readonly BankAccount.TravelExperts.Data.Domain.TravelExpertsContext _context;

        public CreateModel(BankAccount.TravelExperts.Data.Domain.TravelExpertsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AgentId"] = new SelectList(_context.Agents, "AgentId", "AgentId");
            return Page();
        }

        [BindProperty]
        public Customers Customers { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

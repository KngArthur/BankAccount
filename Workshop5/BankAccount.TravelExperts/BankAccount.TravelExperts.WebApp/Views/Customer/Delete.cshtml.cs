﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankAccount.TravelExperts.Data.Domain;

namespace BankAccount.TravelExperts.WebApp.Views.Customer
{
    public class DeleteModel : PageModel
    {
        private readonly BankAccount.TravelExperts.Data.Domain.TravelExpertsContext _context;

        public DeleteModel(BankAccount.TravelExperts.Data.Domain.TravelExpertsContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customers = await _context.Customers.FindAsync(id);

            if (Customers != null)
            {
                _context.Customers.Remove(Customers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

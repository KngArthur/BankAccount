using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankAccount.TravelExperts.Data.Domain;

namespace BankAccount.TravelExperts.WebApp.Views.Customer
{
    public class IndexModel : PageModel
    {
        private readonly BankAccount.TravelExperts.Data.Domain.TravelExpertsContext _context;

        public IndexModel(BankAccount.TravelExperts.Data.Domain.TravelExpertsContext context)
        {
            _context = context;
        }

        public IList<Customers> Customers { get;set; }

        public async Task OnGetAsync()
        {
            Customers = await _context.Customers
                .Include(c => c.Agent).ToListAsync();
        }
    }
}

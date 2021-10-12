using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTestRjnm.Models
{
    public class PaymentHistoryContext : DbContext
    {
        public PaymentHistoryContext(DbContextOptions<PaymentHistoryContext> options) : base(options)
        {

        }
    
        public DbSet<Payment> Payments { get; set; }
    }
}

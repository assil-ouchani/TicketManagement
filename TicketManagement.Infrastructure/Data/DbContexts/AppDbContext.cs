using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagment.Domain.Entities;

namespace TicketManagement.Infrastructure.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }  

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}

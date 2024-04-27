using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TitanHelp.Models;

namespace TitanHelp.Data
{
    public class TitanHelpContext : DbContext
    {
        public TitanHelpContext (DbContextOptions<TitanHelpContext> options)
            : base(options)
        {
        }

        public DbSet<TitanHelp.Models.Ticket> Ticket { get; set; } = default!;
    }
}

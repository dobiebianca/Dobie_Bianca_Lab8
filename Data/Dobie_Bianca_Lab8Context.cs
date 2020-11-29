using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dobie_Bianca_Lab8.Models;

namespace Dobie_Bianca_Lab8.Data
{
    public class Dobie_Bianca_Lab8Context : DbContext
    {
        public Dobie_Bianca_Lab8Context (DbContextOptions<Dobie_Bianca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Dobie_Bianca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Dobie_Bianca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Dobie_Bianca_Lab8.Models.Category> Category { get; set; }
    }
}

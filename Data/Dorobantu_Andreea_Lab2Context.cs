using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dorobantu_Andreea_Lab2.Models;

namespace Dorobantu_Andreea_Lab2.Data
{
    public class Dorobantu_Andreea_Lab2Context : DbContext
    {
        public Dorobantu_Andreea_Lab2Context (DbContextOptions<Dorobantu_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dorobantu_Andreea_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Dorobantu_Andreea_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Dorobantu_Andreea_Lab2.Models.Category> Category { get; set; } = default!;
    }
}

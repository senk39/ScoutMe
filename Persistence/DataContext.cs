using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        
        }
        public DbSet<Value> Values { get; set; }

        public DbSet<IdolCharacter> IdolCharacters {get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value {Id = 1, Name = "Nico Yazawa"},
                new Value {Id = 2, Name = "Maki Nishikino"},
                new Value {Id = 3, Name = "Eli Ayase"},
                new Value {Id = 4, Name = "Honoka Kosaka"},
                new Value {Id = 5, Name = "Kotori Minami"},
                new Value {Id = 6, Name = "Hanayo Koizumi"},
                new Value {Id = 7, Name = "Umi Sonoda"},
                new Value {Id = 8, Name = "Rin Hoshizora"},
                new Value {Id = 9, Name = "Nozomi Tojo"}
                
                
            );
        }
    }
}

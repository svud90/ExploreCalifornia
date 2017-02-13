using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Special
    {
        public long Id { get; set; }

        public string Key { get; internal set; }
        public string Name { get; internal set; }
        public string Type { get; internal set; }
        public int Price { get; internal set; }
    }

    public class SpecialsDataContext : DbContext
    {
        public DbSet<Special> Specials{ get; set; }

        public SpecialsDataContext(DbContextOptions<SpecialsDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public IEnumerable<Special> GetMonthlySpecials(int num)
        {
            return Specials.OrderByDescending(x=>x.Id).Take(num).ToArray();
        }
    }
}

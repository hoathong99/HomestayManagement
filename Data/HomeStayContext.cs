using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeStayManagement.Model;

namespace HomeStayManagement.Data
{
    public class HomeStayContext : DbContext
    {
        public HomeStayContext (DbContextOptions<HomeStayContext> options)
            : base(options)
        {
        }

        public DbSet<HomeStayManagement.Model.Homestay>? Homestay { get; set; }

        public DbSet<HomeStayManagement.Model.Bill>? Bill { get; set; }
    }
}

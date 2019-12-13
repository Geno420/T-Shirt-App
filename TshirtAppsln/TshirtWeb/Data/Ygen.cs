using Microsoft.EntityFrameworkCore;
using TshirtWeb.Api.Modules;

namespace TshirtWeb.Api.Data

{
    public class Ygen : DbContext
    {

       
            public Ygen(DbContextOptions<Ygen> options)
                : base(options)
            {
            }

            public DbSet<RedBat> RedBats { get; set; }
        }












  }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Horvath_Mark_Ckiindulo
{
    public class AppContext : DbContext
    {
        //public DbSet<Pilot> pilots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=ADATBAZISNEVE;Uid=root;Pwd=;", ServerVersion.AutoDetect("Server=localhost;Database=ADATBAZISNEVE;Uid=root;Pwd=;"));
        }

    }
}

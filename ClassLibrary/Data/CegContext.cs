using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class CegContext : DbContext
    {
        public CegContext()
        {
        }
        public DbSet<Alkalmazott> Alkalmazott {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connMsSql = "Server=(localdb)\\MSSQLLocalDB;Database=Cegnyilvantartas;Trusted_Connection=True;";
            string connMySql = "Server=127.0.0.1;User ID=root;Password=;Database=Cegnyilvantartas;";
            optionsBuilder.UseMySql(connMySql, ServerVersion.AutoDetect(connMySql));

            //optionsBuilder.UseSqlServer(connMsSql);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Alkalmazott> Alkalmazott { get; set; } = default!;
    }
}

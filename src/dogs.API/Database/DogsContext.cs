using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogs.API.Model;
using Microsoft.EntityFrameworkCore;

namespace dogs.API.Database
{
    public class DogsContext : DbContext
    {
        public DogsContext(DbContextOptions<DogsContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set;}
    }
}
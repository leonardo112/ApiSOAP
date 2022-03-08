using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiSOAP.Models;

namespace ApiSOAP.Data
{
    public class ApiSOAPContext : DbContext
    {
        public ApiSOAPContext (DbContextOptions<ApiSOAPContext> options)
            : base(options)
        {
        }

        public DbSet<ApiSOAP.Models.Calculadora> Calculadora { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASPNetCore.Models
{
    public class EmployeContext : DbContext
    {
        public EmployeContext(DbContextOptions<EmployeContext>options) :base (options)
        { }
        public DbSet<Employe> Employes { get; set; }
    }
}

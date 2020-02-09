using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POneTest2.Models
{
    public class drbobContext : DbContext
    {
       public DbSet<Drbob> Drbobs { get; set; }
    }
}
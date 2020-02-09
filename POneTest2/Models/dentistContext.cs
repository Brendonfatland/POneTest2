using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POneTest2.Models
{
    public class dentistContext : DbContext
    {
       public DbSet<Dentist> Dentists { get; set;  }
    }
}
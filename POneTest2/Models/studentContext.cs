using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POneTest2.Models
{
    public class studentContext : DbContext
    {
        public DbSet<DentistData> Dentist { get; set; }
    }
}
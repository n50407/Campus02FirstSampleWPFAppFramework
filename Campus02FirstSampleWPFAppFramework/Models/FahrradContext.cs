using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus02FirstSampleWPFAppFramework.Models
{
    internal class FahrradContext: DbContext
    {
        public DbSet<Fahrrad> Fahrraeder { get; set; }
    }
}

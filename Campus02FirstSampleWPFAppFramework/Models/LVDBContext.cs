using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus02FirstSampleWPFAppFramework.Models
{
    internal class LVDBContext: DbContext
    {
        public DbSet<LV> LV { get; set; }
    }
}

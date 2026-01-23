using Campus02FirstSampleWPFAppFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus02FirstSampleWPFAppFramework.ViewModels
{
    internal class LVViewModel
    {
        private LVDBContext _context;
        public LVViewModel()
        {
                _context=new LVDBContext();
                MeineLVs=new List<LV>();
        }
        public void FillLVsFromDB()
        {
            MeineLVs = _context.LV.ToList();

        }
        public List<LV> MeineLVs{ get; set; }
        public void AddLV(LV lv)
        {
            MeineLVs.Add(lv);
            _context.LV.Add(lv);
            _context.SaveChanges();

        }
    }
}

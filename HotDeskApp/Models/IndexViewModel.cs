using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDeskApp.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Desk> Desks { get; set; }
        public Desk NewDesk { get; set; }
        public IEnumerable<Device> Devices { get; set; }
    }
}

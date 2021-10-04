using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotDeskApp.Models
{
    public class Device
    {
        public Device()
        {
            this.Desks = new HashSet<Desk>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Desk> Desks { get; set; }
    }
}

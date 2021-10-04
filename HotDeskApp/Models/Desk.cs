using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotDeskApp.Models
{
    public class Desk
    {
        public Desk()
        {
            this.Devices = new HashSet<Device>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Device> Devices { get; set; }
    }
}

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
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Device")]
        public virtual int DeviceId { get; set; }
        public virtual Device Device { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotDeskApp.Models
{
    public class UserDesk
    {
        [Key]
        public int Id { get; set; }
        public TimeSpan UsingTime { get; set; }
        public DateTime StartTime { get; set; }

        [ForeignKey("User")]
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Table")]
        public virtual int DeskId { get; set; }
        public virtual Desk Desk { get; set; }
        
    }
}

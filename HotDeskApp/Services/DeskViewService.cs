using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotDeskApp.Repo;
using HotDeskApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotDeskApp.Services
{
    public class DeskViewService : IRepositoryDesk<Desk>, IRepositoryDevice<Device>
    {
        private HotDeskDbContext db;

        public DeskViewService(HotDeskDbContext _db)
        {
            this.db = _db;
        }

        public void CreateDesk(Desk obj)
        {
            db.Desks.Add(obj);
            db.SaveChanges();
        }
        public void DeleteDesk(int Id)
        {
            Desk desk = db.Desks.Find(Id);
            if (desk != null)
            {
                db.Desks.Remove(desk);
                db.SaveChanges();
            }
        }

        public Desk FindDesk(int Id)
        {
            return db.Desks.Find(Id);
        }
        public void UpdateDesk(Desk obj)
        {
                db.Desks.Update(obj);
                db.SaveChanges();
        }

        public IEnumerable<Desk> GetDeskList()
        {
            return db.Desks.Include(a => a.Devices);
        }

        public IEnumerable<Device> GetDeviceList()
        {
            return db.Devices;
        }

        public Device GetDevice(int Id)
        {
            return db.Devices.Find(Id);
        }
    }
}

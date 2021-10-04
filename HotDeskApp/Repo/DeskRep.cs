using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotDeskApp.Models;

namespace HotDeskApp.Repo
{
    interface IRepositoryDesk<Desk>
    {
        IEnumerable<Desk> GetDeskList();
        void CreateDesk(Desk obj);
        Desk FindDesk(int Id);
        void DeleteDesk(int Id);
        void UpdateDesk(Desk obj);
    }
}

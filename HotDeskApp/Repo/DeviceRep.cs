using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotDeskApp.Models;

namespace HotDeskApp.Repo
{
    interface IRepositoryDevice<Device>
    {
        IEnumerable<Device> GetDeviceList();
        Device GetDevice(int Id);
    }
}

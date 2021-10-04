using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotDeskApp.Models;

namespace HotDeskApp.Repo
{
    interface IRepositoryUser<User>
    {
        User FindUser(string Login);
    }
}

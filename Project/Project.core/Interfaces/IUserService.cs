using Project.datalayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.core.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);

        int GetUserRole(string email);
    }
}

using backend.services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.core.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}

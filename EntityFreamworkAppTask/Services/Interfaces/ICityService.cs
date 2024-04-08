using EntityFreamworkAppTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFreamworkAppTask.Services.Interfaces
{
    internal interface ICityService
    {
        Task CreateAsync(City newCity);
    }
}

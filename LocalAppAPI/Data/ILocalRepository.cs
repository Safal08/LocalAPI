using LocalAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalAppAPI.Data
{
    public interface ILocalRepository
    {
        IEnumerable<Local> GetAllDetails();
        Local GetDetailsByName(string Name);
    }
}

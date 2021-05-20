using LocalAppAPI.Doman;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LocalAppAPI.Services
{
    public interface ILocalService
    {
        Task<IEnumerable<Local>> GetOrganizationDetails();
        Task<Local> GetOrganizationDetailsByName(string Name);
    }
}

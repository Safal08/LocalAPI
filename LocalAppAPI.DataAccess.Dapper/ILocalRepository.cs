using LocalAppAPI.Doman;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LocalAppAPI.DataAccess.Dapper
{
    public interface ILocalRepository
    {
        Task<IEnumerable<Local>> GetOrganizationDetailsAsync();
        Task<Local> GetOrganizationDetailsByNameAsync(string Name);
    }
}

using LocalAppAPI.DataAccess.Dapper;
using LocalAppAPI.Doman;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocalAppAPI.Services
{
    public class LocalService : ILocalService
    {
        private readonly ILocalRepository _localRepository;

        public LocalService(ILocalRepository localRepository)
        {
            _localRepository = localRepository;
        }

        public Task<IEnumerable<Local>> GetOrganizationDetails()
        {
            return _localRepository.GetOrganizationDetailsAsync();
        }

        public Task<Local> GetOrganizationDetailsByName(string Name)
        {
            return _localRepository.GetOrganizationDetailsByNameAsync(Name);
        }
    }
}

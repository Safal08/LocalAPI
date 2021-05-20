using Dapper;
using LocalAppAPI.Doman;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace LocalAppAPI.DataAccess.Dapper
{
    public class LocalRepository : ILocalRepository
    {
        private readonly IConfiguration _config;

        public LocalRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(_config.GetConnectionString("AvishkaramDbConnection"));
            }
        }

        public async Task<IEnumerable<Local>> GetOrganizationDetailsAsync()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    string query = @"select o.name,o.OrganizationID,u.UserID,u.UserTypeID,u.Title,u.First_Name,u.Middle_Name,u.Last_name,u.Email,u.phone,u.TimeZone,u.ThirdPartyID,u.Description,u.IsActive,u.IsDeleted,u.CreationDate,u.ModifiedDate,u.userObjectID
                                     from avishkaram.tblorganizations o left join avishkaram.tblusers u on o.OrganizationID=u.OrganizationID where u.IsActive = 1 order by o.name;";
                    return await dbConnection.QueryAsync<Local>(query);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<Local> GetOrganizationDetailsByNameAsync(string Name)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    string query = @"select o.name,o.OrganizationID, u.UserID,u.UserTypeID,u.Title,
                                        u.First_Name,u.Middle_Name,u.Last_name,u.Email,u.phone,u.TimeZone,
                                        u.ThirdPartyID,u.Description,u.IsActive,u.IsDeleted,u.CreationDate,u.ModifiedDate,
                                        u.userObjectID from avishkaram.tblorganizations o left join avishkaram.tblusers u on o.OrganizationID=u.OrganizationID where u.IsActive = 1 AND name = organizationName order by o.name;";
                    return await dbConnection.QueryFirstOrDefaultAsync<Local>(query, new { OrganizatioName = Name });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
                
    }
}

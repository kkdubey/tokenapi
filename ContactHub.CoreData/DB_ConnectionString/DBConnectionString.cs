using System;
using System.Configuration;

namespace ContactHub.CoreData.DB_ConnectionString
{
    public class DBConnectionStringFields
    {
        protected string _serverName = @"DESKTOP-2VOK5FT";
        protected string _database = @"ContactHubDB";
        protected bool _integratedSecurity = true;
        protected string _provider = "System.Data.SqlClient";
    }

    public class DBConnectionString : DBConnectionStringFields
    {
        public static ConnectionStringSettings ConnectionString;
        public DBConnectionString()
        {
            ConnectionString = GetConnectionString();
        }
        private ConnectionStringSettings GetConnectionString()
        {
            var connectionString = new ConnectionStringSettings()
            {
                Name = _serverName,
                ConnectionString = $"Data Source={_serverName};Initial Catalog={_database};Interated Security={_integratedSecurity}",
                ProviderName = _provider
            };
            return connectionString;
        }
    }

    
}

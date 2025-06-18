using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.Builder
{
    public class ConnectionStringBuilder : IConnectionStringBuilder
    {
        private ConnectionString ConnectionString;
        private string _serverName;
        private string _databaseName;
        private string _databasePassword;
        private bool _encryption; 
        private bool _trustServerCertificate;
        private int _connectionTimeout;
        private AuthenticationType _authenticationType;

        public ConnectionString Build()
        {
            this.ConnectionString = new ConnectionString(
                _serverName,
                _databaseName,
                _databasePassword,
                _authenticationType,
                _encryption,
                _trustServerCertificate,
                _connectionTimeout
            );
            return this.ConnectionString;
        }

        public IConnectionStringBuilder SetAuthenticationType(AuthenticationType authenticationType)
        {
            this._authenticationType = authenticationType;
            return this;
        }

        public IConnectionStringBuilder SetConnectionTimeout(int connectionTimeout)
        {
            this._connectionTimeout = connectionTimeout;
            return this;
        }

        public IConnectionStringBuilder SetDatabaseName(string databaseName)
        {
            this._databaseName = databaseName;
            return this;
        }

        public IConnectionStringBuilder SetDatabasePassword(string databasePassword)
        {
            this._databasePassword = databasePassword;
            return this;
        }

        public IConnectionStringBuilder SetEncryption(bool encryption)
        {
            this._encryption = encryption;
            return this;
        }

        public IConnectionStringBuilder SetServerName(string serverName)
        {
            this._serverName = serverName;
            return this;
        }

        public IConnectionStringBuilder SetTrustServerCertificate(bool trustServerCertificate)
        {
            this._trustServerCertificate = trustServerCertificate;
            return this;
        }
    }
}

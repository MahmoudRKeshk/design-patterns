using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.Builder
{
    public enum AuthenticationType
    {
        Integrated,
        SQLAdmin
    }
    public class ConnectionString
    {
        // Fields
        private readonly string _serverName;
        private readonly string _databaseName;
        private readonly string _databasePassword;
        private readonly bool _encryption; 
        private readonly bool _trustServerCertificate;
        private readonly int _connectionTimeout;
        private readonly AuthenticationType _authenticationType;

        // Connection String
        private string _connectionString;

        // Constructor
        public ConnectionString(
            string serverName,
            string databaseName, 
            string databasePassword,
            AuthenticationType authenticationType,
            bool encryption, 
            bool trustServerCertificate,
            int connectionTimeout
        )
        {
            this._serverName = serverName;
            this._databaseName = databaseName;
            this._databasePassword = databasePassword;
            this._authenticationType = authenticationType;
            this._encryption = encryption;
            this._trustServerCertificate = trustServerCertificate;
            this._connectionTimeout = connectionTimeout;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Server={_serverName};");
            sb.Append($"Database={_databaseName};");
            if (_authenticationType == AuthenticationType.SQLAdmin)
            {
                sb.Append($"User Id=admin;Password={_databasePassword};");
            }
            else
            {
                sb.Append("Integrated Security=True;");
            }
            sb.Append($"Encrypt={_encryption};");
            sb.Append($"TrustServerCertificate={_trustServerCertificate};");
            sb.Append($"Connection Timeout={_connectionTimeout};");
            _connectionString = sb.ToString();
            return _connectionString;
        }
    }
}

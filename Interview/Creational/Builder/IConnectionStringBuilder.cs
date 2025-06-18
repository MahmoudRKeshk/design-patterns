using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.Builder
{
    public interface IConnectionStringBuilder
    {
        IConnectionStringBuilder SetServerName(string serverName);
        IConnectionStringBuilder SetDatabaseName(string databaseName);
        IConnectionStringBuilder SetDatabasePassword(string databasePassword);
        IConnectionStringBuilder SetAuthenticationType(AuthenticationType authenticationType);
        IConnectionStringBuilder SetEncryption(bool encryption);
        IConnectionStringBuilder SetTrustServerCertificate(bool trustServerCertificate);
        IConnectionStringBuilder SetConnectionTimeout(int connectionTimeout);
        ConnectionString Build();
    }
}

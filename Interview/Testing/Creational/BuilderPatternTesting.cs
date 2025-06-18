using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Creational
{
    public static class BuilderPatternTesting
    {
        public static void Run()
        {
            // Create a connection string using the builder pattern
            var connectionStringBuilder = new Interview.Creational.Builder.ConnectionStringBuilder()
                .SetServerName("localhost")
                .SetDatabaseName("TestDB")
                .SetDatabasePassword("password123")
                .SetAuthenticationType(Interview.Creational.Builder.AuthenticationType.SQLAdmin)
                .SetEncryption(true)
                .SetTrustServerCertificate(false)
                .SetConnectionTimeout(30);
            var connectionString = connectionStringBuilder.Build();
            // Output the connection string
            Console.WriteLine(connectionString.ToString());
        }
    }
}

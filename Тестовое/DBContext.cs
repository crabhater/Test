using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Тестовое
{
	internal class DBContext
	{
		public static string connectionString { get { return builder.ConnectionString; } }
		public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
		{
			DataSource = @"(localdb)\MSSQLLocalDB",
			InitialCatalog = @"TestDB",
			IntegratedSecurity = true,
			Pooling = true
		};
		


	}
}

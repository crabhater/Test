using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое
{
	internal static class DBManager
	{
		private static string connectionString = DBContext.connectionString;

		public static void Prepairing()
		{
			string createTablesExp = "CREATE TABLE DO\r\n(do_id INT PRIMARY KEY IDENTITY, \r\ndo_name NVARCHAR(50),\r\n\"date\" NVARCHAR(50), \r\ncontragent_id INT NOT NULL\r\n);\r\n\r\n" +
				"CREATE TABLE SpecDO\r\n(specdo_id INT PRIMARY KEY IDENTITY, \r\ndo_id INT NOT NULL, \r\n\"name\" NVARCHAR(50), \r\n\"sum\" INT\r\n);\r\n\r\n" +
				"CREATE TABLE Invoice\r\n(invoice_id INT PRIMARY KEY IDENTITY, \r\ndo_id INT NOT NULL, \r\ninvoice_name NVARCHAR(50), \r\n\"date\" NVARCHAR(50), \r\ncontragent_id INT NOT NULL\r\n);\r\n\r\n" +
				"CREATE TABLE SpecInvoice\r\n(specinvoice_id INT PRIMARY KEY IDENTITY, \r\ninvoice_id INT NOT NULL, \r\n\"name\" NVARCHAR(50), \r\n\"sum\" INT\r\n);\r\n\r\n" +
				"CREATE TABLE Contragent\r\n(contragent_id INT PRIMARY KEY IDENTITY, \r\ncontragent_name NVARCHAR(50), \r\ninn NVARCHAR(50), \r\nkpp NVARCHAR(50)\r\n);\r\n\r\n" +
				"CREATE TABLE Region\r\n(region_id INT PRIMARY KEY IDENTITY, \r\nregion_code NVARCHAR(50), \r\nregion_name NVARCHAR(50), \r\nzone_name NVARCHAR(50), \r\nperson_id INT NOT NULL\r\n);\r\n\r\n" +
				"CREATE TABLE Person\r\n(person_id INT PRIMARY KEY IDENTITY, \r\nfio NVARCHAR(50)\r\n);";
			using(SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand(createTablesExp, conn);
				cmd.ExecuteNonQuery();
			}
		}

		public static int FillDO(List<DO> DOList)
		{
			string sqlExp = "SET IDENTITY_INSERT DO ON; INSERT INTO DO (do_id, do_name, date, contragent_id) VALUES (@do_id, @do_name, @date, @contragent_id)";
			int rowsAdded = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExp, connection);

				foreach (DO DO in DOList)
				{
					command.Parameters.Add(new SqlParameter("@do_id", DO.do_id));
					command.Parameters.Add(new SqlParameter("do_name", DO.do_name));
					command.Parameters.Add(new SqlParameter("date", DO.date));
					command.Parameters.Add(new SqlParameter("contragent_id", DO.contragent_id));

					rowsAdded += command.ExecuteNonQuery();

					command.Parameters.Clear();
				}
			}
			return rowsAdded;
		}

		public static int FillSpecDO(List<SpecDO> SpecDoList)
		{

			string sqlExp = "SET IDENTITY_INSERT SpecDO ON; INSERT INTO SpecDO (specdo_id, do_id, name, sum) VALUES (@specdo_id, @do_id, @name, @sum)";
			int rowsAdded = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExp, connection);

				foreach (SpecDO specDO in SpecDoList)
				{
					command.Parameters.Add(new SqlParameter("@specdo_id", specDO.specdo_id));
					command.Parameters.Add(new SqlParameter("@do_id", specDO.do_id));
					command.Parameters.Add(new SqlParameter("@name", specDO.name));
					command.Parameters.Add(new SqlParameter("@sum", specDO.sum));

					rowsAdded += command.ExecuteNonQuery();

					command.Parameters.Clear();
				}
			}
			return rowsAdded;
		}

		public static int FillInvoice(List<Invoice> InvoiceList)
		{

			string sqlExp = "SET IDENTITY_INSERT Invoice ON; INSERT INTO Invoice (invoice_id, do_id, invoice_name, date, contragent_id) VALUES (@invoice_id, @do_id, @invoice_name, @date, @contragent_id)";
			int rowsAdded = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExp, connection);

				foreach (Invoice invoice in InvoiceList)
				{
					command.Parameters.Add(new SqlParameter("@invoice_id", invoice.invoice_id));
					command.Parameters.Add(new SqlParameter("@do_id", invoice.do_id));
					command.Parameters.Add(new SqlParameter("@invoice_name", invoice.invoice_name));
					command.Parameters.Add(new SqlParameter("@date", invoice.date));
					command.Parameters.Add(new SqlParameter("@contragent_id", invoice.contragent_id));

					rowsAdded += command.ExecuteNonQuery();

					command.Parameters.Clear();
				}
			}
			return rowsAdded;
		}

		public static int FillSpecInvoice(List<SpecInvoice> SpecInvoiceList)
		{

			string sqlExp = "SET IDENTITY_INSERT SpecInvoice ON; INSERT INTO SpecInvoice (specinvoice_id, invoice_id, name, sum) VALUES (@specinvoice_id, @invoice_id, @name, @sum)";
			int rowsAdded = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExp, connection);

				foreach (SpecInvoice specInvoice in SpecInvoiceList)
				{
					command.Parameters.Add(new SqlParameter("@specinvoice_id", specInvoice.specinvoice_id));
					command.Parameters.Add(new SqlParameter("@invoice_id", specInvoice.invoice_id));
					command.Parameters.Add(new SqlParameter("@name", specInvoice.name));
					command.Parameters.Add(new SqlParameter("@sum", specInvoice.sum));

					rowsAdded += command.ExecuteNonQuery();

					command.Parameters.Clear();
				}
			}
			return rowsAdded;
		}

		public static int FillContragent(List<Contragent> ContragentList)
		{

			string sqlExp = "SET IDENTITY_INSERT Contragent ON; INSERT INTO Contragent (contragent_id, contragent_name, inn, kpp) VALUES (@contragent_id, @contragent_name, @inn, @kpp)";
			int rowsAdded = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExp, connection);

				foreach (Contragent contragent in ContragentList)
				{
					command.Parameters.Add(new SqlParameter("@contragent_id", contragent.contragent_id));
					command.Parameters.Add(new SqlParameter("@contragent_name", contragent.contragent_name));
					command.Parameters.Add(new SqlParameter("@inn", contragent.inn));
					command.Parameters.Add(new SqlParameter("@kpp", contragent.kpp));

					rowsAdded += command.ExecuteNonQuery();

					command.Parameters.Clear();
				}
			}
			return rowsAdded;
		}

		public static int FillRegion(List<Region> RegionList)
		{

			string sqlExp = "SET IDENTITY_INSERT Region ON; INSERT INTO Region (region_id, region_code, region_name, zone_name, person_id) VALUES (@region_id, @region_code, @region_name, @zone_name, @person_id)";
			int rowsAdded = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExp, connection);

				foreach (Region region in RegionList)
				{
					command.Parameters.Add(new SqlParameter("@region_id", region.region_id));
					command.Parameters.Add(new SqlParameter("@region_code", region.region_code));
					command.Parameters.Add(new SqlParameter("@region_name", region.region_name));
					command.Parameters.Add(new SqlParameter("@zone_name", region.zone_name));
					command.Parameters.Add(new SqlParameter("@person_id", region.person_id));

					rowsAdded += command.ExecuteNonQuery();

					command.Parameters.Clear();
				}
			}
			return rowsAdded;
		}

		public static int FillPerson(List<Person> PersonList)
		{

			string sqlExp = "SET IDENTITY_INSERT Person ON; INSERT INTO Person (person_id, fio) VALUES (@person_id, @fio)";
			int rowsAdded = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sqlExp, connection);

				foreach (Person person in PersonList)
				{
					command.Parameters.Add(new SqlParameter("@person_id", person.person_id));
					command.Parameters.Add(new SqlParameter("@fio", person.fio));

					rowsAdded += command.ExecuteNonQuery();

					command.Parameters.Clear();
				}
			}
			return rowsAdded;
		}
	}
}

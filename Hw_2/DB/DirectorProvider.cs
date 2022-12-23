using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hw_2.DB
{
	internal class DirectorProvider
	{
		private const string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;";
		private SqlConnection connection = new SqlConnection(ConnectionString);

		public void Create(string name, string surname)
		{
			connection.Open();
			string query = $"INSERT INTO dbo.directors(id, name, surname) VALUES (NEWID(), '{name}' ,'{surname}')";
			SqlCommand command = new SqlCommand(query, connection);
			command.ExecuteNonQuery();
			command.Dispose();
			connection.Close();
		}

		public void Read()
		{
			connection.Open();
			string querry = "SELECT * FROM dbo.directors";
			SqlCommand command = new SqlCommand(querry, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Console.WriteLine($"{reader["id"]} - {reader["name"]} - {reader["surname"]}");
			}
			reader.Close();
			command.Dispose();
			connection.Close();
		}

		public void Update(Guid id, string name, string surname)
		{
			connection.Open();
			string query = $"UPDATE dbo.directors SET name = '{name}', surname = '{surname}' WHERE id = '{id}'";
			SqlCommand command = new SqlCommand(query, connection);
			command.ExecuteNonQuery();
			command.Dispose();
			connection.Close();
		}

		public void Delete(Guid id)
		{
			connection.Open();
			string query = $"DELETE FROM dbo.directors WHERE id = '{id}'";
			SqlCommand command = new SqlCommand(query, connection);
			command.ExecuteNonQuery();
			command.Dispose();
			connection.Close();
		}
	}
}

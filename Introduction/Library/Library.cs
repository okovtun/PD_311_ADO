using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Library
{
	class Library
	{
		/*const string connectionString = @"
						Data Source=(localdb)\MSSQLLocalDB;
						Initial Catalog=Library_PD_311;
						Integrated Security=True;
						Connect Timeout=30;
						Encrypt=False;
						TrustServerCertificate=False;
						ApplicationIntent=ReadWrite;
						MultiSubnetFailover=False";*/
		static readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString_2_Library_PD_311"].ConnectionString;
		static SqlConnection connection;
		static Library()
		{
			Console.WriteLine(connectionString);
			connection = new SqlConnection(connectionString);
		}

		public static void InsertBook(string title, string first_name, string last_name)
		{
			//int author = GetAuthorID(first_name, last_name);
			string cmd = $@"
IF NOT EXISTS (SELECT book_id FROM Books WHERE author=@author AND title=@title)
BEGIN
		INSERT Books(title,author) 
		VALUES (@title, @author)
END
";
			SqlCommand command = new SqlCommand(cmd, connection);
			command.Parameters.Add("@title", SqlDbType.NVarChar, 256).Value = title;
			command.Parameters.Add("@author", SqlDbType.Int).Value = GetAuthorID(first_name, last_name);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public static int GetAuthorID(string first_name, string last_name)
		{
			//string cmd = $"(SELECT author_id FROM Authors WHERE first_name={first_name} AND last_name={last_name})";
			string cmd = $"(SELECT author_id FROM Authors WHERE first_name=@first_name AND last_name=@last_name)";
			SqlCommand command = new SqlCommand(cmd, connection);
			//command.Parameters.AddWithValue("@first_name", first_name);	//Deprecated
			//command.Parameters.AddWithValue("@last_name", last_name);		//Deprecated
			command.Parameters.Add("@first_name", SqlDbType.NVarChar, 150).Value = first_name;
			command.Parameters.Add("@last_name", SqlDbType.NVarChar, 150).Value = last_name;
			connection.Open();
			int author_id = Convert.ToInt32(command.ExecuteScalar());
			connection.Close();
			return author_id;
		}
		public static void InsertAuthor(string first_name, string last_name)
		{
			string cmd = $"INSERT Authors(first_name,last_name) VALUES ('{first_name}','{last_name}')";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		//public static void Select(string columns, string tables, string condition)
		//{
		//	string cmd = $"SELECT {columns} FROM {tables} WHERE {condition}";
		//	SqlCommand command = new SqlCommand(cmd, connection);
		//	connection.Open();
		//	SqlDataReader reader = command.ExecuteReader();
		//	if (reader.HasRows)
		//	{
		//		int padding = 32;
		//		for (int i = 0; i < reader.FieldCount; i++) Console.Write(reader.GetName(i).PadRight(padding));
		//		Console.WriteLine("\n-----------------------------------------------------------------------\n");
		//		while (reader.Read())
		//		{
		//			for (int i = 0; i < reader.FieldCount; i++)
		//			{
		//				Console.Write(reader[i].ToString().PadRight(padding));
		//			}
		//			Console.WriteLine();
		//		}
		//	}
		//	reader.Close();
		//	connection.Close();
		//}
		public static void SelectBooks()
		{
			string cmd = "SELECT title, first_name, last_name FROM Books,Authors WHERE author=author_id";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				int padding = 32;
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
					}
					Console.WriteLine();
					//Console.WriteLine("\n-----------------------------------------------------\n");
				}
				Console.WriteLine();
			}
			reader.Close();
			connection.Close();
		}
		public static void SelectAuthors()
		{
			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			//command.Parameters.AddWithValue("@id", "author_id");
			//command.Parameters.AddWithValue("@first_name", "first_name");
			//command.Parameters.AddWithValue("@last_name", "last_name");
			//command.Parameters.AddWithValue("@Table", "Authors");

			//command.Parameters.Add("@last_name", SqlDbType.NVarChar).Value = "last_name";
			//command.Parameters.Add("@first_name", SqlDbType.NVarChar).Value = "first_name";
			//command.Parameters.AddWithValue("@Table", "Authors");
			//command.CommandText = "SELECT quotename(@first_name), @last_name FROM Authors";
			command.CommandText = "SELECT first_name, last_name FROM Authors";

			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			const int padding = 16;
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();
				while (reader.Read())
				{
					//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
					for (int i = 0; i < reader.FieldCount; i++)
						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
					Console.WriteLine();
				}
			}
			reader.Close();
			connection.Close();
			Console.WriteLine("Authors DONE");
		}
	}
}

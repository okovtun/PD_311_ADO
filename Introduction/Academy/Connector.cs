using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Management;
using System.Configuration;

namespace Academy
{
	class Connector
	{
		static readonly string connectionString = ConfigurationManager.ConnectionStrings["Academy_PD_311"].ConnectionString;
		static SqlConnection connection;
		public static Dictionary<string, int> LearningForms;
		public static Dictionary<string, int> Directions;
		static Connector()
		{
			//connectionString = ConfigurationManager.ConnectionStrings["Academy_PD_311"].ConnectionString;
			connection = new SqlConnection(connectionString);

			LearningForms = LoadTableToDiscionary("form_id", "form_name", "LearningForms");
			Directions = LoadTableToDiscionary("direction_id", "direction_name", "Directions");
		}
		public static Dictionary<string, int> LoadTableToDiscionary(string id, string value, string table)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			string cmd = $"SELECT {id}, {value} FROM {table}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					dictionary.Add(reader[1].ToString(), Convert.ToInt32(reader[0]));
				}
			}
			reader.Close();
			connection.Close();
			return dictionary;
		}
		public static DataTable Select(string columns, string tables, string condition = "")
		{
			DataTable table = new DataTable();
			string cmd = $"SELECT {columns} FROM {tables}";
			if (condition.Length > 0) cmd += $" WHERE {condition}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
					table.Columns.Add(reader.GetName(i));
				while (reader.Read())
				{
					DataRow row = table.NewRow();
					for (int i = 0; i < reader.FieldCount; i++)
						row[i] = reader[i];
					table.Rows.Add(row);
				}
			}
			reader.Close();
			connection.Close();
			return table;
		}
		public static List<string> SelectColumn(string column, string table)
		{
			List<string> values = new List<string>();
			string cmd = $"SELECT {column} FROM {table}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					values.Add(reader[0].ToString());
				}
			}
			reader.Close();
			connection.Close();
			return values;
		}
		public static void InsertGroup(Group group)
		{
			string cmd =
"IF NOT EXISTS (SELECT group_id FROM Groups WHERE group_name=@group_name)" +
" BEGIN" +
	" INSERT Groups	(group_name,   [start_date],  learning_time,  direction,  learning_form,  learning_days)" +
	$" VALUES		(@group_name, @start_date, @learning_time, @direction, @learning_form, @learning_days)" +
" END";
			SqlCommand command = new SqlCommand(cmd, connection);
			command.Parameters.Add("@group_name",	SqlDbType.NVarChar, 16).Value = group.GroupName;
			command.Parameters.Add("@start_date",	SqlDbType.Date).Value = group.StartDate;
			command.Parameters.Add("@learning_time",SqlDbType.Time).Value = group.LearningTime;
			command.Parameters.Add("@direction",	SqlDbType.SmallInt).Value = group.Direction;
			command.Parameters.Add("@learning_form",SqlDbType.TinyInt).Value = group.LearningForm;
			command.Parameters.Add("@learning_days",SqlDbType.TinyInt).Value = group.LearningDays;
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Management;
using System.Configuration;
using System.Windows.Forms;

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
		public static object[] UpdateGroup(Group group)
		{
			string updateCmd =
"UPDATE Groups SET " +
				"group_name=@group_name," +
				"start_date=@start_date," +
				"learning_time=@learning_time," +
				"direction=@direction," +
				"learning_form=@learning_form," +
				"learning_days=@learning_days" +
	$" WHERE group_id={group.ID}";
			SqlCommand command = new SqlCommand(updateCmd, connection);
			command.Parameters.Add("@group_name", SqlDbType.NVarChar, 16).Value = group.GroupName;
			command.Parameters.Add("@start_date", SqlDbType.Date).Value = group.StartDate;
			command.Parameters.Add("@learning_time", SqlDbType.Time).Value = group.LearningTime;
			command.Parameters.Add("@direction", SqlDbType.SmallInt).Value = group.Direction;
			command.Parameters.Add("@learning_form", SqlDbType.TinyInt).Value = group.LearningForm;
			command.Parameters.Add("@learning_days", SqlDbType.TinyInt).Value = group.LearningDays;

			//		string selectCmd =
			//$"SELECT group_id,group_name,start_date,learning_time,direction_name,form_name,learning_days " +
			//$"FROM Groups,Directions,LearningForms " +
			//$"WHERE group_id={group.ID} AND direction=direction_id AND learning_form=form_id";
			//		SqlCommand selectCommand = new SqlCommand(selectCmd, connection);

			//		connection.Open();
			//		command.ExecuteNonQuery();
			//		SqlDataReader reader = selectCommand.ExecuteReader();
			//		DataTable table = new DataTable();
			//		for (int i = 0; i < reader.FieldCount; i++)
			//			table.Columns.Add(reader.GetName(i));
			//		reader.Read();
			//		DataRow row = table.NewRow();
			//		for (int i = 0; i < reader.FieldCount; i++)
			//			row[i] = reader[i];
			//		table.Rows.Add(row);
			//		reader.Close();
			//		connection.Close();
			//		Console.WriteLine(table.Rows[0].ItemArray);
			//		table.Rows[0][table.Columns.Count - 1] = 
			//			Week.ExtractDaysToString
			//			(
			//				Convert.ToByte(table.Rows[0][table.Columns.Count - 1])
			//			);
			//		return table.Rows[0].ItemArray;


			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			DataTable table = Select
				(
				"group_id,group_name,start_date,learning_time,direction_name,form_name,learning_days",
				"Groups,Directions,LearningForms",
				$"group_id={group.ID} AND direction=direction_id AND learning_form=form_id"
				);
			table.Rows[0][table.Columns.Count - 1] =
				Week.ExtractDaysToString
				(
					Convert.ToByte(table.Rows[0][table.Columns.Count - 1])
				);
			return table.Rows[0].ItemArray;
		}
	}
}

/*
---------------------------
DataSet:
	-DataTable
	-DataRelation
	-ExtendedProperties
---------------------------
DataTable:
	-DataRowCollection;
	-DataColumnCollection;
	-PrimaryKey;
	-ChildRelations;
	-ParentRelations;
	-Constraints;
	-ExtendedProperties;
	-DataView;
---------------------------
1. Создать:
	
2. Заполнить данными из Базы;
3. Выполнять навигацию;
---------------------------
 */
﻿using System;
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
		public static DataSet GroupsRelatedData = null;
		static Connector()
		{
			//connectionString = ConfigurationManager.ConnectionStrings["Academy_PD_311"].ConnectionString;
			connection = new SqlConnection(connectionString);

			LearningForms = LoadTableToDicionary("form_id", "form_name", "LearningForms");
			Directions = LoadTableToDicionary("direction_id", "direction_name", "Directions");

			//https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/dataset-datatable-dataview/adding-a-datatable-to-a-dataset
			GroupsRelatedData = new DataSet(nameof(GroupsRelatedData));
			GroupsRelatedData.Tables.Add("Directions");
			GroupsRelatedData.Tables["Directions"].Columns.Add("direction_id", typeof(byte));
			GroupsRelatedData.Tables["Directions"].Columns.Add("direction_name", typeof(string));
			GroupsRelatedData.Tables["Directions"].PrimaryKey = new DataColumn[] { GroupsRelatedData.Tables["Directions"].Columns["direction_id"] };

			GroupsRelatedData.Tables.Add("LearningForms");
			GroupsRelatedData.Tables["LearningForms"].Columns.Add("form_id", typeof(byte));
			GroupsRelatedData.Tables["LearningForms"].Columns.Add("form_name", typeof(string));
			GroupsRelatedData.Tables["LearningForms"].PrimaryKey = new DataColumn[] { GroupsRelatedData.Tables["LearningForms"].Columns["form_id"] };

			GroupsRelatedData.Tables.Add("Groups");
			GroupsRelatedData.Tables["Groups"].Columns.Add("group_id", typeof(int));
			GroupsRelatedData.Tables["Groups"].Columns.Add("group_name", typeof(string));
			GroupsRelatedData.Tables["Groups"].Columns.Add("start_date", typeof(DateTime));
			GroupsRelatedData.Tables["Groups"].Columns.Add("direction", typeof(byte));
			GroupsRelatedData.Tables["Groups"].Columns.Add("learning_form", typeof(byte));
			GroupsRelatedData.Tables["Groups"].Columns.Add("learning_days", typeof(byte));
			GroupsRelatedData.Tables["Groups"].PrimaryKey = new DataColumn[] { GroupsRelatedData.Tables["Groups"].Columns["group_id"] };

			GroupsRelatedData.Relations.Add
				(
				"GroupsDirection",
				GroupsRelatedData.Tables["Directions"].Columns["direction_id"],
				GroupsRelatedData.Tables["Groups"].Columns["direction"]
				);

			GroupsRelatedData.Relations.Add
				(
				"GroupsLearningForm",
				GroupsRelatedData.Tables["LearningForms"].Columns["form_id"],
				GroupsRelatedData.Tables["Groups"].Columns["learning_form"]
				);
		}
		public static Dictionary<string, int> LoadTableToDicionary(string id, string value, string table)
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
	$"WHERE group_id={group.ID}";
			SqlCommand command = new SqlCommand(updateCmd, connection);
			command.Parameters.Add("@group_name", SqlDbType.NVarChar, 16).Value = group.GroupName;
			command.Parameters.Add("@start_date", SqlDbType.Date).Value = group.StartDate;
			command.Parameters.Add("@learning_time", SqlDbType.Time).Value = group.LearningTime;
			command.Parameters.Add("@direction", SqlDbType.SmallInt).Value = group.Direction;
			command.Parameters.Add("@learning_form", SqlDbType.TinyInt).Value = group.LearningForm;
			command.Parameters.Add("@learning_days", SqlDbType.TinyInt).Value = group.LearningDays;

			string selectCmd =
	$"SELECT group_name,start_date,learning_time,direction,learning_form,learning_days " +
	$"FROM Groups WHERE group_id={group.ID}";
			SqlCommand selectCommand = new SqlCommand(selectCmd, connection);

			connection.Open();
			command.ExecuteNonQuery();
			SqlDataReader reader = selectCommand.ExecuteReader();
			DataTable table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
				table.Columns.Add(reader.GetName(i));
			reader.Read();
			DataRow row = table.NewRow();
			for (int i = 0; i < reader.FieldCount; i++)
				row[i] = reader[i];
			table.Rows.Add(row);
			reader.Close();
			connection.Close();
			Console.WriteLine(table.Rows[0].ItemArray);
			return table.Rows[0].ItemArray;
			
		}
	}
}

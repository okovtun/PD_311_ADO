using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace AcademyDataSet
{
	public partial class MainForm : Form
	{
		string connectionString = "";
		SqlConnection connection = null;
		DataSet GroupsRelatingData = null;
		public MainForm()
		{
			InitializeComponent();
			AllocConsole();
			connectionString = ConfigurationManager.ConnectionStrings["Academy_PD_311"].ConnectionString;
			Console.WriteLine(connectionString);
			connection = new SqlConnection(connectionString);

			//1) Создаем DataSet:
			GroupsRelatingData = new DataSet(nameof(GroupsRelatingData));

			//2) Добавляем таблицы в DataSet:
			const string dsTable_Directions = "Directions";
			const string dst_col_direction_id = "direction_id";
			const string dst_col_direction_name = "direction_name";
			GroupsRelatingData.Tables.Add(dsTable_Directions);
			GroupsRelatingData.Tables[dsTable_Directions].Columns.Add(dst_col_direction_id, typeof(short));
			GroupsRelatingData.Tables[dsTable_Directions].Columns.Add(dst_col_direction_name, typeof(string));
			GroupsRelatingData.Tables[dsTable_Directions].PrimaryKey =
				new DataColumn[] { GroupsRelatingData.Tables[dsTable_Directions].Columns[dst_col_direction_id] };

			const string dsTable_Groups = "Groups";
			const string dst_Groups_col_group_id = "group_id";
			const string dst_Groups_col_group_name = "group_name";
			const string dst_Groups_col_groups_direction = "direction";
			GroupsRelatingData.Tables.Add(dsTable_Groups);
			GroupsRelatingData.Tables[dsTable_Groups].Columns.Add(dst_Groups_col_group_id, typeof(int));
			GroupsRelatingData.Tables[dsTable_Groups].Columns.Add(dst_Groups_col_group_name, typeof(string));
			GroupsRelatingData.Tables[dsTable_Groups].Columns.Add(dst_Groups_col_groups_direction, typeof(short));
			GroupsRelatingData.Tables[dsTable_Groups].PrimaryKey =
				new DataColumn[] { GroupsRelatingData.Tables[dsTable_Groups].Columns[dst_Groups_col_group_id] };

			//3) Строим связи между таблицами:
			GroupsRelatingData.Relations.Add
				(
				"GroupsDirection",  //Relation name
				GroupsRelatingData.Tables["Directions"].Columns["direction_id"],    //Parent field
				GroupsRelatingData.Tables["Groups"].Columns["direction"]            //Child field
				);

			//4) Загрузка данных в DataSet:
			string directionsCmd = "SELECT * FROM Directions";
			string groupsCmd = "SELECT group_id, group_name, direction FROM Groups";
			SqlDataAdapter directionsAdapter = new SqlDataAdapter(directionsCmd, connection);
			SqlDataAdapter groupsAdapter = new SqlDataAdapter(groupsCmd, connection);

			connection.Open();
			directionsAdapter.Fill(GroupsRelatingData.Tables["Directions"]);
			groupsAdapter.Fill(GroupsRelatingData.Tables["Groups"]);
			connection.Close();



			foreach (DataRow row in GroupsRelatingData.Tables["Directions"].Rows)
			{
				Console.WriteLine($"{row["direction_id"]}\t{row["direction_name"]}");
			}
			Console.WriteLine("\n-----------------------------------------------------\n");
			for (int i = 0; i < GroupsRelatingData.Tables["Groups"].Rows.Count; i++)
			{
				for (int j = 0; j < GroupsRelatingData.Tables["Groups"].Columns.Count; j++)
				{
					Console.Write($"{GroupsRelatingData.Tables["Groups"].Rows[i][j].ToString().PadRight(16)}");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\n-----------------------------------------------------\n");

			for (int i = 0; i < GroupsRelatingData.Tables["Directions"].Rows.Count; i++)
			{
				Console.Write($"{GroupsRelatingData.Tables["Directions"].Rows[i]["direction_name"]}:");
				DataRow[] children = GroupsRelatingData.Tables["Directions"].Rows[i].GetChildRows("GroupsDirection");
				for (int j = 0; j < children.Length; j++)
				{
					Console.Write(children[j]["group_name"] + "\t");
				}
				Console.WriteLine(";");
			}
		}
		[DllImport("kernel32")]
		public static extern bool AllocConsole();
	}
}

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

namespace Library2
{
	public partial class MainForm : Form
	{
		readonly string connectionString = 
			ConfigurationManager.ConnectionStrings["ConnectionString_2_Library_PD_311"].ConnectionString;
		SqlConnection connection;
		public MainForm()
		{
			connection = new SqlConnection(connectionString);
			InitializeComponent();
			LoadTablesToComboBox();
		}
		void LoadTablesToComboBox()
		{
			string cmd = "SELECT table_name FROM information_schema.tables;";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					comboBoxTables.Items.Add(reader[0]);
				}
			}
			reader.Close();
			connection.Close();
		}

		private void buttonExecute_Click(object sender, EventArgs e)
		{
			string cmd = textBoxQuery.Text;
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			DataTable table = new DataTable();
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
				table.Columns.Add(reader.GetName(i));

			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
					row[i] = reader[i];
				table.Rows.Add(row);
			}
			reader.Close();
			connection.Close();
			dataGridView.DataSource = table;
		}

		private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView.DataSource = null;
			SelectAllFromTable((sender as ComboBox).Text);
		}
		void SelectAllFromTable(string table_name)
		{
			string cmd = $"SELECT * FROM [{table_name}]";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				DataTable table = new DataTable();
				for (int i = 0; i < reader.FieldCount; i++)
					table.Columns.Add(reader.GetName(i));
				while (reader.Read())
				{
					DataRow row = table.NewRow();
					for (int i = 0; i < reader.FieldCount; i++)
					{
						row[i] = reader[i];
					}
					table.Rows.Add(row);
				}
				dataGridView.DataSource = table;
			}
			reader.Close();
			connection.Close();
		}
	}
}

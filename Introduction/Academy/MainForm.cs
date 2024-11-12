using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			LoadStudents();
			LoadGroups();
		}
		void LoadStudents()
		{
			dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(SetStatusBarText);
			dataGridViewStudents.DataSource =
				Connector.Select(
					"student_id, last_name, first_name, middle_name, birth_date, group_name, direction_name", 
					"Students, Groups, Directions",
					"[group]=group_id AND direction=direction_id");
		}
		void LoadGroups()
		{
			dataGridViewGroups.Rows.CollectionChanged += new CollectionChangeEventHandler(SetStatusBarText);
			dataGridViewGroups.DataSource =
				Connector.Select(
					"group_name, COUNT(student_id) AS 'Количество студентов', direction_name",
					"Groups, Directions, Students",
					"direction=direction_id AND [group]=group_id GROUP BY [group_name], direction_name");

			comboBoxGroupDirection.Items.AddRange(Connector.Select("direction_name", "Directions").Rows.Cast<String>().ToArray());
		}
		void SetStatusBarText(object sender, EventArgs e)
		{
			toolStripStatusLabelStudentsCount.Text = $"Number of {tabControlMain.SelectedTab.Text.ToLower()}: {(sender as DataGridViewRowCollection).Count - 1}.";
			//toolStripStatusLabelStudentsCount.Text = $"Number of {tabControlMain.SelectedTab.Text.ToLower()}: {dataGridViewStudents.RowCount}.";
		}

		private void textBoxSearchStudent_TextChanged(object sender, EventArgs e)
		{
			string[] values = (sender as TextBox).Text.Split(' ');
			if(values.Length>1)
				values = values.Where(v => v != "").ToArray();
			string searchPattern = "";
			switch (values.Length)
			{
				case 1:searchPattern = $"(last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%') OR middle_name LIKE ('{values[0]}%'))"; break;
				case 2:searchPattern = $"((last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%')) AND (first_name LIKE  ('{values[1]}%') OR middle_name LIKE ('{values[1]}%')))"; break;
				case 3:searchPattern = $"(last_name LIKE ('{values[0]}%') AND first_name LIKE ('{values[1]}%') OR middle_name LIKE ('{values[2]}%'))"; break;
			}

			dataGridViewStudents.DataSource = Connector.Select
				(
					"last_name, first_name, middle_name, birth_date, group_name, direction_name",
					"Students, Directions, Groups",
					$"[group]=group_id AND direction=direction_id AND {searchPattern};"
				);
		}

		private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch ((sender as TabControl).SelectedTab.Text)
			{
				case "Students":	SetStatusBarText(dataGridViewStudents.Rows, e);	break;
				case "Groups":		SetStatusBarText(dataGridViewGroups.Rows, e);	break;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			SetStatusBarText(dataGridViewStudents.Rows, e);
		}
	}
}

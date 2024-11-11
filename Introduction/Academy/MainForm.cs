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
			dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(CountRows);
			dataGridViewStudents.DataSource =
				Connector.Select(
					"last_name, first_name, middle_name, birth_date, group_name, direction_name", 
					"Students, Groups, Directions",
					"[group]=group_id AND direction=direction_id");
		}
		void CountRows(object sender, EventArgs e)
		{
			toolStripStatusLabelStudentsCount.Text = $"Количество студентов: {dataGridViewStudents.RowCount}.";
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
	}
}

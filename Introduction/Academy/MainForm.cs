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
	}
}

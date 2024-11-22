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
	internal partial class AddGroupForm : Form
	{
		public Group Group { get; set; }
		public AddGroupForm()
		{
			InitializeComponent();
			//comboBoxLearningForm.Items.AddRange(Connector.SelectColumn("form_name", "LearningForms").ToArray());
			//comboBoxGroupDirection.Items.AddRange(Connector.SelectColumn("direction_name", "Directions").ToArray());
			comboBoxLearningForm.Items.AddRange(Connector.LearningForms.Keys.ToArray());
			comboBoxGroupDirection.Items.AddRange(Connector.Directions.Keys.ToArray());
			//SetWeekDays(96);
		}
		public byte GetWeekDays()
		{
			byte days = 0;
			byte day = 1;
			for (byte i = 0; i < checkedListBoxGroupDays.Items.Count; i++)
			{
				//Console.Write(checkedListBoxGroupDays.GetItemCheckState(i) + "\t");
				Console.Write(checkedListBoxGroupDays.GetItemChecked(i) + "\t");
				if (checkedListBoxGroupDays.GetItemChecked(i)) days |= (byte)(day << i); //checkedListBoxGroupDays.GetItemChecked(i);
																						 //day <<= 1;
			}

			Console.WriteLine(days);
			return days;
		}
		public void SetWeekDays(byte days)
		{
			for (byte i = 0; i < checkedListBoxGroupDays.Items.Count; i++)
				checkedListBoxGroupDays.SetItemChecked(i, (days & (1 << i)) != 0);
		}
		private void buttonSaveGroup_Click(object sender, EventArgs e)
		{
			byte days = GetWeekDays();
			//Group.GroupName = textBoxGroupName.Text;
			//Group.LearningDays = GetWeekDays();
			//Group.LearningForm = Connector.InsertGroup(Group);
			SaveGroup();
			Console.WriteLine(days);
		}
		public void ClearData()
		{
			textBoxGroupName.Text = "";
			comboBoxGroupDirection.SelectedIndex = -1;
			comboBoxLearningForm.SelectedIndex = -1;
			SetWeekDays(0);
		}
		public void Init(Group group)
		{
			Group = new Group(group);

			textBoxGroupName.Text = group.GroupName;
			comboBoxGroupDirection.SelectedIndex = group.Direction - 1;
			comboBoxLearningForm.SelectedIndex = group.LearningForm - 1;
			SetWeekDays(group.LearningDays);
			dateTimePickerGroupStart.Value = group.StartDate;
			dateTimePickerGroupTime.Value = DateTime.Now.Date + group.LearningTime;
		}
		public void SaveGroup()
		{
			Group.GroupName		= this.textBoxGroupName.Text;
			Group.StartDate		= this.dateTimePickerGroupStart.Value;
			Group.LearningTime	= this.dateTimePickerGroupTime.Value.TimeOfDay;
			Group.Direction		= this.comboBoxGroupDirection.SelectedIndex + 1;
			Group.LearningForm	= this.comboBoxLearningForm.SelectedIndex + 1;
			Group.LearningDays	= this.GetWeekDays();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			ClearData();
		}
	}
}

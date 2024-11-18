namespace Academy
{
	partial class AddGroupForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelGroupName = new System.Windows.Forms.Label();
			this.textBoxGroupName = new System.Windows.Forms.TextBox();
			this.labelGroupDirection = new System.Windows.Forms.Label();
			this.labelGroupTime = new System.Windows.Forms.Label();
			this.labelGroupDays = new System.Windows.Forms.Label();
			this.comboBoxGroupDirection = new System.Windows.Forms.ComboBox();
			this.dateTimePickerGroupTime = new System.Windows.Forms.DateTimePicker();
			this.checkedListBoxGroupDays = new System.Windows.Forms.CheckedListBox();
			this.labelLearningForm = new System.Windows.Forms.Label();
			this.comboBoxLearningForm = new System.Windows.Forms.ComboBox();
			this.labelStartDate = new System.Windows.Forms.Label();
			this.dateTimePickerGroupStart = new System.Windows.Forms.DateTimePicker();
			this.buttonSaveGroup = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelGroupName
			// 
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Location = new System.Drawing.Point(13, 17);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(99, 13);
			this.labelGroupName.TabIndex = 0;
			this.labelGroupName.Text = "Название группы:";
			// 
			// textBoxGroupName
			// 
			this.textBoxGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.textBoxGroupName.Location = new System.Drawing.Point(119, 13);
			this.textBoxGroupName.Name = "textBoxGroupName";
			this.textBoxGroupName.Size = new System.Drawing.Size(277, 20);
			this.textBoxGroupName.TabIndex = 1;
			// 
			// labelGroupDirection
			// 
			this.labelGroupDirection.AutoSize = true;
			this.labelGroupDirection.Location = new System.Drawing.Point(34, 61);
			this.labelGroupDirection.Name = "labelGroupDirection";
			this.labelGroupDirection.Size = new System.Drawing.Size(78, 13);
			this.labelGroupDirection.TabIndex = 2;
			this.labelGroupDirection.Text = "Направление:";
			// 
			// labelGroupTime
			// 
			this.labelGroupTime.AutoSize = true;
			this.labelGroupTime.Location = new System.Drawing.Point(249, 186);
			this.labelGroupTime.Name = "labelGroupTime";
			this.labelGroupTime.Size = new System.Drawing.Size(43, 13);
			this.labelGroupTime.TabIndex = 3;
			this.labelGroupTime.Text = "Время:";
			// 
			// labelGroupDays
			// 
			this.labelGroupDays.AutoSize = true;
			this.labelGroupDays.Location = new System.Drawing.Point(32, 142);
			this.labelGroupDays.Name = "labelGroupDays";
			this.labelGroupDays.Size = new System.Drawing.Size(80, 13);
			this.labelGroupDays.TabIndex = 4;
			this.labelGroupDays.Text = "Дни обучения:";
			// 
			// comboBoxGroupDirection
			// 
			this.comboBoxGroupDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroupDirection.FormattingEnabled = true;
			this.comboBoxGroupDirection.Location = new System.Drawing.Point(119, 57);
			this.comboBoxGroupDirection.Name = "comboBoxGroupDirection";
			this.comboBoxGroupDirection.Size = new System.Drawing.Size(277, 21);
			this.comboBoxGroupDirection.TabIndex = 5;
			// 
			// dateTimePickerGroupTime
			// 
			this.dateTimePickerGroupTime.CustomFormat = "HH:mm";
			this.dateTimePickerGroupTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerGroupTime.Location = new System.Drawing.Point(299, 182);
			this.dateTimePickerGroupTime.Name = "dateTimePickerGroupTime";
			this.dateTimePickerGroupTime.Size = new System.Drawing.Size(97, 20);
			this.dateTimePickerGroupTime.TabIndex = 6;
			// 
			// checkedListBoxGroupDays
			// 
			this.checkedListBoxGroupDays.CheckOnClick = true;
			this.checkedListBoxGroupDays.ColumnWidth = 38;
			this.checkedListBoxGroupDays.FormattingEnabled = true;
			this.checkedListBoxGroupDays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.checkedListBoxGroupDays.Location = new System.Drawing.Point(119, 139);
			this.checkedListBoxGroupDays.MultiColumn = true;
			this.checkedListBoxGroupDays.Name = "checkedListBoxGroupDays";
			this.checkedListBoxGroupDays.Size = new System.Drawing.Size(277, 19);
			this.checkedListBoxGroupDays.TabIndex = 7;
			// 
			// labelLearningForm
			// 
			this.labelLearningForm.AutoSize = true;
			this.labelLearningForm.Location = new System.Drawing.Point(16, 104);
			this.labelLearningForm.Name = "labelLearningForm";
			this.labelLearningForm.Size = new System.Drawing.Size(96, 13);
			this.labelLearningForm.TabIndex = 8;
			this.labelLearningForm.Text = "Форма обучения:";
			// 
			// comboBoxLearningForm
			// 
			this.comboBoxLearningForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLearningForm.FormattingEnabled = true;
			this.comboBoxLearningForm.Location = new System.Drawing.Point(119, 100);
			this.comboBoxLearningForm.Name = "comboBoxLearningForm";
			this.comboBoxLearningForm.Size = new System.Drawing.Size(277, 21);
			this.comboBoxLearningForm.TabIndex = 9;
			// 
			// labelStartDate
			// 
			this.labelStartDate.AutoSize = true;
			this.labelStartDate.Location = new System.Drawing.Point(29, 186);
			this.labelStartDate.Name = "labelStartDate";
			this.labelStartDate.Size = new System.Drawing.Size(83, 13);
			this.labelStartDate.TabIndex = 10;
			this.labelStartDate.Text = "Старт занятий:";
			// 
			// dateTimePickerGroupStart
			// 
			this.dateTimePickerGroupStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerGroupStart.Location = new System.Drawing.Point(119, 182);
			this.dateTimePickerGroupStart.Name = "dateTimePickerGroupStart";
			this.dateTimePickerGroupStart.Size = new System.Drawing.Size(97, 20);
			this.dateTimePickerGroupStart.TabIndex = 11;
			// 
			// buttonSaveGroup
			// 
			this.buttonSaveGroup.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSaveGroup.Location = new System.Drawing.Point(240, 219);
			this.buttonSaveGroup.Name = "buttonSaveGroup";
			this.buttonSaveGroup.Size = new System.Drawing.Size(75, 23);
			this.buttonSaveGroup.TabIndex = 12;
			this.buttonSaveGroup.Text = "Сохранить";
			this.buttonSaveGroup.UseVisualStyleBackColor = true;
			this.buttonSaveGroup.Click += new System.EventHandler(this.buttonSaveGroup_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(321, 219);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(19, 219);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(75, 23);
			this.buttonReset.TabIndex = 14;
			this.buttonReset.Text = "Сброс";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// AddGroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 254);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveGroup);
			this.Controls.Add(this.dateTimePickerGroupStart);
			this.Controls.Add(this.labelStartDate);
			this.Controls.Add(this.comboBoxLearningForm);
			this.Controls.Add(this.labelLearningForm);
			this.Controls.Add(this.checkedListBoxGroupDays);
			this.Controls.Add(this.dateTimePickerGroupTime);
			this.Controls.Add(this.comboBoxGroupDirection);
			this.Controls.Add(this.labelGroupDays);
			this.Controls.Add(this.labelGroupTime);
			this.Controls.Add(this.labelGroupDirection);
			this.Controls.Add(this.textBoxGroupName);
			this.Controls.Add(this.labelGroupName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddGroupForm";
			this.Text = "AddGroupForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGroupName;
		private System.Windows.Forms.Label labelGroupDirection;
		private System.Windows.Forms.Label labelGroupTime;
		private System.Windows.Forms.Label labelGroupDays;
		private System.Windows.Forms.Label labelLearningForm;
		private System.Windows.Forms.Label labelStartDate;
		internal System.Windows.Forms.TextBox textBoxGroupName;
		internal System.Windows.Forms.ComboBox comboBoxGroupDirection;
		internal System.Windows.Forms.DateTimePicker dateTimePickerGroupTime;
		internal System.Windows.Forms.CheckedListBox checkedListBoxGroupDays;
		internal System.Windows.Forms.ComboBox comboBoxLearningForm;
		internal System.Windows.Forms.DateTimePicker dateTimePickerGroupStart;
		private System.Windows.Forms.Button buttonSaveGroup;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonReset;
	}
}
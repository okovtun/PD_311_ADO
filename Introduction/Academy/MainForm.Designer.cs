namespace Academy
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.statusStripStudents = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
			this.labelSearchStudent = new System.Windows.Forms.Label();
			this.comboBoxStudentsGroup = new System.Windows.Forms.ComboBox();
			this.labelStudentsGroup = new System.Windows.Forms.Label();
			this.labelStudentsDirection = new System.Windows.Forms.Label();
			this.comboBoxStudentsDirection = new System.Windows.Forms.ComboBox();
			this.tabControlMain.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.statusStripStudents.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageStudents);
			this.tabControlMain.Controls.Add(this.tabPageGroups);
			this.tabControlMain.Controls.Add(this.tabPageDisciplines);
			this.tabControlMain.Controls.Add(this.tabPageTeachers);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(800, 450);
			this.tabControlMain.TabIndex = 0;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.comboBoxStudentsDirection);
			this.tabPageStudents.Controls.Add(this.labelStudentsDirection);
			this.tabPageStudents.Controls.Add(this.labelStudentsGroup);
			this.tabPageStudents.Controls.Add(this.comboBoxStudentsGroup);
			this.tabPageStudents.Controls.Add(this.labelSearchStudent);
			this.tabPageStudents.Controls.Add(this.textBoxSearchStudent);
			this.tabPageStudents.Controls.Add(this.statusStripStudents);
			this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(792, 424);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(792, 424);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(792, 424);
			this.tabPageDisciplines.TabIndex = 2;
			this.tabPageDisciplines.Text = "Disciplines";
			this.tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Size = new System.Drawing.Size(792, 424);
			this.tabPageTeachers.TabIndex = 3;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(6, 52);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(786, 338);
			this.dataGridViewStudents.TabIndex = 0;
			// 
			// statusStripStudents
			// 
			this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStudentsCount});
			this.statusStripStudents.Location = new System.Drawing.Point(3, 399);
			this.statusStripStudents.Name = "statusStripStudents";
			this.statusStripStudents.Size = new System.Drawing.Size(786, 22);
			this.statusStripStudents.TabIndex = 1;
			this.statusStripStudents.Text = "statusStrip1";
			// 
			// toolStripStatusLabelStudentsCount
			// 
			this.toolStripStatusLabelStudentsCount.Name = "toolStripStatusLabelStudentsCount";
			this.toolStripStatusLabelStudentsCount.Size = new System.Drawing.Size(191, 17);
			this.toolStripStatusLabelStudentsCount.Text = "toolStripStatusLabelStudentsCount";
			// 
			// textBoxSearchStudent
			// 
			this.textBoxSearchStudent.Location = new System.Drawing.Point(56, 15);
			this.textBoxSearchStudent.Name = "textBoxSearchStudent";
			this.textBoxSearchStudent.Size = new System.Drawing.Size(197, 20);
			this.textBoxSearchStudent.TabIndex = 2;
			// 
			// labelSearchStudent
			// 
			this.labelSearchStudent.AutoSize = true;
			this.labelSearchStudent.Location = new System.Drawing.Point(8, 19);
			this.labelSearchStudent.Name = "labelSearchStudent";
			this.labelSearchStudent.Size = new System.Drawing.Size(42, 13);
			this.labelSearchStudent.TabIndex = 3;
			this.labelSearchStudent.Text = "Поиск:";
			// 
			// comboBoxStudentsGroup
			// 
			this.comboBoxStudentsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxStudentsGroup.FormattingEnabled = true;
			this.comboBoxStudentsGroup.Location = new System.Drawing.Point(341, 15);
			this.comboBoxStudentsGroup.Name = "comboBoxStudentsGroup";
			this.comboBoxStudentsGroup.Size = new System.Drawing.Size(164, 21);
			this.comboBoxStudentsGroup.TabIndex = 4;
			// 
			// labelStudentsGroup
			// 
			this.labelStudentsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStudentsGroup.AutoSize = true;
			this.labelStudentsGroup.Location = new System.Drawing.Point(290, 19);
			this.labelStudentsGroup.Name = "labelStudentsGroup";
			this.labelStudentsGroup.Size = new System.Drawing.Size(45, 13);
			this.labelStudentsGroup.TabIndex = 5;
			this.labelStudentsGroup.Text = "Группа:";
			// 
			// labelStudentsDirection
			// 
			this.labelStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStudentsDirection.AutoSize = true;
			this.labelStudentsDirection.Location = new System.Drawing.Point(539, 19);
			this.labelStudentsDirection.Name = "labelStudentsDirection";
			this.labelStudentsDirection.Size = new System.Drawing.Size(78, 13);
			this.labelStudentsDirection.TabIndex = 6;
			this.labelStudentsDirection.Text = "Направление:";
			// 
			// comboBoxStudentsDirection
			// 
			this.comboBoxStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxStudentsDirection.FormattingEnabled = true;
			this.comboBoxStudentsDirection.Location = new System.Drawing.Point(623, 15);
			this.comboBoxStudentsDirection.Name = "comboBoxStudentsDirection";
			this.comboBoxStudentsDirection.Size = new System.Drawing.Size(161, 21);
			this.comboBoxStudentsDirection.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControlMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Academy";
			this.tabControlMain.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.statusStripStudents.ResumeLayout(false);
			this.statusStripStudents.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.StatusStrip statusStripStudents;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStudentsCount;
		private System.Windows.Forms.ComboBox comboBoxStudentsDirection;
		private System.Windows.Forms.Label labelStudentsDirection;
		private System.Windows.Forms.Label labelStudentsGroup;
		private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
		private System.Windows.Forms.Label labelSearchStudent;
		private System.Windows.Forms.TextBox textBoxSearchStudent;
	}
}


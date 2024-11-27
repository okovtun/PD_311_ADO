namespace AcademyDataSet
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
			this.labelDirection = new System.Windows.Forms.Label();
			this.labelGroup = new System.Windows.Forms.Label();
			this.comboBoxDirection = new System.Windows.Forms.ComboBox();
			this.comboBoxGroup = new System.Windows.Forms.ComboBox();
			this.buttonResetFilters = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelDirection
			// 
			this.labelDirection.AutoSize = true;
			this.labelDirection.Location = new System.Drawing.Point(13, 13);
			this.labelDirection.Name = "labelDirection";
			this.labelDirection.Size = new System.Drawing.Size(78, 13);
			this.labelDirection.TabIndex = 0;
			this.labelDirection.Text = "Направление:";
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(12, 58);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(45, 13);
			this.labelGroup.TabIndex = 1;
			this.labelGroup.Text = "Группа:";
			// 
			// comboBoxDirection
			// 
			this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDirection.FormattingEnabled = true;
			this.comboBoxDirection.Location = new System.Drawing.Point(124, 13);
			this.comboBoxDirection.Name = "comboBoxDirection";
			this.comboBoxDirection.Size = new System.Drawing.Size(236, 21);
			this.comboBoxDirection.TabIndex = 2;
			this.comboBoxDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirection_SelectedIndexChanged);
			// 
			// comboBoxGroup
			// 
			this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroup.FormattingEnabled = true;
			this.comboBoxGroup.Location = new System.Drawing.Point(124, 58);
			this.comboBoxGroup.Name = "comboBoxGroup";
			this.comboBoxGroup.Size = new System.Drawing.Size(236, 21);
			this.comboBoxGroup.TabIndex = 3;
			// 
			// buttonResetFilters
			// 
			this.buttonResetFilters.Location = new System.Drawing.Point(366, 13);
			this.buttonResetFilters.Name = "buttonResetFilters";
			this.buttonResetFilters.Size = new System.Drawing.Size(75, 23);
			this.buttonResetFilters.TabIndex = 4;
			this.buttonResetFilters.Text = "Сброс";
			this.buttonResetFilters.UseVisualStyleBackColor = true;
			this.buttonResetFilters.Click += new System.EventHandler(this.buttonResetFilters_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 160);
			this.Controls.Add(this.buttonResetFilters);
			this.Controls.Add(this.comboBoxGroup);
			this.Controls.Add(this.comboBoxDirection);
			this.Controls.Add(this.labelGroup);
			this.Controls.Add(this.labelDirection);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "DataSet";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDirection;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.ComboBox comboBoxDirection;
		private System.Windows.Forms.ComboBox comboBoxGroup;
		private System.Windows.Forms.Button buttonResetFilters;
	}
}


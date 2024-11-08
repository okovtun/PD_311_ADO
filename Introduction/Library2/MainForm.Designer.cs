namespace Library2
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
			this.textBoxQuery = new System.Windows.Forms.TextBox();
			this.buttonExecute = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.comboBoxTables = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxQuery
			// 
			this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxQuery.Location = new System.Drawing.Point(13, 13);
			this.textBoxQuery.Name = "textBoxQuery";
			this.textBoxQuery.Size = new System.Drawing.Size(343, 20);
			this.textBoxQuery.TabIndex = 0;
			// 
			// buttonExecute
			// 
			this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExecute.Location = new System.Drawing.Point(374, 13);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(75, 20);
			this.buttonExecute.TabIndex = 1;
			this.buttonExecute.Text = "Execute";
			this.buttonExecute.UseVisualStyleBackColor = true;
			this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(13, 64);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(436, 195);
			this.dataGridView.TabIndex = 2;
			// 
			// comboBoxTables
			// 
			this.comboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTables.FormattingEnabled = true;
			this.comboBoxTables.Location = new System.Drawing.Point(13, 37);
			this.comboBoxTables.Name = "comboBoxTables";
			this.comboBoxTables.Size = new System.Drawing.Size(343, 21);
			this.comboBoxTables.TabIndex = 3;
			this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 271);
			this.Controls.Add(this.comboBoxTables);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.buttonExecute);
			this.Controls.Add(this.textBoxQuery);
			this.Name = "MainForm";
			this.Text = "Library2";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxQuery;
		private System.Windows.Forms.Button buttonExecute;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.ComboBox comboBoxTables;
	}
}


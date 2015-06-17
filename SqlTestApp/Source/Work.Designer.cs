namespace SqlTestApp
{
    partial class Work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work));
            this.workDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workDataGridView
            // 
            this.workDataGridView.AllowUserToAddRows = false;
            this.workDataGridView.AllowUserToDeleteRows = false;
            this.workDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.sportName,
            this.salary});
            this.workDataGridView.Location = new System.Drawing.Point(12, 12);
            this.workDataGridView.Name = "workDataGridView";
            this.workDataGridView.ReadOnly = true;
            this.workDataGridView.RowHeadersVisible = false;
            this.workDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workDataGridView.Size = new System.Drawing.Size(595, 208);
            this.workDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.Frozen = true;
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.Frozen = true;
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // sportName
            // 
            this.sportName.DataPropertyName = "sport_name";
            this.sportName.Frozen = true;
            this.sportName.HeaderText = "Спорт";
            this.sportName.Name = "sportName";
            this.sportName.ReadOnly = true;
            this.sportName.Width = 120;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.Frozen = true;
            this.salary.HeaderText = "Зарплата";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 80;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Створити вакансію";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.workDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Work";
            this.Text = "Посади";
            ((System.ComponentModel.ISupportInitialize)(this.workDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Button button2;
    }
}
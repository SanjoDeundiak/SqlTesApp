namespace SqlTestApp
{
    partial class WorkPlaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkPlaces));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.workName,
            this.clientName,
            this.startTime,
            this.endTime,
            this.valid});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Звільнити";
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
            // workName
            // 
            this.workName.DataPropertyName = "name";
            this.workName.Frozen = true;
            this.workName.HeaderText = "Робота";
            this.workName.Name = "workName";
            this.workName.ReadOnly = true;
            this.workName.Width = 250;
            // 
            // clientName
            // 
            this.clientName.DataPropertyName = "clientName";
            this.clientName.Frozen = true;
            this.clientName.HeaderText = "Ім\'я";
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            this.clientName.Width = 250;
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "startTime";
            this.startTime.Frozen = true;
            this.startTime.HeaderText = "Початок роботи";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "endTime";
            this.endTime.Frozen = true;
            this.endTime.HeaderText = "Кінець роботи";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            // 
            // valid
            // 
            this.valid.DataPropertyName = "valid";
            this.valid.FalseValue = "false";
            this.valid.Frozen = true;
            this.valid.HeaderText = "Дійсна";
            this.valid.Name = "valid";
            this.valid.ReadOnly = true;
            this.valid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.valid.TrueValue = "true";
            this.valid.Width = 50;
            // 
            // WorkPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkPlaces";
            this.Text = "Вакансії";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn workName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valid;
    }
}
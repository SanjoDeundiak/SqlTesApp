namespace SqlTestApp
{
    partial class PlanWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanWindow));
            this.eventTabControl = new System.Windows.Forms.TabControl();
            this.periodicTab = new System.Windows.Forms.TabPage();
            this.periodicDataGridView = new System.Windows.Forms.DataGridView();
            this.singleTab = new System.Windows.Forms.TabPage();
            this.singleDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTabControl.SuspendLayout();
            this.periodicTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodicDataGridView)).BeginInit();
            this.singleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTabControl
            // 
            this.eventTabControl.Controls.Add(this.periodicTab);
            this.eventTabControl.Controls.Add(this.singleTab);
            this.eventTabControl.Location = new System.Drawing.Point(12, 12);
            this.eventTabControl.Name = "eventTabControl";
            this.eventTabControl.SelectedIndex = 0;
            this.eventTabControl.Size = new System.Drawing.Size(997, 400);
            this.eventTabControl.TabIndex = 0;
            this.eventTabControl.SelectedIndexChanged += new System.EventHandler(this.eventTabControl_SelectedIndexChanged);
            this.eventTabControl.TabIndexChanged += new System.EventHandler(this.eventTabControl_TabIndexChanged);
            // 
            // periodicTab
            // 
            this.periodicTab.Controls.Add(this.periodicDataGridView);
            this.periodicTab.Location = new System.Drawing.Point(4, 22);
            this.periodicTab.Name = "periodicTab";
            this.periodicTab.Padding = new System.Windows.Forms.Padding(3);
            this.periodicTab.Size = new System.Drawing.Size(989, 374);
            this.periodicTab.TabIndex = 0;
            this.periodicTab.Text = "Періодичні події";
            this.periodicTab.UseVisualStyleBackColor = true;
            // 
            // periodicDataGridView
            // 
            this.periodicDataGridView.AllowUserToAddRows = false;
            this.periodicDataGridView.AllowUserToDeleteRows = false;
            this.periodicDataGridView.AllowUserToOrderColumns = true;
            this.periodicDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.periodicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.periodicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.headName,
            this.TypeName,
            this.sportName,
            this.lessonTimes});
            this.periodicDataGridView.Location = new System.Drawing.Point(-4, 0);
            this.periodicDataGridView.MultiSelect = false;
            this.periodicDataGridView.Name = "periodicDataGridView";
            this.periodicDataGridView.ReadOnly = true;
            this.periodicDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.periodicDataGridView.Size = new System.Drawing.Size(994, 378);
            this.periodicDataGridView.TabIndex = 0;
            // 
            // singleTab
            // 
            this.singleTab.Controls.Add(this.singleDataGridView);
            this.singleTab.Location = new System.Drawing.Point(4, 22);
            this.singleTab.Name = "singleTab";
            this.singleTab.Padding = new System.Windows.Forms.Padding(3);
            this.singleTab.Size = new System.Drawing.Size(989, 374);
            this.singleTab.TabIndex = 1;
            this.singleTab.Text = "Одноразові події";
            this.singleTab.UseVisualStyleBackColor = true;
            // 
            // singleDataGridView
            // 
            this.singleDataGridView.AllowUserToAddRows = false;
            this.singleDataGridView.AllowUserToDeleteRows = false;
            this.singleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.singleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number1,
            this.name1,
            this.headName1,
            this.startTime,
            this.endTime});
            this.singleDataGridView.Location = new System.Drawing.Point(-4, 0);
            this.singleDataGridView.MultiSelect = false;
            this.singleDataGridView.Name = "singleDataGridView";
            this.singleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.singleDataGridView.Size = new System.Drawing.Size(993, 378);
            this.singleDataGridView.TabIndex = 0;
            this.singleDataGridView.SelectionChanged += new System.EventHandler(this.singleDataGridView_SelectionChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(853, 420);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(934, 420);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редагувати";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(746, 426);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Лише майбутні";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(16, 420);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "Звіт";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(502, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(148, 20);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(656, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.name.HeaderText = "Назва події";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // headName
            // 
            this.headName.DataPropertyName = "headName";
            this.headName.Frozen = true;
            this.headName.HeaderText = "Завідувач";
            this.headName.Name = "headName";
            this.headName.ReadOnly = true;
            this.headName.Width = 200;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "type_name";
            this.TypeName.HeaderText = "Тип";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            // 
            // sportName
            // 
            this.sportName.DataPropertyName = "sport_names";
            this.sportName.HeaderText = "Спорт";
            this.sportName.Name = "sportName";
            this.sportName.ReadOnly = true;
            this.sportName.Width = 110;
            // 
            // lessonTimes
            // 
            this.lessonTimes.DataPropertyName = "LessonTimes";
            this.lessonTimes.HeaderText = "Часи занять";
            this.lessonTimes.Name = "lessonTimes";
            this.lessonTimes.ReadOnly = true;
            this.lessonTimes.Width = 290;
            // 
            // number1
            // 
            this.number1.DataPropertyName = "number";
            this.number1.Frozen = true;
            this.number1.HeaderText = "№";
            this.number1.Name = "number1";
            this.number1.ReadOnly = true;
            this.number1.Width = 50;
            // 
            // name1
            // 
            this.name1.DataPropertyName = "name";
            this.name1.Frozen = true;
            this.name1.HeaderText = "Назва події";
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            this.name1.Width = 250;
            // 
            // headName1
            // 
            this.headName1.DataPropertyName = "headName";
            this.headName1.Frozen = true;
            this.headName1.HeaderText = "Завідувач";
            this.headName1.Name = "headName1";
            this.headName1.ReadOnly = true;
            this.headName1.Width = 250;
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "start_time";
            this.startTime.HeaderText = "Початок";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 200;
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "end_time";
            this.endTime.HeaderText = "Кінець";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            this.endTime.Width = 200;
            // 
            // PlanWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 455);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.eventTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlanWindow";
            this.Text = "Події";
            this.eventTabControl.ResumeLayout(false);
            this.periodicTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.periodicDataGridView)).EndInit();
            this.singleTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.singleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl eventTabControl;
        private System.Windows.Forms.TabPage periodicTab;
        private System.Windows.Forms.TabPage singleTab;
        private System.Windows.Forms.DataGridView periodicDataGridView;
        private System.Windows.Forms.DataGridView singleDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn headName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn headName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
    }
}
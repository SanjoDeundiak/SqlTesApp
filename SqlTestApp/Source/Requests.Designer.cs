namespace SqlTestApp
{
    partial class Requests
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.acceptedDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.notAcceptedDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notAcceptedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 341);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.acceptedDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Прийняті";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // acceptedDataGridView
            // 
            this.acceptedDataGridView.AllowUserToAddRows = false;
            this.acceptedDataGridView.AllowUserToDeleteRows = false;
            this.acceptedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acceptedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.eventName,
            this.client_name,
            this.surname,
            this.time});
            this.acceptedDataGridView.Location = new System.Drawing.Point(3, 0);
            this.acceptedDataGridView.Name = "acceptedDataGridView";
            this.acceptedDataGridView.ReadOnly = true;
            this.acceptedDataGridView.RowHeadersVisible = false;
            this.acceptedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.acceptedDataGridView.Size = new System.Drawing.Size(725, 309);
            this.acceptedDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.notAcceptedDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Не прийняті";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // notAcceptedDataGridView
            // 
            this.notAcceptedDataGridView.AllowUserToAddRows = false;
            this.notAcceptedDataGridView.AllowUserToDeleteRows = false;
            this.notAcceptedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notAcceptedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number1,
            this.event_name,
            this.client_name1,
            this.surname1,
            this.time1});
            this.notAcceptedDataGridView.Location = new System.Drawing.Point(3, 0);
            this.notAcceptedDataGridView.Name = "notAcceptedDataGridView";
            this.notAcceptedDataGridView.ReadOnly = true;
            this.notAcceptedDataGridView.RowHeadersVisible = false;
            this.notAcceptedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notAcceptedDataGridView.Size = new System.Drawing.Size(725, 309);
            this.notAcceptedDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Задовільнити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(673, 360);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // eventName
            // 
            this.eventName.DataPropertyName = "event_name";
            this.eventName.HeaderText = "Подія";
            this.eventName.Name = "eventName";
            this.eventName.ReadOnly = true;
            // 
            // client_name
            // 
            this.client_name.DataPropertyName = "client_name";
            this.client_name.HeaderText = "Ім\'я";
            this.client_name.Name = "client_name";
            this.client_name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Прізвище";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "registration_date";
            this.time.HeaderText = "Дата";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // number1
            // 
            this.number1.DataPropertyName = "number";
            this.number1.HeaderText = "№";
            this.number1.Name = "number1";
            this.number1.ReadOnly = true;
            // 
            // event_name
            // 
            this.event_name.DataPropertyName = "event_name";
            this.event_name.HeaderText = "Подія";
            this.event_name.Name = "event_name";
            this.event_name.ReadOnly = true;
            // 
            // client_name1
            // 
            this.client_name1.DataPropertyName = "client_name";
            this.client_name1.HeaderText = "Ім\'я";
            this.client_name1.Name = "client_name1";
            this.client_name1.ReadOnly = true;
            // 
            // surname1
            // 
            this.surname1.DataPropertyName = "surname";
            this.surname1.HeaderText = "Прізвище";
            this.surname1.Name = "surname1";
            this.surname1.ReadOnly = true;
            // 
            // time1
            // 
            this.time1.DataPropertyName = "registration_date";
            this.time1.HeaderText = "Дата";
            this.time1.Name = "time1";
            this.time1.ReadOnly = true;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 395);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Requests";
            this.Text = "Requests";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acceptedDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notAcceptedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView acceptedDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView notAcceptedDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn time1;

    }
}
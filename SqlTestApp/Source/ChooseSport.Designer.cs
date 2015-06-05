namespace SqlTestApp
{
    partial class ChooseSport
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
            this.sportDataGridView = new System.Windows.Forms.DataGridView();
            this.OKButton = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sportDataGridView
            // 
            this.sportDataGridView.AllowUserToAddRows = false;
            this.sportDataGridView.AllowUserToDeleteRows = false;
            this.sportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.check});
            this.sportDataGridView.Location = new System.Drawing.Point(12, 12);
            this.sportDataGridView.Name = "sportDataGridView";
            this.sportDataGridView.RowHeadersVisible = false;
            this.sportDataGridView.Size = new System.Drawing.Size(502, 208);
            this.sportDataGridView.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(439, 226);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.Frozen = true;
            this.number.HeaderText = "№";
            this.number.Name = "number";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.Frozen = true;
            this.name.HeaderText = "Спорт";
            this.name.Name = "name";
            // 
            // check
            // 
            this.check.DataPropertyName = "check";
            this.check.FalseValue = "false";
            this.check.Frozen = true;
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.TrueValue = "true";
            // 
            // ChooseSport
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.sportDataGridView);
            this.Name = "ChooseSport";
            this.Text = "ChooseSport";
            ((System.ComponentModel.ISupportInitialize)(this.sportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sportDataGridView;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}
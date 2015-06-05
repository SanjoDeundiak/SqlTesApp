namespace SqlTestApp
{
    partial class AddTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weekDayComboBox = new System.Windows.Forms.ComboBox();
            this.startMinComboBox = new System.Windows.Forms.ComboBox();
            this.startHoursComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.durationMinComboBox = new System.Windows.Forms.ComboBox();
            this.durationHoursComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "День тижня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Час початку";
            // 
            // weekDayComboBox
            // 
            this.weekDayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weekDayComboBox.FormattingEnabled = true;
            this.weekDayComboBox.Location = new System.Drawing.Point(86, 24);
            this.weekDayComboBox.Name = "weekDayComboBox";
            this.weekDayComboBox.Size = new System.Drawing.Size(133, 21);
            this.weekDayComboBox.TabIndex = 2;
            // 
            // startMinComboBox
            // 
            this.startMinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startMinComboBox.FormattingEnabled = true;
            this.startMinComboBox.Location = new System.Drawing.Point(173, 51);
            this.startMinComboBox.Name = "startMinComboBox";
            this.startMinComboBox.Size = new System.Drawing.Size(47, 21);
            this.startMinComboBox.TabIndex = 3;
            // 
            // startHoursComboBox
            // 
            this.startHoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startHoursComboBox.FormattingEnabled = true;
            this.startHoursComboBox.Location = new System.Drawing.Point(120, 51);
            this.startHoursComboBox.Name = "startHoursComboBox";
            this.startHoursComboBox.Size = new System.Drawing.Size(47, 21);
            this.startHoursComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тривалість";
            // 
            // durationMinComboBox
            // 
            this.durationMinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationMinComboBox.FormattingEnabled = true;
            this.durationMinComboBox.Location = new System.Drawing.Point(174, 78);
            this.durationMinComboBox.Name = "durationMinComboBox";
            this.durationMinComboBox.Size = new System.Drawing.Size(46, 21);
            this.durationMinComboBox.TabIndex = 6;
            // 
            // durationHoursComboBox
            // 
            this.durationHoursComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationHoursComboBox.FormattingEnabled = true;
            this.durationHoursComboBox.Location = new System.Drawing.Point(121, 79);
            this.durationHoursComboBox.Name = "durationHoursComboBox";
            this.durationHoursComboBox.Size = new System.Drawing.Size(46, 21);
            this.durationHoursComboBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(145, 121);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(64, 121);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AddTime
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(230, 154);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.durationHoursComboBox);
            this.Controls.Add(this.durationMinComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startHoursComboBox);
            this.Controls.Add(this.startMinComboBox);
            this.Controls.Add(this.weekDayComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTime";
            this.Text = "AddTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox weekDayComboBox;
        private System.Windows.Forms.ComboBox startMinComboBox;
        private System.Windows.Forms.ComboBox startHoursComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox durationMinComboBox;
        private System.Windows.Forms.ComboBox durationHoursComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}
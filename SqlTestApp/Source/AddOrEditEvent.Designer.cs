namespace SqlTestApp
{
    partial class AddOrEditEvent
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sportTextBox = new System.Windows.Forms.TextBox();
            this.addSportButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.addTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва події";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип події";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(261, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(166, 59);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(261, 21);
            this.typeComboBox.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(271, 142);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(352, 142);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Спорт";
            // 
            // sportTextBox
            // 
            this.sportTextBox.Location = new System.Drawing.Point(166, 86);
            this.sportTextBox.Name = "sportTextBox";
            this.sportTextBox.Size = new System.Drawing.Size(232, 20);
            this.sportTextBox.TabIndex = 7;
            // 
            // addSportButton
            // 
            this.addSportButton.Location = new System.Drawing.Point(404, 84);
            this.addSportButton.Name = "addSportButton";
            this.addSportButton.Size = new System.Drawing.Size(23, 23);
            this.addSportButton.TabIndex = 8;
            this.addSportButton.Text = "+";
            this.addSportButton.UseVisualStyleBackColor = true;
            this.addSportButton.Click += new System.EventHandler(this.addSportButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Час";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(166, 115);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(232, 20);
            this.timeTextBox.TabIndex = 10;
            // 
            // addTimeButton
            // 
            this.addTimeButton.Location = new System.Drawing.Point(404, 113);
            this.addTimeButton.Name = "addTimeButton";
            this.addTimeButton.Size = new System.Drawing.Size(23, 23);
            this.addTimeButton.TabIndex = 11;
            this.addTimeButton.Text = "+";
            this.addTimeButton.UseVisualStyleBackColor = true;
            this.addTimeButton.Click += new System.EventHandler(this.addTimeButton_Click);
            // 
            // AddOrEditEvent
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(439, 174);
            this.Controls.Add(this.addTimeButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addSportButton);
            this.Controls.Add(this.sportTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrEditEvent";
            this.Text = "AddEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sportTextBox;
        private System.Windows.Forms.Button addSportButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button addTimeButton;
    }
}
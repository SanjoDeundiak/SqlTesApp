namespace SqlTestApp
{
    partial class AddEquipmentRequest
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyCheckBox = new System.Windows.Forms.CheckBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.quantityUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.equipmentComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpAndDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клієнт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подія";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Назва";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кількість";
            // 
            // buyCheckBox
            // 
            this.buyCheckBox.AutoSize = true;
            this.buyCheckBox.Location = new System.Drawing.Point(271, 100);
            this.buyCheckBox.Name = "buyCheckBox";
            this.buyCheckBox.Size = new System.Drawing.Size(64, 17);
            this.buyCheckBox.TabIndex = 5;
            this.buyCheckBox.Text = "Купівля";
            this.buyCheckBox.UseVisualStyleBackColor = true;
            this.buyCheckBox.CheckedChanged += new System.EventHandler(this.buyCheckBox_CheckedChanged);
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(57, 19);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(278, 21);
            this.clientComboBox.TabIndex = 6;
            // 
            // eventComboBox
            // 
            this.eventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Location = new System.Drawing.Point(57, 46);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(278, 21);
            this.eventComboBox.TabIndex = 7;
            // 
            // quantityUpAndDown
            // 
            this.quantityUpAndDown.Location = new System.Drawing.Point(133, 100);
            this.quantityUpAndDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.quantityUpAndDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityUpAndDown.Name = "quantityUpAndDown";
            this.quantityUpAndDown.Size = new System.Drawing.Size(120, 20);
            this.quantityUpAndDown.TabIndex = 10;
            this.quantityUpAndDown.ThousandsSeparator = true;
            this.quantityUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(260, 126);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(178, 126);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // equipmentComboBox
            // 
            this.equipmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentComboBox.FormattingEnabled = true;
            this.equipmentComboBox.Location = new System.Drawing.Point(57, 73);
            this.equipmentComboBox.Name = "equipmentComboBox";
            this.equipmentComboBox.Size = new System.Drawing.Size(277, 21);
            this.equipmentComboBox.TabIndex = 13;
            // 
            // AddEquipmentRequest
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(347, 160);
            this.Controls.Add(this.equipmentComboBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.quantityUpAndDown);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.buyCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEquipmentRequest";
            this.Text = "AddEquipmentRequest";
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpAndDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox buyCheckBox;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.NumericUpDown quantityUpAndDown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox equipmentComboBox;
    }
}
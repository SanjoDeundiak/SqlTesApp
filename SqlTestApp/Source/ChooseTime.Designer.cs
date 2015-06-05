﻿namespace SqlTestApp
{
    partial class ChooseTime
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
            this.timeDataGridView = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timeDataGridView
            // 
            this.timeDataGridView.AllowUserToAddRows = false;
            this.timeDataGridView.AllowUserToDeleteRows = false;
            this.timeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.time,
            this.check});
            this.timeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.timeDataGridView.Name = "timeDataGridView";
            this.timeDataGridView.RowHeadersVisible = false;
            this.timeDataGridView.Size = new System.Drawing.Size(499, 208);
            this.timeDataGridView.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(436, 226);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Час";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // check
            // 
            this.check.DataPropertyName = "check";
            this.check.FalseValue = "false";
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.TrueValue = "true";
            // 
            // ChooseTime
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.timeDataGridView);
            this.Name = "ChooseTime";
            this.Text = "ChooseTime";
            ((System.ComponentModel.ISupportInitialize)(this.timeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView timeDataGridView;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}
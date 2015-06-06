namespace SqlTestApp
{
    partial class MainWindow
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
            this.clientsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planButton = new System.Windows.Forms.Button();
            this.sportButton = new System.Windows.Forms.Button();
            this.timeButton = new System.Windows.Forms.Button();
            this.buttonEquipment = new System.Windows.Forms.Button();
            this.requestsButton = new System.Windows.Forms.Button();
            this.equipmentRequestsButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsButton
            // 
            this.clientsButton.Location = new System.Drawing.Point(12, 190);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(204, 96);
            this.clientsButton.TabIndex = 0;
            this.clientsButton.Text = "Робота з клієнтами";
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаToolStripMenuItem
            // 
            this.базаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconnectToolStripMenuItem});
            this.базаToolStripMenuItem.Name = "базаToolStripMenuItem";
            this.базаToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.базаToolStripMenuItem.Text = "База";
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.reconnectToolStripMenuItem.Text = "Перепідключитись";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // planButton
            // 
            this.planButton.Location = new System.Drawing.Point(12, 48);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(204, 96);
            this.planButton.TabIndex = 2;
            this.planButton.Text = "Заняття";
            this.planButton.UseVisualStyleBackColor = true;
            this.planButton.Click += new System.EventHandler(this.planButton_Click);
            // 
            // sportButton
            // 
            this.sportButton.Location = new System.Drawing.Point(533, 150);
            this.sportButton.Name = "sportButton";
            this.sportButton.Size = new System.Drawing.Size(204, 96);
            this.sportButton.TabIndex = 3;
            this.sportButton.Text = "Спорт";
            this.sportButton.UseVisualStyleBackColor = true;
            this.sportButton.Click += new System.EventHandler(this.sportButton_Click);
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(222, 48);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(204, 96);
            this.timeButton.TabIndex = 4;
            this.timeButton.Text = "Часи занять";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // buttonEquipment
            // 
            this.buttonEquipment.Location = new System.Drawing.Point(533, 48);
            this.buttonEquipment.Name = "buttonEquipment";
            this.buttonEquipment.Size = new System.Drawing.Size(204, 96);
            this.buttonEquipment.TabIndex = 5;
            this.buttonEquipment.Text = "Спорядження";
            this.buttonEquipment.UseVisualStyleBackColor = true;
            this.buttonEquipment.Click += new System.EventHandler(this.buttonEquipment_Click);
            // 
            // requestsButton
            // 
            this.requestsButton.Location = new System.Drawing.Point(12, 354);
            this.requestsButton.Name = "requestsButton";
            this.requestsButton.Size = new System.Drawing.Size(204, 96);
            this.requestsButton.TabIndex = 6;
            this.requestsButton.Text = "Заявки на події";
            this.requestsButton.UseVisualStyleBackColor = true;
            this.requestsButton.Click += new System.EventHandler(this.requestsButton_Click);
            // 
            // equipmentRequestsButton
            // 
            this.equipmentRequestsButton.Location = new System.Drawing.Point(222, 354);
            this.equipmentRequestsButton.Name = "equipmentRequestsButton";
            this.equipmentRequestsButton.Size = new System.Drawing.Size(204, 96);
            this.equipmentRequestsButton.TabIndex = 7;
            this.equipmentRequestsButton.Text = "Заявки на знаряддя";
            this.equipmentRequestsButton.UseVisualStyleBackColor = true;
            this.equipmentRequestsButton.Click += new System.EventHandler(this.equipmentRequestsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 469);
            this.Controls.Add(this.equipmentRequestsButton);
            this.Controls.Add(this.requestsButton);
            this.Controls.Add(this.buttonEquipment);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.sportButton);
            this.Controls.Add(this.planButton);
            this.Controls.Add(this.clientsButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.Button sportButton;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.Button buttonEquipment;
        private System.Windows.Forms.Button requestsButton;
        private System.Windows.Forms.Button equipmentRequestsButton;
    }
}
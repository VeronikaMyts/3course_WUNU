namespace PassengerManagementSystem.Forms
{
    partial class MainForm
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
            this.btnManagePassengers = new System.Windows.Forms.Button();
            this.btnManageTours = new System.Windows.Forms.Button();
            this.btnManageRoutes = new System.Windows.Forms.Button();
            this.btnManageTickets = new System.Windows.Forms.Button();
            this.btnManageCarriers = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagePassengers
            // 
            this.btnManagePassengers.Location = new System.Drawing.Point(104, 61);
            this.btnManagePassengers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagePassengers.Name = "btnManagePassengers";
            this.btnManagePassengers.Size = new System.Drawing.Size(162, 38);
            this.btnManagePassengers.TabIndex = 0;
            this.btnManagePassengers.Text = "Пасажири";
            this.btnManagePassengers.UseVisualStyleBackColor = true;
            this.btnManagePassengers.Click += new System.EventHandler(this.btnManagePassengers_Click);
            // 
            // btnManageTours
            // 
            this.btnManageTours.Location = new System.Drawing.Point(104, 105);
            this.btnManageTours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageTours.Name = "btnManageTours";
            this.btnManageTours.Size = new System.Drawing.Size(162, 42);
            this.btnManageTours.TabIndex = 1;
            this.btnManageTours.Text = "Рейси";
            this.btnManageTours.UseVisualStyleBackColor = true;
            this.btnManageTours.Click += new System.EventHandler(this.btnManageTours_Click);
            // 
            // btnManageRoutes
            // 
            this.btnManageRoutes.Location = new System.Drawing.Point(104, 154);
            this.btnManageRoutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageRoutes.Name = "btnManageRoutes";
            this.btnManageRoutes.Size = new System.Drawing.Size(162, 39);
            this.btnManageRoutes.TabIndex = 2;
            this.btnManageRoutes.Text = "Маршрути";
            this.btnManageRoutes.UseVisualStyleBackColor = true;
            this.btnManageRoutes.Click += new System.EventHandler(this.btnManageRoutes_Click);
            // 
            // btnManageTickets
            // 
            this.btnManageTickets.Location = new System.Drawing.Point(291, 61);
            this.btnManageTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageTickets.Name = "btnManageTickets";
            this.btnManageTickets.Size = new System.Drawing.Size(143, 38);
            this.btnManageTickets.TabIndex = 3;
            this.btnManageTickets.Text = "Квитки";
            this.btnManageTickets.UseVisualStyleBackColor = true;
            this.btnManageTickets.Click += new System.EventHandler(this.btnManageTickets_Click);
            // 
            // btnManageCarriers
            // 
            this.btnManageCarriers.Location = new System.Drawing.Point(291, 105);
            this.btnManageCarriers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageCarriers.Name = "btnManageCarriers";
            this.btnManageCarriers.Size = new System.Drawing.Size(143, 42);
            this.btnManageCarriers.TabIndex = 4;
            this.btnManageCarriers.Text = "Перевізники";
            this.btnManageCarriers.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Location = new System.Drawing.Point(291, 154);
            this.btnGenerateReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(143, 39);
            this.btnGenerateReports.TabIndex = 5;
            this.btnGenerateReports.Text = "Звіти";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(184, 229);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 46);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Вихід";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.btnManageCarriers);
            this.Controls.Add(this.btnManageTickets);
            this.Controls.Add(this.btnManageRoutes);
            this.Controls.Add(this.btnManageTours);
            this.Controls.Add(this.btnManagePassengers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManagePassengers;
        private System.Windows.Forms.Button btnManageTours;
        private System.Windows.Forms.Button btnManageRoutes;
        private System.Windows.Forms.Button btnManageTickets;
        private System.Windows.Forms.Button btnManageCarriers;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnLogout;
    }
}
namespace PassengerManagementSystem.Forms
{
    partial class TourForm
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
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.btnEditTour = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.RowHeadersWidth = 62;
            this.dataGridViewTours.RowTemplate.Height = 28;
            this.dataGridViewTours.Size = new System.Drawing.Size(775, 225);
            this.dataGridViewTours.TabIndex = 0;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Location = new System.Drawing.Point(140, 262);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDepartureDate.TabIndex = 1;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Location = new System.Drawing.Point(140, 310);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(200, 26);
            this.dtpArrivalDate.TabIndex = 2;
            // 
            // cmbRoute
            // 
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(13, 349);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(200, 28);
            this.cmbRoute.TabIndex = 3;
            // 
            // btnAddTour
            // 
            this.btnAddTour.Location = new System.Drawing.Point(633, 259);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(140, 26);
            this.btnAddTour.TabIndex = 4;
            this.btnAddTour.Text = "Додати";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.Location = new System.Drawing.Point(633, 305);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(140, 26);
            this.btnDeleteTour.TabIndex = 5;
            this.btnDeleteTour.Text = "Видалити";
            this.btnDeleteTour.UseVisualStyleBackColor = true;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // btnEditTour
            // 
            this.btnEditTour.Location = new System.Drawing.Point(633, 348);
            this.btnEditTour.Name = "btnEditTour";
            this.btnEditTour.Size = new System.Drawing.Size(140, 28);
            this.btnEditTour.TabIndex = 6;
            this.btnEditTour.Text = "Редагувати";
            this.btnEditTour.UseVisualStyleBackColor = true;
            this.btnEditTour.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Location = new System.Drawing.Point(657, 400);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(116, 38);
            this.btnBackToMainForm.TabIndex = 7;
            this.btnBackToMainForm.Text = "Вийти";
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата відправки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата прибуття";
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToMainForm);
            this.Controls.Add(this.btnEditTour);
            this.Controls.Add(this.btnDeleteTour);
            this.Controls.Add(this.btnAddTour);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.dtpArrivalDate);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.dataGridViewTours);
            this.Name = "TourForm";
            this.Text = "TourForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTours;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.Button btnEditTour;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace PassengerManagementSystem.Forms
{
    partial class RouteForm
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
            this.dataGridViewRoutes = new System.Windows.Forms.DataGridView();
            this.txtStartCity = new System.Windows.Forms.TextBox();
            this.txtEndCity = new System.Windows.Forms.TextBox();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnEditRoute = new System.Windows.Forms.Button();
            this.btnDeleteRoute = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRoutes
            // 
            this.dataGridViewRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoutes.Location = new System.Drawing.Point(13, 47);
            this.dataGridViewRoutes.Name = "dataGridViewRoutes";
            this.dataGridViewRoutes.RowHeadersWidth = 62;
            this.dataGridViewRoutes.RowTemplate.Height = 28;
            this.dataGridViewRoutes.Size = new System.Drawing.Size(1154, 208);
            this.dataGridViewRoutes.TabIndex = 0;
            // 
            // txtStartCity
            // 
            this.txtStartCity.Location = new System.Drawing.Point(209, 306);
            this.txtStartCity.Name = "txtStartCity";
            this.txtStartCity.Size = new System.Drawing.Size(100, 26);
            this.txtStartCity.TabIndex = 1;
            // 
            // txtEndCity
            // 
            this.txtEndCity.Location = new System.Drawing.Point(485, 303);
            this.txtEndCity.Name = "txtEndCity";
            this.txtEndCity.Size = new System.Drawing.Size(100, 26);
            this.txtEndCity.TabIndex = 2;
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(80, 386);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(100, 61);
            this.btnAddRoute.TabIndex = 3;
            this.btnAddRoute.Text = "Додати";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnEditRoute
            // 
            this.btnEditRoute.Location = new System.Drawing.Point(252, 386);
            this.btnEditRoute.Name = "btnEditRoute";
            this.btnEditRoute.Size = new System.Drawing.Size(123, 61);
            this.btnEditRoute.TabIndex = 4;
            this.btnEditRoute.Text = "Редагувати";
            this.btnEditRoute.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRoute
            // 
            this.btnDeleteRoute.Location = new System.Drawing.Point(435, 385);
            this.btnDeleteRoute.Name = "btnDeleteRoute";
            this.btnDeleteRoute.Size = new System.Drawing.Size(163, 62);
            this.btnDeleteRoute.TabIndex = 5;
            this.btnDeleteRoute.Text = "Видалити";
            this.btnDeleteRoute.UseVisualStyleBackColor = true;
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Location = new System.Drawing.Point(1015, 390);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(126, 57);
            this.btnBackToMainForm.TabIndex = 6;
            this.btnBackToMainForm.Text = "Вийти";
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Місце відправки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Місце прибуття";
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToMainForm);
            this.Controls.Add(this.btnDeleteRoute);
            this.Controls.Add(this.btnEditRoute);
            this.Controls.Add(this.btnAddRoute);
            this.Controls.Add(this.txtEndCity);
            this.Controls.Add(this.txtStartCity);
            this.Controls.Add(this.dataGridViewRoutes);
            this.Name = "RouteForm";
            this.Text = "RouteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoutes;
        private System.Windows.Forms.TextBox txtStartCity;
        private System.Windows.Forms.TextBox txtEndCity;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnEditRoute;
        private System.Windows.Forms.Button btnDeleteRoute;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
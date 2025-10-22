namespace PassengerManagementSystem.Forms
{
    partial class TicketForm
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
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.cmbPassenger = new System.Windows.Forms.ComboBox();
            this.cmbTour = new System.Windows.Forms.ComboBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.chkIsBooked = new System.Windows.Forms.CheckBox();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 62;
            this.dataGridViewTickets.RowTemplate.Height = 28;
            this.dataGridViewTickets.Size = new System.Drawing.Size(776, 183);
            this.dataGridViewTickets.TabIndex = 0;
            // 
            // cmbPassenger
            // 
            this.cmbPassenger.FormattingEnabled = true;
            this.cmbPassenger.Location = new System.Drawing.Point(166, 226);
            this.cmbPassenger.Name = "cmbPassenger";
            this.cmbPassenger.Size = new System.Drawing.Size(121, 28);
            this.cmbPassenger.TabIndex = 1;
            // 
            // cmbTour
            // 
            this.cmbTour.FormattingEnabled = true;
            this.cmbTour.Location = new System.Drawing.Point(166, 272);
            this.cmbTour.Name = "cmbTour";
            this.cmbTour.Size = new System.Drawing.Size(121, 28);
            this.cmbTour.TabIndex = 2;
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(167, 319);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(120, 26);
            this.numericPrice.TabIndex = 3;
            // 
            // chkIsBooked
            // 
            this.chkIsBooked.AutoSize = true;
            this.chkIsBooked.Location = new System.Drawing.Point(166, 367);
            this.chkIsBooked.Name = "chkIsBooked";
            this.chkIsBooked.Size = new System.Drawing.Size(111, 24);
            this.chkIsBooked.TabIndex = 4;
            this.chkIsBooked.Text = "Оплачено";
            this.chkIsBooked.UseVisualStyleBackColor = true;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Location = new System.Drawing.Point(400, 221);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(122, 33);
            this.btnAddTicket.TabIndex = 5;
            this.btnAddTicket.Text = "Додати";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Location = new System.Drawing.Point(400, 272);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(122, 28);
            this.btnDeleteTicket.TabIndex = 6;
            this.btnDeleteTicket.Text = "Видалити";
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.Location = new System.Drawing.Point(400, 319);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(122, 26);
            this.btnEditTicket.TabIndex = 7;
            this.btnEditTicket.Text = "Редагувати";
            this.btnEditTicket.UseVisualStyleBackColor = true;
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Location = new System.Drawing.Point(400, 367);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(122, 33);
            this.btnBackToMainForm.TabIndex = 8;
            this.btnBackToMainForm.Text = "Вийти";
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пасажир(паспорт)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Рейс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сума";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToMainForm);
            this.Controls.Add(this.btnEditTicket);
            this.Controls.Add(this.btnDeleteTicket);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.chkIsBooked);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.cmbTour);
            this.Controls.Add(this.cmbPassenger);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.ComboBox cmbPassenger;
        private System.Windows.Forms.ComboBox cmbTour;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.CheckBox chkIsBooked;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
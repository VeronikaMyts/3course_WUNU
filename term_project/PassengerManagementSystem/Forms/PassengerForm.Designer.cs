namespace PassengerManagementSystem.Forms
{
    partial class PassengerForm
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
            this.dataGridViewPassengers = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.btnDeletePassenger = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnEditPassenger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPassengers
            // 
            this.dataGridViewPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassengers.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewPassengers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPassengers.Name = "dataGridViewPassengers";
            this.dataGridViewPassengers.RowHeadersWidth = 62;
            this.dataGridViewPassengers.RowTemplate.Height = 28;
            this.dataGridViewPassengers.Size = new System.Drawing.Size(689, 172);
            this.dataGridViewPassengers.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(11, 214);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(122, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(148, 214);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(123, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(288, 214);
            this.txtPassportNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(122, 22);
            this.txtPassportNumber.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(423, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(561, 214);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(123, 22);
            this.txtContactNumber.TabIndex = 5;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Location = new System.Drawing.Point(12, 286);
            this.btnAddPassenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(121, 35);
            this.btnAddPassenger.TabIndex = 6;
            this.btnAddPassenger.Text = "Додати";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // btnDeletePassenger
            // 
            this.btnDeletePassenger.Location = new System.Drawing.Point(288, 286);
            this.btnDeletePassenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletePassenger.Name = "btnDeletePassenger";
            this.btnDeletePassenger.Size = new System.Drawing.Size(122, 36);
            this.btnDeletePassenger.TabIndex = 8;
            this.btnDeletePassenger.Text = "Видалити";
            this.btnDeletePassenger.UseVisualStyleBackColor = true;
            this.btnDeletePassenger.Click += new System.EventHandler(this.btnDeletePassenger_Click_1);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Location = new System.Drawing.Point(561, 286);
            this.btnBackToMainForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(123, 36);
            this.btnBackToMainForm.TabIndex = 9;
            this.btnBackToMainForm.Text = "Вихід";
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click_1);
            // 
            // btnEditPassenger
            // 
            this.btnEditPassenger.Location = new System.Drawing.Point(148, 286);
            this.btnEditPassenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPassenger.Name = "btnEditPassenger";
            this.btnEditPassenger.Size = new System.Drawing.Size(123, 36);
            this.btnEditPassenger.TabIndex = 10;
            this.btnEditPassenger.Text = "Редагувати";
            this.btnEditPassenger.UseVisualStyleBackColor = true;
            this.btnEditPassenger.Click += new System.EventHandler(this.btnEditPassenger_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Прізвище";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Поштова адреса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер телефону";
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditPassenger);
            this.Controls.Add(this.btnBackToMainForm);
            this.Controls.Add(this.btnDeletePassenger);
            this.Controls.Add(this.btnAddPassenger);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dataGridViewPassengers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PassengerForm";
            this.Text = "PassengerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassengerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassengerForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPassengers;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Button btnDeletePassenger;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnEditPassenger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
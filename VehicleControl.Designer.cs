namespace DMFleetManagementSystem
{
    partial class VehicleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblVehicleName = new Label();
            lblRegistrationNumber = new Label();
            lblVehicleType = new Label();
            lblFuelType = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(419, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 48);
            label1.TabIndex = 1;
            label1.Text = "MyVehicle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(315, 96);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 2;
            label2.Text = "Vehicle Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(242, 157);
            label3.Name = "label3";
            label3.Size = new Size(232, 31);
            label3.TabIndex = 3;
            label3.Text = "Registration Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 221);
            label4.Name = "label4";
            label4.Size = new Size(146, 31);
            label4.TabIndex = 4;
            label4.Text = "Vehicle Type:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(346, 292);
            label5.Name = "label5";
            label5.Size = new Size(115, 31);
            label5.TabIndex = 5;
            label5.Text = "Fuel Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(376, 352);
            label6.Name = "label6";
            label6.Size = new Size(81, 31);
            label6.TabIndex = 6;
            label6.Text = "Status:";
            // 
            // lblVehicleName
            // 
            lblVehicleName.AutoSize = true;
            lblVehicleName.Location = new Point(523, 105);
            lblVehicleName.Name = "lblVehicleName";
            lblVehicleName.Size = new Size(113, 20);
            lblVehicleName.TabIndex = 7;
            lblVehicleName.Text = "lblVehicleName";
            // 
            // lblRegistrationNumber
            // 
            lblRegistrationNumber.AutoSize = true;
            lblRegistrationNumber.Location = new Point(514, 166);
            lblRegistrationNumber.Name = "lblRegistrationNumber";
            lblRegistrationNumber.Size = new Size(160, 20);
            lblRegistrationNumber.TabIndex = 8;
            lblRegistrationNumber.Text = "lblRegistrationNumber";
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(532, 230);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(104, 20);
            lblVehicleType.TabIndex = 9;
            lblVehicleType.Text = "lblVehicleType";
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(532, 292);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(84, 20);
            lblFuelType.TabIndex = 10;
            lblFuelType.Text = "lblFuelType";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(532, 352);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "lblStatus";
            // 
            // VehicleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(lblFuelType);
            Controls.Add(lblVehicleType);
            Controls.Add(lblRegistrationNumber);
            Controls.Add(lblVehicleName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "VehicleControl";
            Size = new Size(1012, 456);
            Load += VehicleControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblVehicleName;
        private Label lblRegistrationNumber;
        private Label lblVehicleType;
        private Label lblFuelType;
        private Label lblStatus;
    }
}

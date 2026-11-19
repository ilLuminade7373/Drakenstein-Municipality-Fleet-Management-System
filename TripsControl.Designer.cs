namespace DMFleetManagementSystem
{
    partial class TripsControl
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
            dgvTrips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 43);
            label1.TabIndex = 1;
            label1.Text = "My Trips";
            label1.Click += label1_Click;
            // 
            // dgvTrips
            // 
            dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrips.Location = new Point(127, 126);
            dgvTrips.Name = "dgvTrips";
            dgvTrips.ReadOnly = true;
            dgvTrips.RowHeadersWidth = 51;
            dgvTrips.Size = new Size(772, 392);
            dgvTrips.TabIndex = 2;
            // 
            // TripsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvTrips);
            Controls.Add(label1);
            Name = "TripsControl";
            Size = new Size(955, 594);
            Load += TripsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTrips;
    }
}

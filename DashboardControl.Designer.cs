namespace DMFleetManagementSystem
{
    partial class DashboardControl
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, -10);
            label1.Name = "label1";
            label1.Size = new Size(207, 52);
            label1.TabIndex = 0;
            label1.Text = "HomePage";
            // 
            // DashboardControl
            // 
            Controls.Add(label1);
            Name = "DashboardControl";
            Size = new Size(1083, 607);
            ResumeLayout(false);
            PerformLayout();
            // 
            // DashboardControl
            // 

        }

        #endregion

        private Label lblDate;
        private Label label1;
    }
}

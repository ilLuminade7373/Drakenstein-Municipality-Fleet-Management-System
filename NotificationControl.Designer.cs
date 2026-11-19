namespace DMFleetManagementSystem
{
    partial class NotificationControl
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
            dgvNotifications = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(371, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 43);
            label1.TabIndex = 2;
            label1.Text = "Notifications";
            // 
            // dgvNotifications
            // 
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.Location = new Point(116, 125);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.RowHeadersWidth = 51;
            dgvNotifications.Size = new Size(772, 392);
            dgvNotifications.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(767, 90);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 4;
            button1.Text = "btnMarkRead";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NotificationControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dgvNotifications);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "NotificationControl";
            Size = new Size(1080, 574);
            Load += NotificationControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvNotifications;
        private Button button1;
    }
}

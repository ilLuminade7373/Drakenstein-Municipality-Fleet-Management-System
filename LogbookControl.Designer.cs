namespace DMFleetManagementSystem
{
    partial class LogbookControl
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
            dgvLogbook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLogbook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 41);
            label1.TabIndex = 3;
            label1.Text = "Logbook";
            label1.Click += label1_Click;
            // 
            // dgvLogbook
            // 
            dgvLogbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogbook.Location = new Point(106, 113);
            dgvLogbook.Name = "dgvLogbook";
            dgvLogbook.RowHeadersWidth = 51;
            dgvLogbook.Size = new Size(772, 392);
            dgvLogbook.TabIndex = 5;
            // 
            // LogbookControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLogbook);
            Controls.Add(label1);
            Name = "LogbookControl";
            Size = new Size(945, 588);
            Load += LogbookControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogbook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvLogbook;
    }
}

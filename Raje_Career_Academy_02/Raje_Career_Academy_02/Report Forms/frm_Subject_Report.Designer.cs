namespace Raje_Career_Academy_02.Report_Forms
{
    partial class frm_Subject_Report
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
            this.Subject_Report_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Subject_Report_Viewer
            // 
            this.Subject_Report_Viewer.ActiveViewIndex = -1;
            this.Subject_Report_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Subject_Report_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Subject_Report_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subject_Report_Viewer.Location = new System.Drawing.Point(0, 0);
            this.Subject_Report_Viewer.Name = "Subject_Report_Viewer";
            this.Subject_Report_Viewer.Size = new System.Drawing.Size(899, 590);
            this.Subject_Report_Viewer.TabIndex = 0;
            this.Subject_Report_Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Subject_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 590);
            this.Controls.Add(this.Subject_Report_Viewer);
            this.Name = "frm_Subject_Report";
            this.Text = "frm_Subject_Report";
            this.Load += new System.EventHandler(this.frm_Subject_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Subject_Report_Viewer;
    }
}
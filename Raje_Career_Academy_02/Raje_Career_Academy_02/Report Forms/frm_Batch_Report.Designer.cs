namespace Raje_Career_Academy_02.Report_Forms
{
    partial class frm_Batch_Report
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
            this.batch_report_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // batch_report_viewer
            // 
            this.batch_report_viewer.ActiveViewIndex = -1;
            this.batch_report_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batch_report_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.batch_report_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batch_report_viewer.Location = new System.Drawing.Point(0, 0);
            this.batch_report_viewer.Name = "batch_report_viewer";
            this.batch_report_viewer.Size = new System.Drawing.Size(919, 539);
            this.batch_report_viewer.TabIndex = 0;
            this.batch_report_viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Batch_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 539);
            this.Controls.Add(this.batch_report_viewer);
            this.Name = "frm_Batch_Report";
            this.Text = "frm_Batch_Report";
            this.Load += new System.EventHandler(this.frm_Batch_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer batch_report_viewer;
    }
}
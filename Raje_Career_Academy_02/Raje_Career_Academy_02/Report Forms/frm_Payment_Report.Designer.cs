namespace Raje_Career_Academy_02.Report_Forms
{
    partial class frm_Payment_Report
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
            this.payment_report_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // payment_report_viewer
            // 
            this.payment_report_viewer.ActiveViewIndex = -1;
            this.payment_report_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payment_report_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.payment_report_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment_report_viewer.Location = new System.Drawing.Point(0, 0);
            this.payment_report_viewer.Name = "payment_report_viewer";
            this.payment_report_viewer.Size = new System.Drawing.Size(894, 544);
            this.payment_report_viewer.TabIndex = 0;
            this.payment_report_viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Payment_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 544);
            this.Controls.Add(this.payment_report_viewer);
            this.Name = "frm_Payment_Report";
            this.Text = "frm_Payment_Report";
            this.Load += new System.EventHandler(this.frm_Payment_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer payment_report_viewer;
    }
}
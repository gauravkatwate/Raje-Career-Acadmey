namespace Raje_Career_Academy_02.Report_Forms
{
    partial class frm_student_report
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
            this.Student_Report_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Student_Report_Viewer
            // 
            this.Student_Report_Viewer.ActiveViewIndex = -1;
            this.Student_Report_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Student_Report_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Student_Report_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Student_Report_Viewer.Location = new System.Drawing.Point(0, 0);
            this.Student_Report_Viewer.Name = "Student_Report_Viewer";
            this.Student_Report_Viewer.Size = new System.Drawing.Size(1038, 626);
            this.Student_Report_Viewer.TabIndex = 0;
            this.Student_Report_Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_student_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 626);
            this.Controls.Add(this.Student_Report_Viewer);
            this.Name = "frm_student_report";
            this.Text = "frm_student_report";
            this.Load += new System.EventHandler(this.frm_student_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Student_Report_Viewer;
    }
}
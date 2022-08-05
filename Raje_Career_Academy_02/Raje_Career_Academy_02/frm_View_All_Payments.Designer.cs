namespace Raje_Career_Academy_02
{
    partial class frm_View_All_Payments
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Payments = new System.Windows.Forms.DataGridView();
            this.lbl_Heder = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Top1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Top1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dgv_Payments, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1322, 723);
            this.tableLayoutPanel3.TabIndex = 135;
            // 
            // dgv_Payments
            // 
            this.dgv_Payments.AllowUserToAddRows = false;
            this.dgv_Payments.AllowUserToDeleteRows = false;
            this.dgv_Payments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payments.Location = new System.Drawing.Point(2, 3);
            this.dgv_Payments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_Payments.Name = "dgv_Payments";
            this.dgv_Payments.ReadOnly = true;
            this.dgv_Payments.RowTemplate.Height = 24;
            this.dgv_Payments.Size = new System.Drawing.Size(1318, 717);
            this.dgv_Payments.TabIndex = 129;
            // 
            // lbl_Heder
            // 
            this.lbl_Heder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Heder.AutoSize = true;
            this.lbl_Heder.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heder.ForeColor = System.Drawing.Color.White;
            this.lbl_Heder.Location = new System.Drawing.Point(523, 9);
            this.lbl_Heder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Heder.Name = "lbl_Heder";
            this.lbl_Heder.Size = new System.Drawing.Size(275, 34);
            this.lbl_Heder.TabIndex = 0;
            this.lbl_Heder.Text = "All Payment Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Heder, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1322, 52);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel_Top1
            // 
            this.panel_Top1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel_Top1.Controls.Add(this.tableLayoutPanel1);
            this.panel_Top1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top1.Location = new System.Drawing.Point(0, 0);
            this.panel_Top1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Top1.Name = "panel_Top1";
            this.panel_Top1.Size = new System.Drawing.Size(1322, 52);
            this.panel_Top1.TabIndex = 131;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 769);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 14);
            this.panel1.TabIndex = 132;
            // 
            // frm_View_All_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 783);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel_Top1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_View_All_Payments";
            this.Text = "frm_View_All_Payments";
            this.Load += new System.EventHandler(this.frm_View_All_Payments_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_Top1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Heder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_Top1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Payments;
    }
}
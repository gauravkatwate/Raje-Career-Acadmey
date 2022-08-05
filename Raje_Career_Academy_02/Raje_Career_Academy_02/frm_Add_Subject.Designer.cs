namespace Raje_Career_Academy_02
{
    partial class frm_Add_Subject
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
            this.panel_Top1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Heder = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_Active = new System.Windows.Forms.RadioButton();
            this.rb_InActive = new System.Windows.Forms.RadioButton();
            this.lbl_Subject_ID = new System.Windows.Forms.Label();
            this.tb_Subject_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Subject_Name = new System.Windows.Forms.TextBox();
            this.tb_Subject_Fee = new System.Windows.Forms.TextBox();
            this.lbl_Subject_Fees = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Top1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top1
            // 
            this.panel_Top1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel_Top1.Controls.Add(this.tableLayoutPanel1);
            this.panel_Top1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top1.Location = new System.Drawing.Point(0, 0);
            this.panel_Top1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Top1.Name = "panel_Top1";
            this.panel_Top1.Size = new System.Drawing.Size(1303, 52);
            this.panel_Top1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Heder, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1303, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbl_Heder
            // 
            this.lbl_Heder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Heder.AutoSize = true;
            this.lbl_Heder.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heder.ForeColor = System.Drawing.Color.White;
            this.lbl_Heder.Location = new System.Drawing.Point(561, 9);
            this.lbl_Heder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Heder.Name = "lbl_Heder";
            this.lbl_Heder.Size = new System.Drawing.Size(181, 34);
            this.lbl_Heder.TabIndex = 0;
            this.lbl_Heder.Text = "Add Subject";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.698229F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.81197F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.32617F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.067536F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.89332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.93784F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.083141F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Subject_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Subject_ID, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Name, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Subject_Name, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Subject_Fee, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Subject_Fees, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Status, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Save, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_Clear, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 450);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1303, 254);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rb_Active, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_InActive, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(847, 87);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(345, 78);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // rb_Active
            // 
            this.rb_Active.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Active.AutoSize = true;
            this.rb_Active.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Active.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rb_Active.Location = new System.Drawing.Point(40, 25);
            this.rb_Active.Name = "rb_Active";
            this.rb_Active.Size = new System.Drawing.Size(91, 27);
            this.rb_Active.TabIndex = 1;
            this.rb_Active.TabStop = true;
            this.rb_Active.Text = "Active";
            this.rb_Active.UseVisualStyleBackColor = true;
            // 
            // rb_InActive
            // 
            this.rb_InActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_InActive.AutoSize = true;
            this.rb_InActive.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_InActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rb_InActive.Location = new System.Drawing.Point(205, 25);
            this.rb_InActive.Name = "rb_InActive";
            this.rb_InActive.Size = new System.Drawing.Size(107, 27);
            this.rb_InActive.TabIndex = 0;
            this.rb_InActive.TabStop = true;
            this.rb_InActive.Text = "InActive";
            this.rb_InActive.UseVisualStyleBackColor = true;
            // 
            // lbl_Subject_ID
            // 
            this.lbl_Subject_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subject_ID.AutoSize = true;
            this.lbl_Subject_ID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Subject_ID.Location = new System.Drawing.Point(102, 25);
            this.lbl_Subject_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Subject_ID.Name = "lbl_Subject_ID";
            this.lbl_Subject_ID.Size = new System.Drawing.Size(189, 34);
            this.lbl_Subject_ID.TabIndex = 120;
            this.lbl_Subject_ID.Text = "Subject ID ";
            // 
            // tb_Subject_ID
            // 
            this.tb_Subject_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Subject_ID.Enabled = false;
            this.tb_Subject_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subject_ID.Location = new System.Drawing.Point(295, 24);
            this.tb_Subject_ID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Subject_ID.Name = "tb_Subject_ID";
            this.tb_Subject_ID.Size = new System.Drawing.Size(326, 36);
            this.tb_Subject_ID.TabIndex = 122;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Name.Location = new System.Drawing.Point(102, 109);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(189, 34);
            this.lbl_Name.TabIndex = 121;
            this.lbl_Name.Text = "Name";
            // 
            // tb_Subject_Name
            // 
            this.tb_Subject_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Subject_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subject_Name.Location = new System.Drawing.Point(295, 108);
            this.tb_Subject_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Subject_Name.Name = "tb_Subject_Name";
            this.tb_Subject_Name.Size = new System.Drawing.Size(326, 36);
            this.tb_Subject_Name.TabIndex = 1;
            // 
            // tb_Subject_Fee
            // 
            this.tb_Subject_Fee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Subject_Fee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subject_Fee.Location = new System.Drawing.Point(846, 24);
            this.tb_Subject_Fee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Subject_Fee.Name = "tb_Subject_Fee";
            this.tb_Subject_Fee.Size = new System.Drawing.Size(347, 36);
            this.tb_Subject_Fee.TabIndex = 2;
            // 
            // lbl_Subject_Fees
            // 
            this.lbl_Subject_Fees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subject_Fees.AutoSize = true;
            this.lbl_Subject_Fees.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject_Fees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Subject_Fees.Location = new System.Drawing.Point(678, 25);
            this.lbl_Subject_Fees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Subject_Fees.Name = "lbl_Subject_Fees";
            this.lbl_Subject_Fees.Size = new System.Drawing.Size(164, 34);
            this.lbl_Subject_Fees.TabIndex = 124;
            this.lbl_Subject_Fees.Text = "Fees";
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Status.Location = new System.Drawing.Point(678, 109);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(164, 34);
            this.lbl_Status.TabIndex = 127;
            this.lbl_Status.Text = "Status";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(678, 191);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(117, 40);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(504, 191);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(117, 40);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 707);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 20);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 20);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Raje_Career_Academy_02.Properties.Resources.alexandre_van_thuan_mr9FouttLGY_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1303, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Add_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 727);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel_Top1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Add_Subject";
            this.Text = "frm_Add_Subject";
            this.Load += new System.EventHandler(this.frm_Add_Subject_Load);
            this.panel_Top1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Heder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_Subject_Fee;
        private System.Windows.Forms.Label lbl_Subject_ID;
        private System.Windows.Forms.TextBox tb_Subject_Name;
        private System.Windows.Forms.Label lbl_Subject_Fees;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Subject_ID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rb_Active;
        private System.Windows.Forms.RadioButton rb_InActive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
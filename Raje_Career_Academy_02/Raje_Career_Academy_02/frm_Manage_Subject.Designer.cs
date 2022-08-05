namespace Raje_Career_Academy_02
{
    partial class frm_Manage_Subject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Manage_Subject));
            this.panel_Top1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Heder = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_all_subject = new System.Windows.Forms.DataGridView();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDetailesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raje_Career_Academy_DBDataSet2 = new Raje_Career_Academy_02.Raje_Career_Academy_DBDataSet2();
            this.lbl_Subject_ID = new System.Windows.Forms.Label();
            this.tb_Subject_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Subject_Fees = new System.Windows.Forms.Label();
            this.tb_Subject_ID = new System.Windows.Forms.TextBox();
            this.tb_subject_Fee = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_Active = new System.Windows.Forms.RadioButton();
            this.rb_InActive = new System.Windows.Forms.RadioButton();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.pb_Serch = new System.Windows.Forms.PictureBox();
            this.raje_Career_Academy_DBDataSet1 = new Raje_Career_Academy_02.Raje_Career_Academy_DBDataSet1();
            this.subjectDetailesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subject_DetailesTableAdapter = new Raje_Career_Academy_02.Raje_Career_Academy_DBDataSet1TableAdapters.Subject_DetailesTableAdapter();
            this.subject_DetailesTableAdapter1 = new Raje_Career_Academy_02.Raje_Career_Academy_DBDataSet2TableAdapters.Subject_DetailesTableAdapter();
            this.panel_Top1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_subject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDetailesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raje_Career_Academy_DBDataSet2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Serch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raje_Career_Academy_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDetailesBindingSource)).BeginInit();
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
            this.panel_Top1.Size = new System.Drawing.Size(1224, 52);
            this.panel_Top1.TabIndex = 6;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Heder
            // 
            this.lbl_Heder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Heder.AutoSize = true;
            this.lbl_Heder.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heder.ForeColor = System.Drawing.Color.White;
            this.lbl_Heder.Location = new System.Drawing.Point(493, 9);
            this.lbl_Heder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Heder.Name = "lbl_Heder";
            this.lbl_Heder.Size = new System.Drawing.Size(238, 34);
            this.lbl_Heder.TabIndex = 0;
            this.lbl_Heder.Text = "Manage Subject";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 20);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 650);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 20);
            this.panel2.TabIndex = 10;
            // 
            // dgv_all_subject
            // 
            this.dgv_all_subject.AllowUserToAddRows = false;
            this.dgv_all_subject.AllowUserToDeleteRows = false;
            this.dgv_all_subject.AutoGenerateColumns = false;
            this.dgv_all_subject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_all_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_all_subject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.feesDataGridViewTextBoxColumn,
            this.stetusDataGridViewTextBoxColumn,
            this.creatorDataGridViewTextBoxColumn,
            this.modifierDataGridViewTextBoxColumn});
            this.dgv_all_subject.DataSource = this.subjectDetailesBindingSource1;
            this.dgv_all_subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_all_subject.Location = new System.Drawing.Point(0, 326);
            this.dgv_all_subject.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_all_subject.Name = "dgv_all_subject";
            this.dgv_all_subject.ReadOnly = true;
            this.dgv_all_subject.RowTemplate.Height = 24;
            this.dgv_all_subject.Size = new System.Drawing.Size(1224, 324);
            this.dgv_all_subject.TabIndex = 11;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feesDataGridViewTextBoxColumn
            // 
            this.feesDataGridViewTextBoxColumn.DataPropertyName = "Fees";
            this.feesDataGridViewTextBoxColumn.HeaderText = "Fees";
            this.feesDataGridViewTextBoxColumn.Name = "feesDataGridViewTextBoxColumn";
            this.feesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stetusDataGridViewTextBoxColumn
            // 
            this.stetusDataGridViewTextBoxColumn.DataPropertyName = "Stetus";
            this.stetusDataGridViewTextBoxColumn.HeaderText = "Stetus";
            this.stetusDataGridViewTextBoxColumn.Name = "stetusDataGridViewTextBoxColumn";
            this.stetusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creatorDataGridViewTextBoxColumn
            // 
            this.creatorDataGridViewTextBoxColumn.DataPropertyName = "Creator";
            this.creatorDataGridViewTextBoxColumn.HeaderText = "Creator";
            this.creatorDataGridViewTextBoxColumn.Name = "creatorDataGridViewTextBoxColumn";
            this.creatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifierDataGridViewTextBoxColumn
            // 
            this.modifierDataGridViewTextBoxColumn.DataPropertyName = "Modifier";
            this.modifierDataGridViewTextBoxColumn.HeaderText = "Modifier";
            this.modifierDataGridViewTextBoxColumn.Name = "modifierDataGridViewTextBoxColumn";
            this.modifierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDetailesBindingSource1
            // 
            this.subjectDetailesBindingSource1.DataMember = "Subject_Detailes";
            this.subjectDetailesBindingSource1.DataSource = this.raje_Career_Academy_DBDataSet2;
            // 
            // raje_Career_Academy_DBDataSet2
            // 
            this.raje_Career_Academy_DBDataSet2.DataSetName = "Raje_Career_Academy_DBDataSet2";
            this.raje_Career_Academy_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Subject_ID
            // 
            this.lbl_Subject_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subject_ID.AutoSize = true;
            this.lbl_Subject_ID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Subject_ID.Location = new System.Drawing.Point(128, 25);
            this.lbl_Subject_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Subject_ID.Name = "lbl_Subject_ID";
            this.lbl_Subject_ID.Size = new System.Drawing.Size(179, 34);
            this.lbl_Subject_ID.TabIndex = 120;
            this.lbl_Subject_ID.Text = "Subject ID ";
            // 
            // tb_Subject_Name
            // 
            this.tb_Subject_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Subject_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subject_Name.Location = new System.Drawing.Point(311, 108);
            this.tb_Subject_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Subject_Name.Name = "tb_Subject_Name";
            this.tb_Subject_Name.Size = new System.Drawing.Size(273, 36);
            this.tb_Subject_Name.TabIndex = 123;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Name.Location = new System.Drawing.Point(128, 109);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(179, 34);
            this.lbl_Name.TabIndex = 121;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Subject_Fees
            // 
            this.lbl_Subject_Fees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subject_Fees.AutoSize = true;
            this.lbl_Subject_Fees.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject_Fees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Subject_Fees.Location = new System.Drawing.Point(640, 25);
            this.lbl_Subject_Fees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Subject_Fees.Name = "lbl_Subject_Fees";
            this.lbl_Subject_Fees.Size = new System.Drawing.Size(135, 34);
            this.lbl_Subject_Fees.TabIndex = 124;
            this.lbl_Subject_Fees.Text = "Fees";
            // 
            // tb_Subject_ID
            // 
            this.tb_Subject_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Subject_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subject_ID.Location = new System.Drawing.Point(311, 24);
            this.tb_Subject_ID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Subject_ID.Name = "tb_Subject_ID";
            this.tb_Subject_ID.Size = new System.Drawing.Size(273, 36);
            this.tb_Subject_ID.TabIndex = 122;
            // 
            // tb_subject_Fee
            // 
            this.tb_subject_Fee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_subject_Fee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subject_Fee.Location = new System.Drawing.Point(779, 24);
            this.tb_subject_Fee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_subject_Fee.Name = "tb_subject_Fee";
            this.tb_subject_Fee.Size = new System.Drawing.Size(313, 36);
            this.tb_subject_Fee.TabIndex = 125;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.29412F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95098F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.63072F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.248366F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35621F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.89869F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.53922F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Status, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Subject_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Subject_ID, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Name, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Subject_Name, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_subject_Fee, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Subject_Fees, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Update, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_Clear, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.pb_Serch, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1224, 254);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Status.Location = new System.Drawing.Point(640, 109);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(135, 34);
            this.lbl_Status.TabIndex = 131;
            this.lbl_Status.Text = "Status";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rb_Active, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_InActive, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(780, 87);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(311, 78);
            this.tableLayoutPanel3.TabIndex = 132;
            // 
            // rb_Active
            // 
            this.rb_Active.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Active.AutoSize = true;
            this.rb_Active.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Active.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rb_Active.Location = new System.Drawing.Point(32, 25);
            this.rb_Active.Name = "rb_Active";
            this.rb_Active.Size = new System.Drawing.Size(91, 27);
            this.rb_Active.TabIndex = 0;
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
            this.rb_InActive.Location = new System.Drawing.Point(179, 25);
            this.rb_InActive.Name = "rb_InActive";
            this.rb_InActive.Size = new System.Drawing.Size(107, 27);
            this.rb_InActive.TabIndex = 0;
            this.rb_InActive.TabStop = true;
            this.rb_InActive.Text = "InActive";
            this.rb_InActive.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(640, 191);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(126, 40);
            this.btn_Update.TabIndex = 117;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(467, 191);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(117, 40);
            this.btn_Clear.TabIndex = 118;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // pb_Serch
            // 
            this.pb_Serch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pb_Serch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Serch.Image = ((System.Drawing.Image)(resources.GetObject("pb_Serch.Image")));
            this.pb_Serch.Location = new System.Drawing.Point(589, 23);
            this.pb_Serch.Name = "pb_Serch";
            this.pb_Serch.Size = new System.Drawing.Size(37, 37);
            this.pb_Serch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Serch.TabIndex = 133;
            this.pb_Serch.TabStop = false;
            this.pb_Serch.Click += new System.EventHandler(this.pb_Serch_Click);
            // 
            // raje_Career_Academy_DBDataSet1
            // 
            this.raje_Career_Academy_DBDataSet1.DataSetName = "Raje_Career_Academy_DBDataSet1";
            this.raje_Career_Academy_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectDetailesBindingSource
            // 
            this.subjectDetailesBindingSource.DataMember = "Subject_Detailes";
            this.subjectDetailesBindingSource.DataSource = this.raje_Career_Academy_DBDataSet1;
            // 
            // subject_DetailesTableAdapter
            // 
            this.subject_DetailesTableAdapter.ClearBeforeFill = true;
            // 
            // subject_DetailesTableAdapter1
            // 
            this.subject_DetailesTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_Manage_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 670);
            this.Controls.Add(this.dgv_all_subject);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel_Top1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Manage_Subject";
            this.Text = "frm_Manage_Subject";
            this.Load += new System.EventHandler(this.frm_Manage_Subject_Load);
            this.panel_Top1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_subject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDetailesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raje_Career_Academy_DBDataSet2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Serch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raje_Career_Academy_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDetailesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Heder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_all_subject;
        private System.Windows.Forms.Label lbl_Subject_ID;
        private System.Windows.Forms.TextBox tb_Subject_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Subject_Fees;
        private System.Windows.Forms.TextBox tb_Subject_ID;
        private System.Windows.Forms.TextBox tb_subject_Fee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rb_Active;
        private System.Windows.Forms.RadioButton rb_InActive;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.PictureBox pb_Serch;
        private Raje_Career_Academy_DBDataSet1 raje_Career_Academy_DBDataSet1;
        private System.Windows.Forms.BindingSource subjectDetailesBindingSource;
        private Raje_Career_Academy_DBDataSet1TableAdapters.Subject_DetailesTableAdapter subject_DetailesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifierDataGridViewTextBoxColumn;
        private Raje_Career_Academy_DBDataSet2 raje_Career_Academy_DBDataSet2;
        private System.Windows.Forms.BindingSource subjectDetailesBindingSource1;
        private Raje_Career_Academy_DBDataSet2TableAdapters.Subject_DetailesTableAdapter subject_DetailesTableAdapter1;
    }
}
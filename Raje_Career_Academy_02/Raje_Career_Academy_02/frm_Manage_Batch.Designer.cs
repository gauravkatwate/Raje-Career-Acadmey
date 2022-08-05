namespace Raje_Career_Academy_02
{
    partial class frm_Manage_Batch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Manage_Batch));
            this.panel_Top1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Heder = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Manage_Batch = new System.Windows.Forms.DataGridView();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDetailesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raje_Career_Academy_DBDataSet4 = new Raje_Career_Academy_02.Raje_Career_Academy_DBDataSet4();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_Active = new System.Windows.Forms.RadioButton();
            this.rb_InActive = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tb_Capacity = new System.Windows.Forms.TextBox();
            this.lbl_Capacity = new System.Windows.Forms.Label();
            this.tb_Batch_No = new System.Windows.Forms.TextBox();
            this.lbl_Batch_No = new System.Windows.Forms.Label();
            this.tb_Dueration = new System.Windows.Forms.TextBox();
            this.cmb_Subject = new System.Windows.Forms.ComboBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.dtp_Batch_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Dueration = new System.Windows.Forms.Label();
            this.lbl_Batch_starting_Date = new System.Windows.Forms.Label();
            this.tb_Batch_ID = new System.Windows.Forms.TextBox();
            this.lbl_Batch_ID = new System.Windows.Forms.Label();
            this.pb_Serch = new System.Windows.Forms.PictureBox();
            this.raje_Career_Academy_DBDataSet = new Raje_Career_Academy_02.Raje_Career_Academy_DBDataSet();
            this.batchDetailesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batch_DetailesTableAdapter = new Raje_Career_Academy_02.Raje_Career_Academy_DBDataSetTableAdapters.Batch_DetailesTableAdapter();
            this.batch_DetailesTableAdapter1 = new Raje_Career_Academy_02.Raje_Career_Academy_DBDataSet4TableAdapters.Batch_DetailesTableAdapter();
            this.panel_Top1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manage_Batch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchDetailesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raje_Career_Academy_DBDataSet4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Serch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raje_Career_Academy_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchDetailesBindingSource)).BeginInit();
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
            this.panel_Top1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Heder, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1303, 52);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // lbl_Heder
            // 
            this.lbl_Heder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Heder.AutoSize = true;
            this.lbl_Heder.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heder.ForeColor = System.Drawing.Color.White;
            this.lbl_Heder.Location = new System.Drawing.Point(544, 9);
            this.lbl_Heder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Heder.Name = "lbl_Heder";
            this.lbl_Heder.Size = new System.Drawing.Size(214, 34);
            this.lbl_Heder.TabIndex = 0;
            this.lbl_Heder.Text = "Manage Batch";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(882, 267);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(126, 40);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 20);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 707);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 20);
            this.panel2.TabIndex = 19;
            // 
            // dgv_Manage_Batch
            // 
            this.dgv_Manage_Batch.AllowUserToAddRows = false;
            this.dgv_Manage_Batch.AllowUserToDeleteRows = false;
            this.dgv_Manage_Batch.AutoGenerateColumns = false;
            this.dgv_Manage_Batch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Manage_Batch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Manage_Batch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchIDDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.batchNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.creatorDataGridViewTextBoxColumn,
            this.modifierDataGridViewTextBoxColumn});
            this.dgv_Manage_Batch.DataSource = this.batchDetailesBindingSource1;
            this.dgv_Manage_Batch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Manage_Batch.Location = new System.Drawing.Point(0, 400);
            this.dgv_Manage_Batch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_Manage_Batch.Name = "dgv_Manage_Batch";
            this.dgv_Manage_Batch.ReadOnly = true;
            this.dgv_Manage_Batch.RowTemplate.Height = 24;
            this.dgv_Manage_Batch.Size = new System.Drawing.Size(1303, 307);
            this.dgv_Manage_Batch.TabIndex = 20;
            this.dgv_Manage_Batch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Manage_Batch_CellContentClick);
            // 
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "BatchID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "BatchID";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            this.batchIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchNoDataGridViewTextBoxColumn
            // 
            this.batchNoDataGridViewTextBoxColumn.DataPropertyName = "BatchNo";
            this.batchNoDataGridViewTextBoxColumn.HeaderText = "BatchNo";
            this.batchNoDataGridViewTextBoxColumn.Name = "batchNoDataGridViewTextBoxColumn";
            this.batchNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
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
            // batchDetailesBindingSource1
            // 
            this.batchDetailesBindingSource1.DataMember = "Batch_Detailes";
            this.batchDetailesBindingSource1.DataSource = this.raje_Career_Academy_DBDataSet4;
            // 
            // raje_Career_Academy_DBDataSet4
            // 
            this.raje_Career_Academy_DBDataSet4.DataSetName = "Raje_Career_Academy_DBDataSet4";
            this.raje_Career_Academy_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(722, 267);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(117, 40);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.70416F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29739F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.44771F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.944445F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.19608F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.10131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.089369F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Status, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Capacity, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Capacity, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Batch_No, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Batch_No, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Dueration, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmb_Subject, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Subject, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtp_Batch_Start_Date, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Dueration, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Batch_starting_Date, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Batch_ID, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Batch_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Update, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_Clear, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.pb_Serch, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1303, 328);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rb_Active, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rb_InActive, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(289, 249);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 76);
            this.tableLayoutPanel3.TabIndex = 6;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // rb_Active
            // 
            this.rb_Active.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Active.AutoSize = true;
            this.rb_Active.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Active.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.rb_Active.Location = new System.Drawing.Point(29, 24);
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
            this.rb_InActive.Location = new System.Drawing.Point(171, 24);
            this.rb_InActive.Name = "rb_InActive";
            this.rb_InActive.Size = new System.Drawing.Size(107, 27);
            this.rb_InActive.TabIndex = 0;
            this.rb_InActive.TabStop = true;
            this.rb_InActive.Text = "InActive";
            this.rb_InActive.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Status.Location = new System.Drawing.Point(102, 270);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(182, 34);
            this.lbl_Status.TabIndex = 127;
            this.lbl_Status.Text = "Status";
            // 
            // tb_Capacity
            // 
            this.tb_Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Capacity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Capacity.Location = new System.Drawing.Point(882, 187);
            this.tb_Capacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Capacity.Name = "tb_Capacity";
            this.tb_Capacity.Size = new System.Drawing.Size(310, 36);
            this.tb_Capacity.TabIndex = 9;
            // 
            // lbl_Capacity
            // 
            this.lbl_Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Capacity.AutoSize = true;
            this.lbl_Capacity.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Capacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Capacity.Location = new System.Drawing.Point(684, 188);
            this.lbl_Capacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Capacity.Name = "lbl_Capacity";
            this.lbl_Capacity.Size = new System.Drawing.Size(194, 34);
            this.lbl_Capacity.TabIndex = 132;
            this.lbl_Capacity.Text = "Capacity";
            // 
            // tb_Batch_No
            // 
            this.tb_Batch_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Batch_No.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Batch_No.Location = new System.Drawing.Point(288, 187);
            this.tb_Batch_No.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Batch_No.Name = "tb_Batch_No";
            this.tb_Batch_No.Size = new System.Drawing.Size(302, 36);
            this.tb_Batch_No.TabIndex = 5;
            // 
            // lbl_Batch_No
            // 
            this.lbl_Batch_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Batch_No.AutoSize = true;
            this.lbl_Batch_No.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Batch_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Batch_No.Location = new System.Drawing.Point(102, 188);
            this.lbl_Batch_No.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Batch_No.Name = "lbl_Batch_No";
            this.lbl_Batch_No.Size = new System.Drawing.Size(182, 34);
            this.lbl_Batch_No.TabIndex = 130;
            this.lbl_Batch_No.Text = "Batch No";
            // 
            // tb_Dueration
            // 
            this.tb_Dueration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Dueration.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Dueration.Location = new System.Drawing.Point(882, 105);
            this.tb_Dueration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Dueration.Name = "tb_Dueration";
            this.tb_Dueration.Size = new System.Drawing.Size(310, 36);
            this.tb_Dueration.TabIndex = 8;
            // 
            // cmb_Subject
            // 
            this.cmb_Subject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Subject.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subject.FormattingEnabled = true;
            this.cmb_Subject.Location = new System.Drawing.Point(289, 105);
            this.cmb_Subject.Name = "cmb_Subject";
            this.cmb_Subject.Size = new System.Drawing.Size(300, 35);
            this.cmb_Subject.TabIndex = 4;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Subject.Location = new System.Drawing.Point(102, 106);
            this.lbl_Subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(182, 34);
            this.lbl_Subject.TabIndex = 129;
            this.lbl_Subject.Text = "Subject";
            // 
            // dtp_Batch_Start_Date
            // 
            this.dtp_Batch_Start_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Batch_Start_Date.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Batch_Start_Date.Location = new System.Drawing.Point(883, 23);
            this.dtp_Batch_Start_Date.Name = "dtp_Batch_Start_Date";
            this.dtp_Batch_Start_Date.Size = new System.Drawing.Size(308, 36);
            this.dtp_Batch_Start_Date.TabIndex = 7;
            // 
            // lbl_Dueration
            // 
            this.lbl_Dueration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Dueration.AutoSize = true;
            this.lbl_Dueration.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dueration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Dueration.Location = new System.Drawing.Point(684, 106);
            this.lbl_Dueration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Dueration.Name = "lbl_Dueration";
            this.lbl_Dueration.Size = new System.Drawing.Size(194, 34);
            this.lbl_Dueration.TabIndex = 131;
            this.lbl_Dueration.Text = "Duration";
            // 
            // lbl_Batch_starting_Date
            // 
            this.lbl_Batch_starting_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Batch_starting_Date.AutoSize = true;
            this.lbl_Batch_starting_Date.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Batch_starting_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Batch_starting_Date.Location = new System.Drawing.Point(684, 24);
            this.lbl_Batch_starting_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Batch_starting_Date.Name = "lbl_Batch_starting_Date";
            this.lbl_Batch_starting_Date.Size = new System.Drawing.Size(194, 34);
            this.lbl_Batch_starting_Date.TabIndex = 128;
            this.lbl_Batch_starting_Date.Text = "Start Date";
            // 
            // tb_Batch_ID
            // 
            this.tb_Batch_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Batch_ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Batch_ID.Location = new System.Drawing.Point(288, 23);
            this.tb_Batch_ID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Batch_ID.Name = "tb_Batch_ID";
            this.tb_Batch_ID.Size = new System.Drawing.Size(302, 36);
            this.tb_Batch_ID.TabIndex = 3;
            // 
            // lbl_Batch_ID
            // 
            this.lbl_Batch_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Batch_ID.AutoSize = true;
            this.lbl_Batch_ID.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Batch_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lbl_Batch_ID.Location = new System.Drawing.Point(102, 24);
            this.lbl_Batch_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Batch_ID.Name = "lbl_Batch_ID";
            this.lbl_Batch_ID.Size = new System.Drawing.Size(182, 34);
            this.lbl_Batch_ID.TabIndex = 122;
            this.lbl_Batch_ID.Text = "Batch ID ";
            // 
            // pb_Serch
            // 
            this.pb_Serch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pb_Serch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Serch.Image = ((System.Drawing.Image)(resources.GetObject("pb_Serch.Image")));
            this.pb_Serch.Location = new System.Drawing.Point(595, 22);
            this.pb_Serch.Name = "pb_Serch";
            this.pb_Serch.Size = new System.Drawing.Size(37, 37);
            this.pb_Serch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Serch.TabIndex = 133;
            this.pb_Serch.TabStop = false;
            this.pb_Serch.Click += new System.EventHandler(this.pb_Serch_Click);
            // 
            // raje_Career_Academy_DBDataSet
            // 
            this.raje_Career_Academy_DBDataSet.DataSetName = "Raje_Career_Academy_DBDataSet";
            this.raje_Career_Academy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batchDetailesBindingSource
            // 
            this.batchDetailesBindingSource.DataMember = "Batch_Detailes";
            this.batchDetailesBindingSource.DataSource = this.raje_Career_Academy_DBDataSet;
            // 
            // batch_DetailesTableAdapter
            // 
            this.batch_DetailesTableAdapter.ClearBeforeFill = true;
            // 
            // batch_DetailesTableAdapter1
            // 
            this.batch_DetailesTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_Manage_Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 727);
            this.Controls.Add(this.dgv_Manage_Batch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel_Top1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Manage_Batch";
            this.Text = "frm_Manage_Batch";
            this.Load += new System.EventHandler(this.frm_Manage_Batch_Load);
            this.panel_Top1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manage_Batch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchDetailesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raje_Career_Academy_DBDataSet4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Serch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raje_Career_Academy_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchDetailesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Heder;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Manage_Batch;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_Batch_ID;
        private System.Windows.Forms.Label lbl_Batch_ID;
        private System.Windows.Forms.DateTimePicker dtp_Batch_Start_Date;
        private System.Windows.Forms.Label lbl_Batch_starting_Date;
        private System.Windows.Forms.ComboBox cmb_Subject;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.TextBox tb_Capacity;
        private System.Windows.Forms.Label lbl_Capacity;
        private System.Windows.Forms.TextBox tb_Batch_No;
        private System.Windows.Forms.Label lbl_Batch_No;
        private System.Windows.Forms.TextBox tb_Dueration;
        private System.Windows.Forms.Label lbl_Dueration;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rb_Active;
        private System.Windows.Forms.RadioButton rb_InActive;
        private System.Windows.Forms.PictureBox pb_Serch;
        private Raje_Career_Academy_DBDataSet raje_Career_Academy_DBDataSet;
        private System.Windows.Forms.BindingSource batchDetailesBindingSource;
        private Raje_Career_Academy_DBDataSetTableAdapters.Batch_DetailesTableAdapter batch_DetailesTableAdapter;
        private Raje_Career_Academy_DBDataSet4 raje_Career_Academy_DBDataSet4;
        private System.Windows.Forms.BindingSource batchDetailesBindingSource1;
        private Raje_Career_Academy_DBDataSet4TableAdapters.Batch_DetailesTableAdapter batch_DetailesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifierDataGridViewTextBoxColumn;
    }
}
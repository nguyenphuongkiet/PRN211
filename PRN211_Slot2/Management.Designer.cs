namespace PRN211_Slot2
{
    partial class Management
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
            dgvBankAccount = new DataGridView();
            txtAccountName = new TextBox();
            btnCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAccountID = new TextBox();
            label3 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            label4 = new Label();
            label5 = new Label();
            txtBranchName = new TextBox();
            label13 = new Label();
            label14 = new Label();
            dtpOpenDate = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dtpOpenDateEdit = new DateTimePicker();
            txtBranchNameEdit = new TextBox();
            txtAccountIDEdit = new TextBox();
            txtAccountNameEdit = new TextBox();
            cboType = new ComboBox();
            cboTypeEdit = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvBankAccount
            // 
            dgvBankAccount.AllowUserToAddRows = false;
            dgvBankAccount.AllowUserToDeleteRows = false;
            dgvBankAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAccount.Location = new Point(11, 12);
            dgvBankAccount.Name = "dgvBankAccount";
            dgvBankAccount.ReadOnly = true;
            dgvBankAccount.RowHeadersWidth = 51;
            dgvBankAccount.RowTemplate.Height = 29;
            dgvBankAccount.Size = new Size(795, 188);
            dgvBankAccount.TabIndex = 1;
            dgvBankAccount.CellClick += dgvBankAccount_CellClick;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(129, 432);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(250, 27);
            txtAccountName.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(129, 633);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 436);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "AccountName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 485);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "OpenDate";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(129, 385);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(250, 27);
            txtAccountID.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 389);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 8;
            label3.Text = "AccountID";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(713, 633);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(285, 633);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 535);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 11;
            label4.Text = "BranchName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 581);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 12;
            label5.Text = "Type";
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(128, 531);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(250, 27);
            txtBranchName.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.MenuHighlight;
            label13.Location = new Point(11, 331);
            label13.Name = "label13";
            label13.Size = new Size(171, 35);
            label13.TabIndex = 29;
            label13.Text = "CREATE TABLE";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.MenuHighlight;
            label14.Location = new Point(447, 331);
            label14.Name = "label14";
            label14.Size = new Size(139, 35);
            label14.TabIndex = 30;
            label14.Text = "EDIT TABLE";
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.Location = new Point(129, 477);
            dtpOpenDate.MaxDate = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            dtpOpenDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.Size = new Size(250, 27);
            dtpOpenDate.TabIndex = 31;
            dtpOpenDate.Value = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 577);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 36;
            label8.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(447, 531);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 35;
            label9.Text = "BranchName";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(447, 388);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 34;
            label10.Text = "AccountID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(447, 483);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 33;
            label11.Text = "OpenDate";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(447, 432);
            label12.Name = "label12";
            label12.Size = new Size(103, 20);
            label12.TabIndex = 32;
            label12.Text = "AccountName";
            // 
            // dtpOpenDateEdit
            // 
            dtpOpenDateEdit.Location = new Point(557, 477);
            dtpOpenDateEdit.MaxDate = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            dtpOpenDateEdit.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpOpenDateEdit.Name = "dtpOpenDateEdit";
            dtpOpenDateEdit.Size = new Size(250, 27);
            dtpOpenDateEdit.TabIndex = 41;
            dtpOpenDateEdit.Value = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // txtBranchNameEdit
            // 
            txtBranchNameEdit.Location = new Point(557, 524);
            txtBranchNameEdit.Name = "txtBranchNameEdit";
            txtBranchNameEdit.Size = new Size(250, 27);
            txtBranchNameEdit.TabIndex = 39;
            // 
            // txtAccountIDEdit
            // 
            txtAccountIDEdit.Enabled = false;
            txtAccountIDEdit.Location = new Point(557, 385);
            txtAccountIDEdit.Name = "txtAccountIDEdit";
            txtAccountIDEdit.Size = new Size(250, 27);
            txtAccountIDEdit.TabIndex = 38;
            // 
            // txtAccountNameEdit
            // 
            txtAccountNameEdit.Location = new Point(557, 432);
            txtAccountNameEdit.Name = "txtAccountNameEdit";
            txtAccountNameEdit.Size = new Size(250, 27);
            txtAccountNameEdit.TabIndex = 37;
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(129, 577);
            cboType.Name = "cboType";
            cboType.Size = new Size(250, 28);
            cboType.TabIndex = 42;
            // 
            // cboTypeEdit
            // 
            cboTypeEdit.FormattingEnabled = true;
            cboTypeEdit.Location = new Point(557, 577);
            cboTypeEdit.Name = "cboTypeEdit";
            cboTypeEdit.Size = new Size(250, 28);
            cboTypeEdit.TabIndex = 43;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(128, 225);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(334, 27);
            txtSearch.TabIndex = 44;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(14, 225);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 31);
            btnSearch.TabIndex = 45;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(14, 278);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 31);
            btnRefresh.TabIndex = 46;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 740);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cboTypeEdit);
            Controls.Add(cboType);
            Controls.Add(dtpOpenDateEdit);
            Controls.Add(txtBranchNameEdit);
            Controls.Add(txtAccountIDEdit);
            Controls.Add(txtAccountNameEdit);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(dtpOpenDate);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtBranchName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label3);
            Controls.Add(txtAccountID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(txtAccountName);
            Controls.Add(dgvBankAccount);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBankAccount;
        private TextBox txtAccountName;
        private Button btnCreate;
        private Label label1;
        private Label label2;
        private TextBox txtAccountID;
        private Label label3;
        private Button btnEdit;
        private Button btnDelete;
        private Label label4;
        private Label label5;
        private TextBox txtBranchName;
        private TextBox txtTypeID;
        private Label label13;
        private Label label14;
        private DateTimePicker dtpOpenDate;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DateTimePicker dtpOpenDateEdit;
        private TextBox txtBranchNameEdit;
        private TextBox txtAccountIDEdit;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtAccountNameEdit;
        private ComboBox cboType;
        private ComboBox cboTypeEdit;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
    }
}
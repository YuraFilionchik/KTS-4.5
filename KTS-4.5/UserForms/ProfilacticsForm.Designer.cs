namespace KTS.UserForms
{
    partial class ProfilacticsForm
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
            this.dgvUSERS = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profilacticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.profilacticIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbUser = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbDevice = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilacticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUSERS
            // 
            this.dgvUSERS.AutoGenerateColumns = false;
            this.dgvUSERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUSERS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUSERS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUSERS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvUSERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSERS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profilacticIdDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn,
            this.cbUser,
            this.cbDevice});
            this.dgvUSERS.DataSource = this.profilacticBindingSource;
            this.dgvUSERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUSERS.Location = new System.Drawing.Point(0, 0);
            this.dgvUSERS.MultiSelect = false;
            this.dgvUSERS.Name = "dgvUSERS";
            this.dgvUSERS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvUSERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUSERS.Size = new System.Drawing.Size(865, 399);
            this.dgvUSERS.TabIndex = 1;
            this.dgvUSERS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUSERS_CellContentClick);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "user";
            this.dataGridViewComboBoxColumn1.HeaderText = "Оборудование";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 86;
            // 
            // userDevicesBindingSource
            // 
            this.userDevicesBindingSource.DataMember = "UserDevices";
            this.userDevicesBindingSource.DataSource = this.userBindingSource;
            // 
            // profilacticBindingSource
            // 
            this.profilacticBindingSource.DataSource = typeof(KTS.Profilactic);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(KTS.User);
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataSource = typeof(KTS.Device);
            // 
            // myContextBindingSource
            // 
            this.myContextBindingSource.DataSource = typeof(KTS.MyContext);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(KTS.User);
            // 
            // profilacticIdDataGridViewTextBoxColumn
            // 
            this.profilacticIdDataGridViewTextBoxColumn.DataPropertyName = "ProfilacticId";
            this.profilacticIdDataGridViewTextBoxColumn.HeaderText = "ProfilacticId";
            this.profilacticIdDataGridViewTextBoxColumn.Name = "profilacticIdDataGridViewTextBoxColumn";
            this.profilacticIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 66;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Содержание профилактических работ";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Периодичность (в месяцах)";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "-сотрудник";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGridViewTextBoxColumn.Visible = false;
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "-оборудование";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            this.deviceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deviceDataGridViewTextBoxColumn.Visible = false;
            this.deviceDataGridViewTextBoxColumn.Width = 106;
            // 
            // cbUser
            // 
            this.cbUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cbUser.HeaderText = "Закрепленный сотрудник";
            this.cbUser.Name = "cbUser";
            this.cbUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbUser.Width = 148;
            // 
            // cbDevice
            // 
            this.cbDevice.HeaderText = "Оборудование";
            this.cbDevice.Name = "cbDevice";
            // 
            // ProfilacticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 399);
            this.Controls.Add(this.dgvUSERS);
            this.Name = "ProfilacticsForm";
            this.Text = "Профилактики";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilacticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUSERS;
        private System.Windows.Forms.BindingSource profilacticBindingSource;
        private System.Windows.Forms.BindingSource myContextBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.BindingSource userDevicesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilacticIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbUser;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbDevice;
    }
}
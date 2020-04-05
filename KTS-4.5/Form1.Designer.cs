namespace KTS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbSelectUser = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРаботникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профилактикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обзорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеОборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.админToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.dgvExecuted = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDGVexe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFix = new System.Windows.Forms.DataGridView();
            this.menuDGVFix = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myContextBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.AllUsers = new System.Windows.Forms.CheckBox();
            this.AllDevices = new System.Windows.Forms.CheckBox();
            this.profilacticIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilacticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsExecute = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecuted)).BeginInit();
            this.menuDGVexe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFix)).BeginInit();
            this.menuDGVFix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilacticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExecute)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSelectUser
            // 
            this.cbSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbSelectUser.ItemHeight = 24;
            this.cbSelectUser.Location = new System.Drawing.Point(12, 53);
            this.cbSelectUser.Name = "cbSelectUser";
            this.cbSelectUser.Size = new System.Drawing.Size(235, 32);
            this.cbSelectUser.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.обзорToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРаботникаToolStripMenuItem,
            this.оборудованиеToolStripMenuItem,
            this.профилактикиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.менюToolStripMenuItem.Text = "Списки";
            // 
            // добавитьРаботникаToolStripMenuItem
            // 
            this.добавитьРаботникаToolStripMenuItem.Name = "добавитьРаботникаToolStripMenuItem";
            this.добавитьРаботникаToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.добавитьРаботникаToolStripMenuItem.Text = "Работники...";
            this.добавитьРаботникаToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьРаботникаToolStripMenuItem_Click);
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование...";
            this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
            // 
            // профилактикиToolStripMenuItem
            // 
            this.профилактикиToolStripMenuItem.Name = "профилактикиToolStripMenuItem";
            this.профилактикиToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.профилактикиToolStripMenuItem.Text = "Профилактики...";
            this.профилактикиToolStripMenuItem.Click += new System.EventHandler(this.профилактикиToolStripMenuItem_Click);
            // 
            // обзорToolStripMenuItem
            // 
            this.обзорToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеОборудованиеToolStripMenuItem,
            this.админToolStripMenuItem});
            this.обзорToolStripMenuItem.Name = "обзорToolStripMenuItem";
            this.обзорToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.обзорToolStripMenuItem.Text = "Обзор";
            // 
            // всеОборудованиеToolStripMenuItem
            // 
            this.всеОборудованиеToolStripMenuItem.Name = "всеОборудованиеToolStripMenuItem";
            this.всеОборудованиеToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.всеОборудованиеToolStripMenuItem.Text = "Все оборудование...";
            // 
            // админToolStripMenuItem
            // 
            this.админToolStripMenuItem.Name = "админToolStripMenuItem";
            this.админToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.админToolStripMenuItem.Text = "Админ";
            this.админToolStripMenuItem.Click += new System.EventHandler(this.админToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Работник:";
            // 
            // lbDevices
            // 
            this.lbDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.ItemHeight = 16;
            this.lbDevices.Location = new System.Drawing.Point(12, 114);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(235, 404);
            this.lbDevices.TabIndex = 3;
            // 
            // dgvExecuted
            // 
            this.dgvExecuted.AllowUserToAddRows = false;
            this.dgvExecuted.AllowUserToDeleteRows = false;
            this.dgvExecuted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExecuted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExecuted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExecuted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.device,
            this.profNumber,
            this.user,
            this.exeID});
            this.dgvExecuted.ContextMenuStrip = this.menuDGVexe;
            this.dgvExecuted.Location = new System.Drawing.Point(666, 53);
            this.dgvExecuted.Name = "dgvExecuted";
            this.dgvExecuted.ReadOnly = true;
            this.dgvExecuted.RowHeadersVisible = false;
            this.dgvExecuted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExecuted.ShowCellErrors = false;
            this.dgvExecuted.ShowCellToolTips = false;
            this.dgvExecuted.ShowEditingIcon = false;
            this.dgvExecuted.ShowRowErrors = false;
            this.dgvExecuted.Size = new System.Drawing.Size(494, 465);
            this.dgvExecuted.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.FillWeight = 1F;
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 58;
            // 
            // device
            // 
            this.device.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.device.FillWeight = 72.41963F;
            this.device.HeaderText = "Оборудование";
            this.device.Name = "device";
            this.device.ReadOnly = true;
            // 
            // profNumber
            // 
            this.profNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profNumber.FillWeight = 72.41963F;
            this.profNumber.HeaderText = "№ пункта";
            this.profNumber.Name = "profNumber";
            this.profNumber.ReadOnly = true;
            this.profNumber.Width = 80;
            // 
            // user
            // 
            this.user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.user.FillWeight = 72.41963F;
            this.user.HeaderText = "Фамилия";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Width = 81;
            // 
            // exeID
            // 
            this.exeID.HeaderText = "id";
            this.exeID.Name = "exeID";
            this.exeID.ReadOnly = true;
            this.exeID.Visible = false;
            // 
            // menuDGVexe
            // 
            this.menuDGVexe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьЗаписиToolStripMenuItem});
            this.menuDGVexe.Name = "contextMenuStrip1";
            this.menuDGVexe.Size = new System.Drawing.Size(160, 26);
            // 
            // удалитьЗаписиToolStripMenuItem
            // 
            this.удалитьЗаписиToolStripMenuItem.Name = "удалитьЗаписиToolStripMenuItem";
            this.удалитьЗаписиToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.удалитьЗаписиToolStripMenuItem.Text = "Удалить записи";
            this.удалитьЗаписиToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписиToolStripMenuItem_Click);
            // 
            // dgvFix
            // 
            this.dgvFix.AllowUserToAddRows = false;
            this.dgvFix.AllowUserToDeleteRows = false;
            this.dgvFix.AllowUserToResizeRows = false;
            this.dgvFix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFix.AutoGenerateColumns = false;
            this.dgvFix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profilacticIdDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn});
            this.dgvFix.ContextMenuStrip = this.menuDGVFix;
            this.dgvFix.DataSource = this.profilacticBindingSource;
            this.dgvFix.Location = new System.Drawing.Point(253, 53);
            this.dgvFix.Name = "dgvFix";
            this.dgvFix.ReadOnly = true;
            this.dgvFix.RowHeadersVisible = false;
            this.dgvFix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFix.ShowCellErrors = false;
            this.dgvFix.ShowCellToolTips = false;
            this.dgvFix.ShowEditingIcon = false;
            this.dgvFix.ShowRowErrors = false;
            this.dgvFix.Size = new System.Drawing.Size(407, 465);
            this.dgvFix.TabIndex = 5;
            // 
            // menuDGVFix
            // 
            this.menuDGVFix.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполнитьToolStripMenuItem});
            this.menuDGVFix.Name = "menuDGVFix";
            this.menuDGVFix.Size = new System.Drawing.Size(288, 26);
            // 
            // выполнитьToolStripMenuItem
            // 
            this.выполнитьToolStripMenuItem.Name = "выполнитьToolStripMenuItem";
            this.выполнитьToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.выполнитьToolStripMenuItem.Text = "Выполнить выбранные профилактики";
            this.выполнитьToolStripMenuItem.Click += new System.EventHandler(this.ВыполнитьToolStripMenuItemClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(259, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список профилактик для оборудоания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(666, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выполненные профилактики";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd.MMMM.yyyy";
            this.dtpFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFrom.Location = new System.Drawing.Point(904, 29);
            this.dtpFrom.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(123, 20);
            this.dtpFrom.TabIndex = 7;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Location = new System.Drawing.Point(1042, 29);
            this.dtpTo.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(118, 20);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(1030, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // AllUsers
            // 
            this.AllUsers.AutoSize = true;
            this.AllUsers.Location = new System.Drawing.Point(98, 30);
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.Size = new System.Drawing.Size(101, 17);
            this.AllUsers.TabIndex = 9;
            this.AllUsers.Text = "Все работники";
            this.AllUsers.UseVisualStyleBackColor = true;
            this.AllUsers.CheckedChanged += new System.EventHandler(this.AllUsers_CheckedChanged);
            // 
            // AllDevices
            // 
            this.AllDevices.AutoSize = true;
            this.AllDevices.Location = new System.Drawing.Point(98, 91);
            this.AllDevices.Name = "AllDevices";
            this.AllDevices.Size = new System.Drawing.Size(119, 17);
            this.AllDevices.TabIndex = 10;
            this.AllDevices.Text = "Все оборудование";
            this.AllDevices.UseVisualStyleBackColor = true;
            this.AllDevices.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // profilacticIdDataGridViewTextBoxColumn
            // 
            this.profilacticIdDataGridViewTextBoxColumn.DataPropertyName = "ProfilacticId";
            this.profilacticIdDataGridViewTextBoxColumn.HeaderText = "ProfilacticId";
            this.profilacticIdDataGridViewTextBoxColumn.Name = "profilacticIdDataGridViewTextBoxColumn";
            this.profilacticIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.profilacticIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "№";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 43;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 64.93507F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Содержание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.FillWeight = 135.0649F;
            this.periodDataGridViewTextBoxColumn.HeaderText = "Период(мес)";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodDataGridViewTextBoxColumn.Width = 96;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "user";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Visible = false;
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "device";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            this.deviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.deviceDataGridViewTextBoxColumn.Visible = false;
            // 
            // profilacticBindingSource
            // 
            this.profilacticBindingSource.DataSource = typeof(KTS.Profilactic);
            // 
            // myContextBindingSource1
            // 
            this.myContextBindingSource1.DataSource = typeof(KTS.MyContext);
            // 
            // myContextBindingSource
            // 
            this.myContextBindingSource.DataSource = typeof(KTS.MyContext);
            // 
            // bsExecute
            // 
            this.bsExecute.DataSource = typeof(KTS.Execution);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 536);
            this.Controls.Add(this.AllDevices);
            this.Controls.Add(this.AllUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFix);
            this.Controls.Add(this.dgvExecuted);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 574);
            this.Name = "Form1";
            this.Text = "КТС";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecuted)).EndInit();
            this.menuDGVexe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFix)).EndInit();
            this.menuDGVFix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilacticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExecute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuDGVFix;
        private System.Windows.Forms.BindingSource bsExecute;

        #endregion

        private System.Windows.Forms.ComboBox cbSelectUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРаботникаToolStripMenuItem;
        private System.Windows.Forms.BindingSource myContextBindingSource1;
        private System.Windows.Forms.BindingSource myContextBindingSource2;
        private System.Windows.Forms.BindingSource myContextBindingSource;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профилактикиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvExecuted;
        private System.Windows.Forms.DataGridView dgvFix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn profilacticIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profilacticBindingSource;
        private System.Windows.Forms.ContextMenuStrip menuDGVexe;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписиToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ToolStripMenuItem обзорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеОборудованиеToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn device;
        private System.Windows.Forms.DataGridViewTextBoxColumn profNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn exeID;
        private System.Windows.Forms.ToolStripMenuItem админToolStripMenuItem;
        private System.Windows.Forms.CheckBox AllUsers;
        private System.Windows.Forms.CheckBox AllDevices;
    }
}


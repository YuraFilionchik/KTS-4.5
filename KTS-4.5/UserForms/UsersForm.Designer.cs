namespace KTS.UserForms
{
    partial class UsersForm
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
            this.dgvUSERS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSERS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUSERS
            // 
            this.dgvUSERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUSERS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUSERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUSERS.Location = new System.Drawing.Point(0, 0);
            this.dgvUSERS.MultiSelect = false;
            this.dgvUSERS.Name = "dgvUSERS";
            this.dgvUSERS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvUSERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUSERS.Size = new System.Drawing.Size(411, 399);
            this.dgvUSERS.TabIndex = 1;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 399);
            this.Controls.Add(this.dgvUSERS);
            this.Name = "UsersForm";
            this.Text = "Работники";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSERS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUSERS;
    }
}
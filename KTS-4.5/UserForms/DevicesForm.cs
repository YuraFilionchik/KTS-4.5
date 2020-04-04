using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTS.UserForms
{
    
    public partial class DevicedForm : Form
    {
        MyContext DB;
        private BindingSource bsDevs = new BindingSource();
        private BindingSource bsProfs = new BindingSource();
        public DevicedForm(MyContext db)
        {
            InitializeComponent();
            this.FormClosing += Users_FormClosing;
            //dgvUSERS.SelectionChanged += DgvUSERS_SelectionChanged;
            DB = db;
            DB.Devices.Load();
            dgvDevices.DataSource = DB.Devices.Local.ToBindingList();
            dgvDevices.Columns[2].Visible = false;
            dgvDevices.Columns[3].HeaderText = "Дата";
            dgvDevices.Columns[0].HeaderText = "Название";
            dgvDevices.Columns[1].HeaderText = "Инв.№";
            
            bsDevs.DataSource = ObservableCollectionExtensions.ToBindingList(DB.Devices.Local);
            
        }

        private void DgvUSERS_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SaveChanges();
        }
    }
}

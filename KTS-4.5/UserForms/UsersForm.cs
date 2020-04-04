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
    
    public partial class UsersForm : Form
    {
        MyContext DB;
        private User SelectedUser;
        //private BindingSource bsDevs = new BindingSource();
       // private BindingSource bsProfs = new BindingSource();
        public UsersForm(MyContext db)
        {
            InitializeComponent();
            this.FormClosing += Users_FormClosing;
            //dgvUSERS.SelectionChanged += DgvUSERS_SelectionChanged;
            DB = db;
            DB.Users.Load();

            SetupTable();
           // bsDevs.DataSource = ObservableCollectionExtensions.ToBindingList(DB.Devices.Local);
            
        }

 private void SetupTable()
        {
            try
            {
                dgvUSERS.DataSource = DB.Users.Local.ToBindingList();
                dgvUSERS.Columns[3].Visible = false;
                dgvUSERS.Columns[0].HeaderText = "Фамилия";
                dgvUSERS.Columns[1].HeaderText = "Имя";
                dgvUSERS.Columns[2].HeaderText = "Отчество";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SetupTable");
            }
        }
        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SaveChanges();
        }
    }
}

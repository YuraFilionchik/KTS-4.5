using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ObservableCollectionExtensions = Microsoft.EntityFrameworkCore.ObservableCollectionExtensions;

namespace KTS
{
    public partial class AddUserForm : Form
    {
        MyContext DB;
        private User SelectedUser;
        private BindingSource bsDevs = new BindingSource();
        private BindingSource bsProfs = new BindingSource();
        public AddUserForm(MyContext db)
        {
            InitializeComponent();
            this.FormClosing += AddUserForm_FormClosing;
            dgvUSERS.SelectionChanged += DgvUSERS_SelectionChanged;
            DB = db;
            DB.Users.Load();
            dgvUSERS.DataSource = DB.Users.Local.ToBindingList();
            dgvUSERS.Columns[3].Visible = false;
            dgvUSERS.Columns[0].HeaderText = "Фамилия";
            dgvUSERS.Columns[1].HeaderText = "Имя";
            dgvUSERS.Columns[2].HeaderText = "Отчество";
            bsDevs.DataSource=ObservableCollectionExtensions.ToBindingList(DB.Devices.Local);
            cbAllDevs.DataSource = bsDevs;
        }

        //Select User -> Display users Devices
        private void DgvUSERS_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvUSERS.SelectedRows.Count==0)return;
            var userID = dgvUSERS.SelectedRows[0].Cells[3].Value;
            var user = DB.Users.Find(userID);
         
            if(user==null)return;
            SelectedUser = user;
            if (user.UserDevices == null)lbUserDevs.DataSource=null;
            else lbUserDevs.DataSource = user.UserDevices;
        }

        private void AddUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SaveChanges();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User newuser = new User();
            if (String.IsNullOrWhiteSpace(textBox1.Text)) return;
            newuser.Familia = textBox1.Text.Trim();
            newuser.Name = textBox2.Text.Trim();
            newuser.Sec_Name = textBox3.Text.Trim();
            DB.Users.Add(newuser);
            DB.SaveChanges();
            dgvUSERS.ResetBindings();
            //dgvUSERS.DataSource = DB.Users.Local.ToBindingList();
        }

       


        //TODO сделать моментальное отображение новых devs у пользоваеля в списке
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lbUserDevs.SelectedItems.Count==0 
               || SelectedUser==null) return;
            var name =(Device) lbUserDevs.SelectedItem;
            SelectedUser.UserDevices.Remove(name);
            DB.SaveChanges();
           
            lbUserDevs.ResetBindings();
        }
    }
}

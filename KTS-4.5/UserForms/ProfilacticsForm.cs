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
    
    public partial class ProfilacticsForm : Form
    {
        MyContext DB;
        private BindingSource bsDevs = new BindingSource();
        private BindingSource bsProfs = new BindingSource();
        string userBindedColumn = "userDataGridViewTextBoxColumn"; //name of column with binded datasource
        string devBindedColumn= "deviceDataGridViewTextBoxColumn"; //name of column with binded datasource
        string userCBcolumn = "cbUser"; //name of column with combobox
        string devCBcolumn = "cbDevice"; //name of column with combobox
        public ProfilacticsForm(MyContext db)
        {
            InitializeComponent();
            this.FormClosing += Users_FormClosing;
            this.dgvUSERS.EditingControlShowing += DgvUSERS_EditingControlShowing;
            this.Shown += ProfilacticsForm_Shown;
            dgvUSERS.DataError += DgvUSERS_DataError;
           // dgvUSERS.SelectionChanged += DgvUSERS_SelectionChanged;
            DB = db;
            DB.Devices.Load();
            DB.Profilactics.Load();
            DB.Users.Load();
            dgvUSERS.DataSource = DB.Profilactics.Local.ToBindingList();
            //profilacticBindingSource.DataSource = DB.Profilactics.Local.ToBindingList();
            userBindingSource.DataSource = DB.Users.Local.ToBindingList();
            deviceBindingSource.DataSource = DB.Devices.Local.ToBindingList();
            // dgvUSERS.Columns[0].Visible = false;//ID
            //dgvUSERS.Columns[4].Visible = false;//user
            //dgvUSERS.Columns[5].Visible = false;//device
            //dgvUSERS.Columns[3].HeaderText = "Периодичность (месяцев)";
            //dgvUSERS.Columns[1].HeaderText = "Номер";
            //dgvUSERS.Columns[2].HeaderText = "Описание";


           // bsDevs.DataSource = ObservableCollectionExtensions.ToBindingList(DB.Devices.Local);
            
           
        }
        //обработка исключений DataError в DataGridView
        private void DgvUSERS_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
         //   MessageBox.Show(sender.ToString());
        }

        //Загрузка списка профилактик
        //Заполнение DataGridView
        private void ProfilacticsForm_Shown(object sender, EventArgs e)
        {
            try
            {
                #region add comboboxColumn
                // DataGridViewComboBoxColumn cbcUser = new DataGridViewComboBoxColumn();
                // DataGridViewComboBoxColumn cbcDev = new DataGridViewComboBoxColumn();
                // cbcUser.HeaderText = "Работник";
                //cbcDev.HeaderText = "Оборудование";
                // cbcUser.Name = "familia";
                // cbcDev.Name = "deviceName";
                (dgvUSERS.Columns["cbUser"] as DataGridViewComboBoxColumn).Items.AddRange(DB.UserList());     //сотрудник
            (dgvUSERS.Columns["cbDevice"]  as DataGridViewComboBoxColumn).Items.AddRange(DB.DevList());   //оборудование
           
             //   cbcUser.Items.AddRange(DB.UserList());
             //cbcDev.Items.AddRange(DB.DevList());
             //cbc.DisplayMember = "Familia";
             //TODO bind Combobox and DB
             // dgvUSERS.Columns.Add(cbcDev);
             // dgvUSERS.Columns.Add(cbcUser);
                #endregion
                SetFirstValuesDGV();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Загрузка формы профилактик");
            }
           
        }

        //завершение загрузки данных datagridview
        //Fill ComboBoxes in dgvUsers
        private  void SetFirstValuesDGV()
        {
            try
            {
                
                //подставляем начальные значение в Combobox из Binded ячейки
            foreach (DataGridViewRow row in dgvUSERS.Rows)
            {
                var familia = row.Cells[userBindedColumn].Value; //фаммилия работника
                var deviceName = row.Cells[devBindedColumn].Value; //название оборудования
                User userInRow;
                Device deviceInRow;
                if (familia != null && !string.IsNullOrEmpty(familia.ToString()))
                {
                   userInRow = DB.GetUserByFamily(familia.ToString().Split(' ')[0]);// user
                  
                    row.Cells[userCBcolumn].Value = userInRow.ToString();//присваиваем начальное значение комбобоксу из скрытого столбца
                }
                if (deviceName != null && !string.IsNullOrEmpty(deviceName.ToString()))
                {
                    deviceInRow = DB.GetDeviceByName(deviceName.ToString()); //device
                    row.Cells[devCBcolumn].Value = deviceInRow.ToString();//присваиваем начальное значение комбобоксу из скрытого столбца
                    
                }
                
                
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SetFirstValuesDGV");
            }
            
        }
        private void DgvUSERS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

           
        }

        //ComboboxSelected
        private void DgvUSERS_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                (e.Control as ComboBox).SelectedIndexChanged -= new EventHandler(cmb_SelectedIndexChanged);
              (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);
            }
        }
        //combobox in DataGridView
        /// <summary>
        /// подставляем выбранный элемент combobox в связанный с базой столбец
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string devNamecolumn = "deviceDataGridViewTextBoxColumn"; //binded column
                string devComboBoxColumn = "cbDevice"; //столбец с выпадающим списком
                string usernamecolumn = "userDataGridViewTextBoxColumn"; //binded column
                string userComboBoxColumn = "cbUser"; //столбец с выпадающим списком
                int rindex = dgvUSERS.CurrentCell.RowIndex; 
                int Column = dgvUSERS.CurrentCell.ColumnIndex;//combobox column
                if (dgvUSERS.Columns[Column].Name == devComboBoxColumn)
                {
                    var selectedDev = (sender as ComboBox).SelectedItem.ToString();
                    var device = DB.Devices.FirstOrDefault(x => x.Name == selectedDev);
                    if (device == null) return;
                    dgvUSERS.Rows[rindex].Cells[devNamecolumn].Value = device;
                }
                else if (dgvUSERS.Columns[Column].Name == userComboBoxColumn)
                {
                    var selectedUser = (sender as ComboBox).SelectedItem.ToString().Split(' ')[0];
                    var user = DB.Users.FirstOrDefault(x => x.Familia == selectedUser); //find User
                    if (user == null) return;
                    dgvUSERS.Rows[rindex].Cells[usernamecolumn].Value = user; //set value to binded field
                }
            }
            catch (Exception )
            {

            }
            
        }

        private void DgvUSERS_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SaveChanges();
        }

        private void DgvUSERS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

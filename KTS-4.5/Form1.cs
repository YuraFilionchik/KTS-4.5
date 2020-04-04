using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Entity;
namespace KTS
{
    public partial class Form1 : Form
    {
        
        MyContext DB = new MyContext();
        private BindingSource bsDevs=new BindingSource();
        private BindingSource bsUsers=new BindingSource();
        public User SelectedUser;
        public Device SelectedDevice;
        public delegate void AdminChanged(bool isadmin);
        public event AdminChanged adminChanged;
        private bool isAdmin=false;
        public bool IsAdmin {
            get
            { return isAdmin; }
            set {
                ChangeAdmin(value);
                isAdmin = value; }
        }
        string PassFileName = "conf.cfg";
        public Form1()
        {
            InitializeComponent();
            #region Подписка на события
            this.FormClosed += Form1_FormClosed;
            cbSelectUser.SelectedIndexChanged += CbSelectUser_SelectedIndexChanged;
            lbDevices.SelectedIndexChanged += LbDevices_SelectedIndexChanged;
            dgvFix.SelectionChanged+= dgvFix_SelectedIndexChanged;
            adminChanged += ChangeAdmin;
            #endregion
            dtpFrom.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtpTo.Value = DateTime.Today;
            #region Вывод всех пользователей
            DB.Users.Load();
            bsUsers.DataSource= DB.Users.Local.ToBindingList();
            cbSelectUser.DataSource = bsUsers;
            #endregion



        }
        //event Changing admin status
        private void ChangeAdmin(bool isadmin)
        {
            if (isadmin)
            {
                this.Text = "КТС - Администратор";
            }
            else
            {
                this.Text = "КТС";
            }
        }

        /// <summary>
        /// Select Device and Show profilactics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Device selectedDevice = (sender as ListBox).SelectedItem as Device; //выбранное оборудование
                SelectedDevice=selectedDevice??null;
                //теперь ищем закрепленные профилактики для него
                DB.Profilactics.Load();
                DB.Devices.Load();
                DB.Users.Load();
                if (cbSelectUser.SelectedItem == null) return;                
                User user = cbSelectUser.SelectedItem as User;
                if (user == null) return;
                if (DB.Users.Count() == 0) return;
                var FixProf = DB.Profilactics.Local.Where(x => x.device.DeviceId == selectedDevice.DeviceId && x.user.UserId==user.UserId);
                if (FixProf == null) return;
                //вывод закрепленных профилактив в DataGridView dgvFix
                BindingSource bsFix = new BindingSource();
                bsFix.DataSource = FixProf;
                dgvFix.DataSource = bsFix;
                ColorRowsDGVFix();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при выборе оборудования из списка");
            }
        }

        //Раскрашивание строк профилактик в зависимости от сроков последней отмеченной профилактики
        private void ColorRowsDGVFix()
        {
            for(int i=0;i<dgvFix.Rows.Count;i++)
            {
                dgvFix.Rows[i].DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                string stringID = dgvFix.Rows[i].Cells[0].Value.ToString();
                if (string.IsNullOrWhiteSpace(stringID)) continue;
                int id = int.Parse(stringID);
                if (DB.NeedExecute(id))
                {
                    dgvFix.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else dgvFix.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        //Select User -> Display devices
        private void CbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    lbDevices.Items.Clear();
            
            if (cbSelectUser.SelectedItem == null) return;
            DB.Users.Load();
            User user = cbSelectUser.SelectedItem as User;
            if (user == null) return;
            if (DB.Users.Count() == 0) return;
            SelectedUser=user;
            

            ShowDevicesByUsers(new List<User>() {user });
        }

        /// <summary>
        /// Выводит список оборудования в lbDevices для указанных работников
        /// </summary>
        /// <param name="users"></param>
       public void ShowDevicesByUsers(List<User> users)
        {
            List<Device> AllDevs = new List<Device>();
            foreach (var user in users)
            {
                AllDevs.AddRange(DB.GetDevsByUser(user).Distinct());
            }
            var userDevs = AllDevs.Distinct();
            if (userDevs == null) return;
            lbDevices.Items.Clear();
            lbDevices.Items.AddRange(userDevs.ToArray());
        }
         //view all Executed profilactics
         private void dgvFix_SelectedIndexChanged(object sender, EventArgs e)
        {

            ShowSelectedProfilacticsEXE();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        //TODO check existing name-fam
        private void ДобавитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
             UserForms.UsersForm UserForm = new UserForms.UsersForm(DB);
            UserForm.ShowDialog();
            DB.Users.Load();

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        //Добавление -удаление оборудования
        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForms.DevicedForm DevsForm = new UserForms.DevicedForm(DB);
            DevsForm.ShowDialog();
            DB.Devices.Load();
        }

        //редактирование профилактик
        private void профилактикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
UserForms.ProfilacticsForm ProfForm = new UserForms.ProfilacticsForm(DB);
            ProfForm.ShowDialog();
            DB.Profilactics.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Открытие окна профилактик");
            }
            
        }
        
        //выполнение профилактик
        //выбраны пункты dgvFix одна или несколько строк
        void ВыполнитьToolStripMenuItemClick(object sender, EventArgs e)
        {
        	try {
        		if(dgvFix.SelectedRows.Count==0)return;
        		List<Profilactic> selectedProfilactics=new List<Profilactic>();
        		//получаем список выбранных профилактик
        		foreach (DataGridViewRow row in dgvFix.SelectedRows) {
        			int profId=(int)row.Cells[0].Value;
        			selectedProfilactics.Add(DB.Profilactics.Local.FirstOrDefault(x=>x.ProfilacticId==profId));
        		}
        		//добавляем в базу записи о выполнении
        		DateTime today=DateTime.Today;
        		foreach (var prof in selectedProfilactics) {
        			ExecuteProfilactic(prof.ProfilacticId, SelectedUser.UserId, SelectedDevice.DeviceId, today);
        		}
        		DB.SaveChanges();
                ShowSelectedProfilacticsEXE();
            } catch (Exception ex) {
        		MessageBox.Show(ex.Message, "Выполнение профилактик");
        	}
        }
        /// <summary>
        /// Выводит список выполнений для выбранных профилактик 
        /// </summary>
        private void ShowSelectedProfilacticsEXE()
        {
            try
            {
                if (dgvFix.SelectedRows.Count == 0) return;
                List<int> listID = new List<int>(); //список ID выбранных профилактик
                foreach (DataGridViewRow row in dgvFix.SelectedRows)
                {
                    listID.Add((int)row.Cells[0].Value);
                }
                IQueryable<Execution> allExe = null;
                //для каждого ID профилактики выводим список выполненных
                for (int i = 0; i < listID.Count; i++)
                {
                    int id = listID[i];

                    var exeList = DB.Executions.Where(
                    x => x.DeviceId == SelectedDevice.DeviceId &&
                    x.UserId == SelectedUser.UserId &&
                    x.ProfId == id);
                    if (i == 0) allExe = exeList;
                    else allExe = allExe.Concat(exeList);

                }

                var groupedExe = allExe.GroupBy(x => x.ExeDate); //группировка по времени
                dgvExecuted.Rows.Clear();
                foreach (var group in groupedExe)
                {//перебор групп datetime
                    var devGroups = group.GroupBy(c => c.DeviceId);//группировка по оборудованию
                    foreach (var devGroup in devGroups) //перебор групп оборудования
                    {
                        var ind = dgvExecuted.Rows.Add();
                        var firstExe = devGroup.First();
                        dgvExecuted.Rows[ind].Cells[0].Value = firstExe.ExeDate.ToShortDateString();
                        dgvExecuted.Rows[ind].Cells[1].Value = DB.Devices.First(x => x.DeviceId == firstExe.DeviceId).Name;
                        dgvExecuted.Rows[ind].Cells[3].Value = DB.Profilactics.First(x => x.ProfilacticId == firstExe.ProfId).user;
                        string profNums = "";
                        string exeID = "";
                        foreach (var exe in devGroup)
                        { //перебор профилактик внутри каждой группы оборудования
                            profNums += DB.Profilactics.First(x => x.ProfilacticId == exe.ProfId).Number;
                            if (devGroup.Count()!=1) profNums +="; ";
                            exeID += exe.ExecutionId + ";";
                        }
                        dgvExecuted.Rows[ind].Cells[2].Value = profNums;
                        dgvExecuted.Rows[ind].Cells[4].Value = exeID;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Показ выполненных профилактик");
            }
        }
        public void ExecuteProfilactic(int profID, int userID, int devID, DateTime date)
        {
        	
        	DB.Executions.Add(new Execution()
        			                  {
        			                  	UserId=userID,
        			                  DeviceId=devID,
        			                  ProfId=profID,
        			                  ExeDate=date
        			                  });
        }

        private void удалитьЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvExecuted.SelectedRows.Count == 0) return;
            foreach (DataGridViewRow row in dgvExecuted.SelectedRows)
            {
                var ids = row.Cells[4].FormattedValue.ToString().Split(';');
                foreach (var id in ids) //перебор всех пунктов выполненных профилактик в данной строке
                {
                    if (string.IsNullOrWhiteSpace(id)) continue;
                    int ID = int.Parse(id);
                   var delEXE= DB.Executions.First(x => x.ExecutionId == ID);
                    DB.Executions.Remove(delEXE);
                }
            }
            DB.SaveChanges();
            ShowSelectedProfilacticsEXE();
        }

        //Авторизация
        private void админToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsAdmin) { IsAdmin = false; return; }
                    
                if(!System.IO.File.Exists(PassFileName)) { MessageBox.Show("Пароль администратора не задан"); return; }
                string readpass = System.IO.File.ReadAllText(PassFileName).Trim();
                if (string.IsNullOrWhiteSpace(readpass)) { MessageBox.Show("Пароль администратора не задан"); return; }
                UserForms.LoginForm LF = new UserForms.LoginForm(readpass);
                var dr=LF.ShowDialog();
                if(dr!=DialogResult.OK) { return; }
                if (LF.Password.Text == readpass)
                {
                    IsAdmin = true;
                    
                }

            }
            catch (Exception ex)
            {
MessageBox.Show(ex.Message, "Authorize");
            }
        }


        //CheckBox ВСЕ РАБОТНИКИ
        private void AllUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (AllUsers.Checked)
            {
                cbSelectUser.Enabled = false;
                ShowDevicesByUsers(DB.ListUsers());
                return;
            }
            else if (SelectedUser != null) ShowDevicesByUsers(new List<User>() { SelectedUser });
            cbSelectUser.Enabled = true;
        }

        //CheckBox ВСЁ ОБОРУДОВАНИЕ
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}

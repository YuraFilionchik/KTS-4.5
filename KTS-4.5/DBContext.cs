using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace KTS
{
   public class MyContext : DbContext
    {
        public MyContext() : base("MyContext") { }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
          }
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Profilactic> Profilactics { get; set; }
        public DbSet<Execution> Executions{get;set;}


        public bool NeedExecute(int profID)
        {
            int delta = 3;//days delta for period
            var prof = Executions.Where(x => x.ProfId == profID);
            if (prof == null || prof.Count()==0) return true;
            DateTime lastExe = prof.Max(c=>c.ExeDate);
            if (lastExe == null) return true;
            var currentMonth = DateTime.Today.Month;
            float interval = Profilactics.First(x => x.ProfilacticId == profID).Period;
                if ((DateTime.Today - lastExe).TotalDays+delta < (interval * 30)) return false;
                else return true;
        }
        public User GetUserByFamily(string family)
        {
            var usr = Users.FirstOrDefault(x => x.Familia == family);
             return usr;
        }
        public Device GetDeviceByName(string devName)
        {
            var Dev = Devices.FirstOrDefault(x => x.Name == devName);
            return Dev;
        }
        public List<Device> GetDevByUser(String Famil)
        {
            this.Users.Load();
            
            if (!Users.Any(x => x.Familia == Famil)) return new List<Device>();
           User u = Users.First(x => x.Familia == Famil);   
            List<Device> DevList = new List<Device>();  
            var user_profilactics = Profilactics.Where(x => x.user == u); //все закрепленные профилактики работника
            if (user_profilactics.Count() == 0) return new List<Device>();
            DevList.AddRange(from prof in user_profilactics
                             where !DevList.Contains(prof.device)
                             select prof.device);
            return DevList;
            
        }
        public List<Device> GetDevsByUser(User u)
        {
            this.Profilactics.Load();
            List<Device> DevList = new List<Device>();
            //DbSet<Profilactic> user_profilactics = Profilactics.; //все закрепленные профилактики работника
            //if (user_profilactics.Count() == 0) return new List<Device>();
            DevList = Profilactics.Where(x => x.user.UserId == u.UserId).
                Select(x=>x.device).ToList();
            //TODO remove dublicates
            for (int i = 0; i <DevList.Count; i++)
            {
                if (DevList.Count(x => x.DeviceId == DevList[i].DeviceId) > 1) DevList.RemoveAt(i);
            }
            return DevList;
           
        }
        public string[] UserList()
        {
            var list = new List<string>();
            foreach (var usr in Users)
            {
                list.Add(usr.ToString());
            }
            return list.ToArray();
        }
        public User[] ListUsers()
        {
            List<User> returnUsers = new List<User>();
            foreach (var user in Users)
            {
                returnUsers.Add(user);
            }
            return returnUsers.ToArray();
        }
        public string[] DevList()
        {
            var list = new List<string>();
            foreach (var dev in Devices)
            {
                list.Add(dev.Name);
            }
            return list.ToArray();
        }
    }
    public class Profilactic
    {
        public int ProfilacticId { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Перидичность проведения профилактики в месяцах
        /// </summary>
        public float Period { get; set; }
       public  User user { get; set; }
       public Device device { get; set; }
       

        public override string ToString()
        {
            return Number + "=" + Description + "=" + Period + " месяц=" + user.Familia;// +"="+device.Name;
        }
    }
    public class User
    {
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Sec_Name { get; set; }
        public int UserId { get; set; }

        public virtual List<Device> UserDevices { get; set; }
        public virtual List<Profilactic> UserProfilactics { get; set; }
        public override string ToString()
        {
            if (Familia != null && Name != null && Sec_Name != null &&
                Name.Length > 0 && Sec_Name.Length > 0)
                return Familia + " " + Name[0] + ". " + Sec_Name[0] + ".";
            else if (Familia != null) return Familia;
            else if (Name != null) return Name;
            else if (Sec_Name != null) return Sec_Name;
            else return "empty";
        }
       
    }

    public class Device
    {
        public string Name { get; set; }
        //public string ShortName { get; set; }
        public string Invent { get; set; }
        public int DeviceId { get; set; }
        public string Date { get; set; }
        public virtual List<User> DevUsers { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Execution
    {
        public int ExecutionId { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public int ProfId { get; set; }
        public DateTime ExeDate { get; set; }

    }


}


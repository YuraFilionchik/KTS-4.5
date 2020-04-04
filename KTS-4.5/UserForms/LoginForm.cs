using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTS.UserForms
{
    public partial class LoginForm : Form
    {
        string Pass;
        public LoginForm()
        {
            InitializeComponent();
            Pass = "";
            Password.TextChanged += Password_TextChanged;
        }
        public LoginForm(string pass)
        {
            InitializeComponent();
            Pass = pass;
            Password.TextChanged += Password_TextChanged;
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.MaskCompleted && Pass == Password.Text)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasyRP_launcher
{
    public partial class Se_connecter: Form
    {
        public Se_connecter()
        {
            InitializeComponent();
        }
        public static string username;
        private void Se_connecter_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.remembermeAct == true)
            {
                txtUsername.Text = Properties.Settings.Default.username;
                checkremember.Checked = true;

            }
        }

        private void Exitbox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Tu dois entrer ton GamerTag", "GasyRP");
            }
            else
            {
                if (checkremember.Checked)
                {
                    Properties.Settings.Default.remembermeAct = true;
                    Properties.Settings.Default.username = txtUsername.Text;
                }
                else
                {
                    Properties.Settings.Default.remembermeAct = false;
                    Properties.Settings.Default.username = "none";
                }
                Properties.Settings.Default.Save();
                username = txtUsername.Text;
                ecranprincipale x = new ecranprincipale();
                x.Show();
                Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.remembermeAct == true)
            {
                txtUsername.Text = Properties.Settings.Default.username;
                checkremember.Checked = true;

            }
        }

        private void checkremember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
   
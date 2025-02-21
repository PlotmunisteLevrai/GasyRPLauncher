using CmlLib.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core.Auth;
using CmlLib.Core.Version;
using CmlLib.Core.ProcessBuilder;

namespace GasyRP_launcher
{
    public partial class ecranprincipale: Form
    {
        //https://cravatar.eu/helmavatar/Null/190.png
        public ecranprincipale()
        {
            InitializeComponent();
            this.Icon = new Icon(@"C:\Users\rivot\OneDrive\Desktop\fichier c#\gasyrplogowin.ico");
        }
        string username;
        private void ecranprincipale_Load(object sender, EventArgs e)
        {
            username = Se_connecter.username;
            lbluser.Text = username;
            displaySkinHead();
            listVersions();
        }
        private void displaySkinHead()
        {
            try
            {
                var request = WebRequest.Create("https://cravatar.eu/helmavatar/" + username + "/190.png");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                    pictureBox1.Image = Bitmap.FromStream(stream);
            }
            catch
            {
                var request = WebRequest.Create("https://cravatar.eu/helmavatar/Null/190.png");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                    pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }

        private async Task listVersions()
        {

            var path = new MinecraftPath(Environment.GetEnvironmentVariable("APPDATA") + "/.GasyRP");
            var launcher = new MinecraftLauncher(path);
            var versions = await launcher.GetAllVersionsAsync();
            foreach(var version in versions)
            {   if (version.Type == "release")
                {
                    comboVersions.Items.Add(version.Name);
                }
                
            }
        }

        private async void startMinecraft()
        {
            var path = new MinecraftPath(Environment.GetEnvironmentVariable("APPDATA") + "/.GasyRP");
            var launcher = new MinecraftLauncher(path);

            launcher.FileProgressChanged += (sender, args) =>
            {
                progressBar.Maximum = args.TotalTasks;
                progressBar.Value = args.ProgressedTasks;
                progressBar.Text = args.Name;

            };

            await launcher.InstallAsync(comboVersions.SelectedItem.ToString());
            var process = await launcher.BuildProcessAsync(comboVersions.SelectedItem.ToString(), new MLaunchOption
            {
                Session = MSession.CreateOfflineSession(username),
                MaximumRamMb = 4096,
                FullScreen = true
            });
            process.Start();
        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

       

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vers_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            startMinecraft();
            vers.Enabled = false;
            comboVersions.Enabled = false;
        }
    }
}

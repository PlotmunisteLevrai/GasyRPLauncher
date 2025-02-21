namespace GasyRP_launcher
{
    partial class ecranprincipale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ecranprincipale));
            this.Lblusername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lbluser = new System.Windows.Forms.Label();
            this.Exitbox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboVersions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.vers = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lblusername
            // 
            this.Lblusername.BackColor = System.Drawing.Color.Transparent;
            this.Lblusername.Location = new System.Drawing.Point(35, 688);
            this.Lblusername.Name = "Lblusername";
            this.Lblusername.Size = new System.Drawing.Size(86, 15);
            this.Lblusername.TabIndex = 0;
            this.Lblusername.Text = "guna2HtmlLabel1";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Gilroy", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(130, 564);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(229, 35);
            this.lbluser.TabIndex = 7;
            this.lbluser.Text = "Nom d\'utilisateur";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbluser.Click += new System.EventHandler(this.lbluser_Click);
            // 
            // Exitbox
            // 
            this.Exitbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbox.BackColor = System.Drawing.Color.Transparent;
            this.Exitbox.FillColor = System.Drawing.Color.Transparent;
            this.Exitbox.IconColor = System.Drawing.Color.White;
            this.Exitbox.Location = new System.Drawing.Point(1188, 3);
            this.Exitbox.Name = "Exitbox";
            this.Exitbox.Size = new System.Drawing.Size(34, 21);
            this.Exitbox.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1146, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(36, 29);
            this.guna2ControlBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 564);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // comboVersions
            // 
            this.comboVersions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.comboVersions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.comboVersions.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.comboVersions.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.comboVersions.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.comboVersions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVersions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.comboVersions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboVersions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboVersions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboVersions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.comboVersions.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.comboVersions.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.comboVersions.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.comboVersions.ItemHeight = 30;
            this.comboVersions.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.comboVersions.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.comboVersions.Location = new System.Drawing.Point(1015, 586);
            this.comboVersions.Name = "comboVersions";
            this.comboVersions.Size = new System.Drawing.Size(198, 36);
            this.comboVersions.TabIndex = 11;
            this.comboVersions.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BorderRadius = 10;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.progressBar.Font = new System.Drawing.Font("Burbank Big Cd Bk", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(-11, 546);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.progressBar.ShowText = true;
            this.progressBar.Size = new System.Drawing.Size(1242, 12);
            this.progressBar.TabIndex = 12;
            this.progressBar.Text = "Chargement...";
            this.progressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressBar.Visible = false;
            // 
            // vers
            // 
            this.vers.AutoSize = true;
            this.vers.BackColor = System.Drawing.Color.Transparent;
            this.vers.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.vers.Location = new System.Drawing.Point(1011, 564);
            this.vers.Name = "vers";
            this.vers.Size = new System.Drawing.Size(64, 20);
            this.vers.TabIndex = 13;
            this.vers.Text = "Version";
            this.vers.Click += new System.EventHandler(this.vers_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(172)))), ((int)(((byte)(27)))));
            this.guna2Button1.Font = new System.Drawing.Font("Burbank Big Cd Bk", 21.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Location = new System.Drawing.Point(553, 577);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Lancer le jeu";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ecranprincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 700);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.vers);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.comboVersions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Exitbox);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.Lblusername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ecranprincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ecranprincipale";
            this.Load += new System.EventHandler(this.ecranprincipale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Lblusername;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lbluser;
        private Guna.UI2.WinForms.Guna2ControlBox Exitbox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comboVersions;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.Label vers;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
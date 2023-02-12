namespace SoulBackUp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox githublogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.backup_button = new System.Windows.Forms.Button();
            this.darksouls2checkbox = new System.Windows.Forms.CheckBox();
            this.darksouls3checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.darksoulscheckbox = new System.Windows.Forms.CheckBox();
            this.eldenringcheckbox = new System.Windows.Forms.CheckBox();
            this.sekirocheckbox = new System.Windows.Forms.CheckBox();
            this.pathtxt = new System.Windows.Forms.Label();
            this.changepathbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.devname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            githublogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(githublogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // githublogo
            // 
            githublogo.Cursor = System.Windows.Forms.Cursors.Hand;
            githublogo.Image = ((System.Drawing.Image)(resources.GetObject("githublogo.Image")));
            githublogo.Location = new System.Drawing.Point(7, 281);
            githublogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            githublogo.Name = "githublogo";
            githublogo.Size = new System.Drawing.Size(30, 27);
            githublogo.TabIndex = 9;
            githublogo.TabStop = false;
            githublogo.Tag = "";
            githublogo.Click += new System.EventHandler(this.githublogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige los juegos a respaldar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backup_button
            // 
            this.backup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup_button.Location = new System.Drawing.Point(223, 182);
            this.backup_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backup_button.Name = "backup_button";
            this.backup_button.Size = new System.Drawing.Size(75, 24);
            this.backup_button.TabIndex = 1;
            this.backup_button.Text = "Respaldar";
            this.backup_button.UseVisualStyleBackColor = true;
            this.backup_button.Click += new System.EventHandler(this.backup_button_Click);
            // 
            // darksouls2checkbox
            // 
            this.darksouls2checkbox.AutoSize = true;
            this.darksouls2checkbox.Location = new System.Drawing.Point(4, 59);
            this.darksouls2checkbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.darksouls2checkbox.Name = "darksouls2checkbox";
            this.darksouls2checkbox.Size = new System.Drawing.Size(94, 18);
            this.darksouls2checkbox.TabIndex = 2;
            this.darksouls2checkbox.Text = "Dark Souls II";
            this.darksouls2checkbox.UseVisualStyleBackColor = true;
            this.darksouls2checkbox.CheckedChanged += new System.EventHandler(this.darksouls2checkbox_CheckedChanged);
            // 
            // darksouls3checkbox
            // 
            this.darksouls3checkbox.AutoSize = true;
            this.darksouls3checkbox.Location = new System.Drawing.Point(4, 84);
            this.darksouls3checkbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.darksouls3checkbox.Name = "darksouls3checkbox";
            this.darksouls3checkbox.Size = new System.Drawing.Size(97, 18);
            this.darksouls3checkbox.TabIndex = 3;
            this.darksouls3checkbox.Text = "Dark Souls III";
            this.darksouls3checkbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.darksoulscheckbox);
            this.groupBox1.Controls.Add(this.eldenringcheckbox);
            this.groupBox1.Controls.Add(this.sekirocheckbox);
            this.groupBox1.Controls.Add(this.darksouls2checkbox);
            this.groupBox1.Controls.Add(this.darksouls3checkbox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(4, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(208, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // darksoulscheckbox
            // 
            this.darksoulscheckbox.AutoSize = true;
            this.darksoulscheckbox.Location = new System.Drawing.Point(4, 34);
            this.darksoulscheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.darksoulscheckbox.Name = "darksoulscheckbox";
            this.darksoulscheckbox.Size = new System.Drawing.Size(200, 18);
            this.darksoulscheckbox.TabIndex = 6;
            this.darksoulscheckbox.Text = "Dark Souls (PTDE / Remastered)";
            this.darksoulscheckbox.UseVisualStyleBackColor = true;
            this.darksoulscheckbox.CheckedChanged += new System.EventHandler(this.darksoulscheckbox_CheckedChanged);
            // 
            // eldenringcheckbox
            // 
            this.eldenringcheckbox.AutoSize = true;
            this.eldenringcheckbox.Location = new System.Drawing.Point(4, 134);
            this.eldenringcheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.eldenringcheckbox.Name = "eldenringcheckbox";
            this.eldenringcheckbox.Size = new System.Drawing.Size(83, 18);
            this.eldenringcheckbox.TabIndex = 5;
            this.eldenringcheckbox.Text = "Elden Ring";
            this.eldenringcheckbox.UseVisualStyleBackColor = true;
            // 
            // sekirocheckbox
            // 
            this.sekirocheckbox.AutoSize = true;
            this.sekirocheckbox.Location = new System.Drawing.Point(4, 109);
            this.sekirocheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sekirocheckbox.Name = "sekirocheckbox";
            this.sekirocheckbox.Size = new System.Drawing.Size(62, 18);
            this.sekirocheckbox.TabIndex = 4;
            this.sekirocheckbox.Text = "Sekiro";
            this.sekirocheckbox.UseVisualStyleBackColor = true;
            // 
            // pathtxt
            // 
            this.pathtxt.AutoSize = true;
            this.pathtxt.Location = new System.Drawing.Point(6, 9);
            this.pathtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.Size = new System.Drawing.Size(94, 13);
            this.pathtxt.TabIndex = 6;
            this.pathtxt.Text = "La ruta actual es ";
            this.pathtxt.Click += new System.EventHandler(this.pathtxt_Click);
            // 
            // changepathbutton
            // 
            this.changepathbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changepathbutton.Location = new System.Drawing.Point(239, 264);
            this.changepathbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changepathbutton.Name = "changepathbutton";
            this.changepathbutton.Size = new System.Drawing.Size(64, 24);
            this.changepathbutton.TabIndex = 7;
            this.changepathbutton.Text = "Cambiar ruta";
            this.changepathbutton.UseVisualStyleBackColor = true;
            this.changepathbutton.Click += new System.EventHandler(this.changepathbutton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pathtxt);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(5, 215);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 42);
            this.panel1.TabIndex = 8;
            // 
            // devname
            // 
            this.devname.AutoSize = true;
            this.devname.BackColor = System.Drawing.Color.Transparent;
            this.devname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.devname.Location = new System.Drawing.Point(33, 287);
            this.devname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.devname.Name = "devname";
            this.devname.Size = new System.Drawing.Size(101, 13);
            this.devname.TabIndex = 10;
            this.devname.Text = "@AlejandroMinor";
            this.devname.Click += new System.EventHandler(this.devname_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 88);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 311);
            this.Controls.Add(this.changepathbutton);
            this.Controls.Add(this.devname);
            this.Controls.Add(githublogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backup_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(331, 350);
            this.MinimumSize = new System.Drawing.Size(331, 350);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoulsBackUP";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(githublogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button backup_button;
        private CheckBox darksouls2checkbox;
        private CheckBox darksouls3checkbox;
        private GroupBox groupBox1;
        private CheckBox sekirocheckbox;
        private CheckBox eldenringcheckbox;
        private Label pathtxt;
        private Button changepathbutton;
        private Panel panel1;
        private PictureBox githublogo;
        private Label devname;
        private PictureBox pictureBox1;
        private CheckBox darksoulscheckbox;
    }
}
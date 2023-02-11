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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.backup_button = new System.Windows.Forms.Button();
            this.darksouls2checkbox = new System.Windows.Forms.CheckBox();
            this.darksouls3checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eldenringcheckbox = new System.Windows.Forms.CheckBox();
            this.sekirocheckbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pathtxt = new System.Windows.Forms.Label();
            this.changepathbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige los juegos a respaldar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backup_button
            // 
            this.backup_button.Location = new System.Drawing.Point(220, 131);
            this.backup_button.Name = "backup_button";
            this.backup_button.Size = new System.Drawing.Size(75, 23);
            this.backup_button.TabIndex = 1;
            this.backup_button.Text = "Respaldar";
            this.backup_button.UseVisualStyleBackColor = true;
            this.backup_button.Click += new System.EventHandler(this.backup_button_Click);
            // 
            // darksouls2checkbox
            // 
            this.darksouls2checkbox.AutoSize = true;
            this.darksouls2checkbox.Location = new System.Drawing.Point(6, 13);
            this.darksouls2checkbox.Name = "darksouls2checkbox";
            this.darksouls2checkbox.Size = new System.Drawing.Size(90, 19);
            this.darksouls2checkbox.TabIndex = 2;
            this.darksouls2checkbox.Text = "Dark Souls II";
            this.darksouls2checkbox.UseVisualStyleBackColor = true;
            this.darksouls2checkbox.CheckedChanged += new System.EventHandler(this.darksouls2checkbox_CheckedChanged);
            // 
            // darksouls3checkbox
            // 
            this.darksouls3checkbox.AutoSize = true;
            this.darksouls3checkbox.Location = new System.Drawing.Point(6, 38);
            this.darksouls3checkbox.Name = "darksouls3checkbox";
            this.darksouls3checkbox.Size = new System.Drawing.Size(93, 19);
            this.darksouls3checkbox.TabIndex = 3;
            this.darksouls3checkbox.Text = "Dark Souls III";
            this.darksouls3checkbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eldenringcheckbox);
            this.groupBox1.Controls.Add(this.sekirocheckbox);
            this.groupBox1.Controls.Add(this.darksouls2checkbox);
            this.groupBox1.Controls.Add(this.darksouls3checkbox);
            this.groupBox1.Location = new System.Drawing.Point(14, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // eldenringcheckbox
            // 
            this.eldenringcheckbox.AutoSize = true;
            this.eldenringcheckbox.Location = new System.Drawing.Point(6, 88);
            this.eldenringcheckbox.Name = "eldenringcheckbox";
            this.eldenringcheckbox.Size = new System.Drawing.Size(82, 19);
            this.eldenringcheckbox.TabIndex = 5;
            this.eldenringcheckbox.Text = "Elden Ring";
            this.eldenringcheckbox.UseVisualStyleBackColor = true;
            // 
            // sekirocheckbox
            // 
            this.sekirocheckbox.AutoSize = true;
            this.sekirocheckbox.Location = new System.Drawing.Point(6, 63);
            this.sekirocheckbox.Name = "sekirocheckbox";
            this.sekirocheckbox.Size = new System.Drawing.Size(58, 19);
            this.sekirocheckbox.TabIndex = 4;
            this.sekirocheckbox.Text = "Sekiro";
            this.sekirocheckbox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 113);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pathtxt
            // 
            this.pathtxt.AutoSize = true;
            this.pathtxt.Location = new System.Drawing.Point(6, 9);
            this.pathtxt.Name = "pathtxt";
            this.pathtxt.Size = new System.Drawing.Size(94, 13);
            this.pathtxt.TabIndex = 6;
            this.pathtxt.Text = "La ruta actual es ";
            this.pathtxt.Click += new System.EventHandler(this.pathtxt_Click);
            // 
            // changepathbutton
            // 
            this.changepathbutton.Location = new System.Drawing.Point(220, 263);
            this.changepathbutton.Name = "changepathbutton";
            this.changepathbutton.Size = new System.Drawing.Size(75, 23);
            this.changepathbutton.TabIndex = 7;
            this.changepathbutton.Text = "Cambiar ruta";
            this.changepathbutton.UseVisualStyleBackColor = true;
            this.changepathbutton.Click += new System.EventHandler(this.changepathbutton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pathtxt);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(14, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 42);
            this.panel1.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.changepathbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backup_button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(331, 350);
            this.MinimumSize = new System.Drawing.Size(331, 350);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoulsBackUP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private PictureBox pictureBox1;
        private Label pathtxt;
        private Button changepathbutton;
        private Panel panel1;
    }
}
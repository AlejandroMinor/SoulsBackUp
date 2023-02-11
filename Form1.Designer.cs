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
            this.label1 = new System.Windows.Forms.Label();
            this.backup_button = new System.Windows.Forms.Button();
            this.darksouls2checkbox = new System.Windows.Forms.CheckBox();
            this.darksouls3checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eldenringcheckbox = new System.Windows.Forms.CheckBox();
            this.sekirocheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
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
            this.backup_button.Location = new System.Drawing.Point(219, 170);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 205);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backup_button);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "SoulsBackUP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}
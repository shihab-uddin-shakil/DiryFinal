namespace WindowsFormsApp5
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.submit = new System.Windows.Forms.Button();
            this.bloodgrp = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.dob = new System.Windows.Forms.Label();
            this.emailT = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.cPasswordT = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.passwordT = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.unameT = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.bloodT = new System.Windows.Forms.ComboBox();
            this.condition = new System.Windows.Forms.CheckBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.dobT = new System.Windows.Forms.DateTimePicker();
            this.nameT = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.bloodgrp);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.female);
            this.panel1.Controls.Add(this.dob);
            this.panel1.Controls.Add(this.emailT);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.cPasswordT);
            this.panel1.Controls.Add(this.confirmPassword);
            this.panel1.Controls.Add(this.passwordT);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.unameT);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.bloodT);
            this.panel1.Controls.Add(this.condition);
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.dobT);
            this.panel1.Controls.Add(this.nameT);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(31, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 579);
            this.panel1.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(65, 516);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(278, 47);
            this.submit.TabIndex = 18;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // bloodgrp
            // 
            this.bloodgrp.AutoSize = true;
            this.bloodgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodgrp.Location = new System.Drawing.Point(43, 403);
            this.bloodgrp.Name = "bloodgrp";
            this.bloodgrp.Size = new System.Drawing.Size(114, 20);
            this.bloodgrp.TabIndex = 17;
            this.bloodgrp.Text = "Blood Group";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(87, 345);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(70, 20);
            this.gender.TabIndex = 16;
            this.gender.Text = "Gender";
            this.gender.UseMnemonic = false;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(279, 346);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 15;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(61, 289);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(96, 20);
            this.dob.TabIndex = 14;
            this.dob.Text = "Birth Date";
            // 
            // emailT
            // 
            this.emailT.Location = new System.Drawing.Point(199, 230);
            this.emailT.Name = "emailT";
            this.emailT.Size = new System.Drawing.Size(132, 22);
            this.emailT.TabIndex = 13;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(101, 232);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(56, 20);
            this.email.TabIndex = 12;
            this.email.Text = "Email";
            // 
            // cPasswordT
            // 
            this.cPasswordT.Location = new System.Drawing.Point(199, 192);
            this.cPasswordT.Name = "cPasswordT";
            this.cPasswordT.Size = new System.Drawing.Size(132, 22);
            this.cPasswordT.TabIndex = 11;
            this.cPasswordT.UseSystemPasswordChar = true;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.Location = new System.Drawing.Point(-5, 192);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(163, 20);
            this.confirmPassword.TabIndex = 10;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // passwordT
            // 
            this.passwordT.Location = new System.Drawing.Point(199, 161);
            this.passwordT.Name = "passwordT";
            this.passwordT.Size = new System.Drawing.Size(132, 22);
            this.passwordT.TabIndex = 9;
            this.passwordT.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(66, 151);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(91, 20);
            this.password.TabIndex = 8;
            this.password.Text = "Password";
            this.password.UseMnemonic = false;
            // 
            // unameT
            // 
            this.unameT.Location = new System.Drawing.Point(199, 109);
            this.unameT.Name = "unameT";
            this.unameT.Size = new System.Drawing.Size(132, 22);
            this.unameT.TabIndex = 7;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(49, 109);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(109, 20);
            this.userName.TabIndex = 6;
            this.userName.Text = " User Name";
            // 
            // bloodT
            // 
            this.bloodT.FormattingEnabled = true;
            this.bloodT.Items.AddRange(new object[] {
            "A+",
            "AB+",
            "B+",
            "o+",
            "A-"});
            this.bloodT.Location = new System.Drawing.Point(199, 403);
            this.bloodT.Name = "bloodT";
            this.bloodT.Size = new System.Drawing.Size(121, 24);
            this.bloodT.TabIndex = 5;
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.Location = new System.Drawing.Point(103, 474);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(228, 21);
            this.condition.TabIndex = 4;
            this.condition.Text = "I aggre this terms and condition";
            this.condition.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(169, 346);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 3;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // dobT
            // 
            this.dobT.Location = new System.Drawing.Point(199, 287);
            this.dobT.Name = "dobT";
            this.dobT.Size = new System.Drawing.Size(200, 22);
            this.dobT.TabIndex = 2;
            this.dobT.ValueChanged += new System.EventHandler(this.dobT_ValueChanged);
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(199, 48);
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(132, 22);
            this.nameT.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(101, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label bloodgrp;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.TextBox emailT;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox cPasswordT;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox passwordT;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox unameT;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.ComboBox bloodT;
        private System.Windows.Forms.CheckBox condition;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.DateTimePicker dobT;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
    }
}


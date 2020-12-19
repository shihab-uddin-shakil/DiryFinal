namespace DiryFinal
{
    partial class Login
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
            this.User = new System.Windows.Forms.Label();
            this.UsertextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.LoginDiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(132, 194);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(129, 29);
            this.User.TabIndex = 0;
            this.User.Text = "UserName";
            // 
            // UsertextBox
            // 
            this.UsertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertextBox.Location = new System.Drawing.Point(302, 194);
            this.UsertextBox.Name = "UsertextBox";
            this.UsertextBox.Size = new System.Drawing.Size(145, 34);
            this.UsertextBox.TabIndex = 1;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.Location = new System.Drawing.Point(302, 286);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(149, 34);
            this.PasswordtextBox.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(132, 291);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(120, 29);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // LoginDiry
            // 
            this.LoginDiry.BackColor = System.Drawing.SystemColors.Highlight;
            this.LoginDiry.Location = new System.Drawing.Point(262, 413);
            this.LoginDiry.Name = "LoginDiry";
            this.LoginDiry.Size = new System.Drawing.Size(149, 46);
            this.LoginDiry.TabIndex = 4;
            this.LoginDiry.Text = "Login";
            this.LoginDiry.UseVisualStyleBackColor = false;
            this.LoginDiry.Click += new System.EventHandler(this.LoginDiry_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 577);
            this.Controls.Add(this.LoginDiry);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UsertextBox);
            this.Controls.Add(this.User);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox UsertextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button LoginDiry;
    }
}


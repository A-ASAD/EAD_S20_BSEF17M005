namespace UMS
{
    partial class UMS_LoggedIn
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.editProf = new System.Windows.Forms.Button();
            this.UserWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 224);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.SystemColors.Control;
            this.logout.Location = new System.Drawing.Point(289, 371);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 35);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // editProf
            // 
            this.editProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.editProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProf.ForeColor = System.Drawing.SystemColors.Control;
            this.editProf.Location = new System.Drawing.Point(122, 371);
            this.editProf.Margin = new System.Windows.Forms.Padding(4);
            this.editProf.Name = "editProf";
            this.editProf.Size = new System.Drawing.Size(125, 35);
            this.editProf.TabIndex = 3;
            this.editProf.Text = "Edit Profile";
            this.editProf.UseVisualStyleBackColor = false;
            // 
            // UserWelcome
            // 
            this.UserWelcome.AutoSize = true;
            this.UserWelcome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.UserWelcome.Location = new System.Drawing.Point(219, 37);
            this.UserWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserWelcome.Name = "UserWelcome";
            this.UserWelcome.Size = new System.Drawing.Size(102, 27);
            this.UserWelcome.TabIndex = 4;
            this.UserWelcome.Text = "Welcome ";
            this.UserWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UMS_LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 464);
            this.Controls.Add(this.UserWelcome);
            this.Controls.Add(this.editProf);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UMS_LoggedIn";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UMS_LoggedIn_FormClosed);
            this.Load += new System.EventHandler(this.UMS_LoggedIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button editProf;
        private System.Windows.Forms.Label UserWelcome;
    }
}
namespace UMS
{
    partial class UMS_AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UMS_AdminLogin));
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.lgn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(106, 225);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(170, 26);
            this.login.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(106, 257);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(170, 26);
            this.pass.TabIndex = 1;
            // 
            // lgn
            // 
            this.lgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.lgn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgn.ForeColor = System.Drawing.SystemColors.Control;
            this.lgn.Location = new System.Drawing.Point(63, 323);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(85, 30);
            this.lgn.TabIndex = 2;
            this.lgn.Text = "Login";
            this.lgn.UseVisualStyleBackColor = false;
            this.lgn.Click += new System.EventHandler(this.lgn_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.cancel.Location = new System.Drawing.Point(174, 323);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(85, 30);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(59, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(35, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // errMsg
            // 
            this.errMsg.AutoSize = true;
            this.errMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.errMsg.Location = new System.Drawing.Point(102, 290);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(171, 19);
            this.errMsg.TabIndex = 7;
            this.errMsg.Text = "Invalid Login or Password";
            this.errMsg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UMS_AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 365);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.lgn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UMS_AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UMS_AdminLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button lgn;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errMsg;
    }
}
namespace UMS
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
            this.title = new System.Windows.Forms.Label();
            this.NU = new System.Windows.Forms.Button();
            this.EU = new System.Windows.Forms.Button();
            this.Adm = new System.Windows.Forms.Button();
            this.Ex = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.title.Location = new System.Drawing.Point(108, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(481, 39);
            this.title.TabIndex = 0;
            this.title.Text = "User Management System";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NU
            // 
            this.NU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.NU.Cursor = System.Windows.Forms.Cursors.Default;
            this.NU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NU.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NU.ForeColor = System.Drawing.SystemColors.Control;
            this.NU.Location = new System.Drawing.Point(35, 330);
            this.NU.Name = "NU";
            this.NU.Size = new System.Drawing.Size(120, 45);
            this.NU.TabIndex = 1;
            this.NU.Text = "New User";
            this.NU.UseVisualStyleBackColor = false;
            this.NU.Click += new System.EventHandler(this.NU_Click);
            // 
            // EU
            // 
            this.EU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.EU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EU.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.EU.ForeColor = System.Drawing.SystemColors.Control;
            this.EU.Location = new System.Drawing.Point(202, 330);
            this.EU.Name = "EU";
            this.EU.Size = new System.Drawing.Size(120, 45);
            this.EU.TabIndex = 2;
            this.EU.Text = "Existing User";
            this.EU.UseVisualStyleBackColor = false;
            this.EU.Click += new System.EventHandler(this.EU_Click);
            // 
            // Adm
            // 
            this.Adm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.Adm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adm.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.Adm.ForeColor = System.Drawing.SystemColors.Control;
            this.Adm.Location = new System.Drawing.Point(370, 330);
            this.Adm.Name = "Adm";
            this.Adm.Size = new System.Drawing.Size(120, 45);
            this.Adm.TabIndex = 3;
            this.Adm.Text = "Admin";
            this.Adm.UseVisualStyleBackColor = false;
            this.Adm.Click += new System.EventHandler(this.Adm_Click);
            // 
            // Ex
            // 
            this.Ex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.Ex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ex.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.Ex.ForeColor = System.Drawing.SystemColors.Control;
            this.Ex.Location = new System.Drawing.Point(541, 330);
            this.Ex.Name = "Ex";
            this.Ex.Size = new System.Drawing.Size(120, 45);
            this.Ex.TabIndex = 4;
            this.Ex.Text = "Exit";
            this.Ex.UseVisualStyleBackColor = false;
            this.Ex.Click += new System.EventHandler(this.Ex_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UMS.Properties.Resources.ums;
            this.pictureBox1.Location = new System.Drawing.Point(202, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 440);
            this.Controls.Add(this.Adm);
            this.Controls.Add(this.Ex);
            this.Controls.Add(this.EU);
            this.Controls.Add(this.NU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NU;
        private System.Windows.Forms.Button EU;
        private System.Windows.Forms.Button Adm;
        private System.Windows.Forms.Button Ex;
    }
}


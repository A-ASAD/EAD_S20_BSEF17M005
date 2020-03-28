namespace UMS
{
    partial class UMS_NewPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.updatePass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(59, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Password";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(73, 251);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(170, 26);
            this.pass.TabIndex = 1;
            // 
            // updatePass
            // 
            this.updatePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(35)))), ((int)(((byte)(15)))));
            this.updatePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePass.ForeColor = System.Drawing.SystemColors.Control;
            this.updatePass.Location = new System.Drawing.Point(108, 285);
            this.updatePass.Margin = new System.Windows.Forms.Padding(4);
            this.updatePass.Name = "updatePass";
            this.updatePass.Size = new System.Drawing.Size(100, 34);
            this.updatePass.TabIndex = 2;
            this.updatePass.Text = "Update";
            this.updatePass.UseVisualStyleBackColor = false;
            this.updatePass.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UMS.Properties.Resources.nPass;
            this.pictureBox1.Location = new System.Drawing.Point(32, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UMS_NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updatePass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UMS_NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS_NewPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UMS_NewPassword_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button updatePass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
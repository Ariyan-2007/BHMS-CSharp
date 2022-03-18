namespace Bachelor_s_Housing_Management_Application.Presentation_Layer
{
    partial class ChangePassword
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
            this.cPass = new System.Windows.Forms.TextBox();
            this.nPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.coPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // cPass
            // 
            this.cPass.Location = new System.Drawing.Point(29, 40);
            this.cPass.Name = "cPass";
            this.cPass.PasswordChar = '*';
            this.cPass.Size = new System.Drawing.Size(190, 20);
            this.cPass.TabIndex = 1;
            // 
            // nPass
            // 
            this.nPass.Location = new System.Drawing.Point(29, 81);
            this.nPass.Name = "nPass";
            this.nPass.PasswordChar = '*';
            this.nPass.Size = new System.Drawing.Size(190, 20);
            this.nPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(171, 149);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(67, 20);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(244, 149);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(78, 20);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // coPass
            // 
            this.coPass.Location = new System.Drawing.Point(29, 123);
            this.coPass.Name = "coPass";
            this.coPass.PasswordChar = '*';
            this.coPass.Size = new System.Drawing.Size(190, 20);
            this.coPass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bachelor_s_Housing_Management_Application.Properties.Resources.BG_11;
            this.ClientSize = new System.Drawing.Size(334, 179);
            this.Controls.Add(this.coPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.nPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cPass);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cPass;
        private System.Windows.Forms.TextBox nPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox coPass;
        private System.Windows.Forms.Label label3;
    }
}
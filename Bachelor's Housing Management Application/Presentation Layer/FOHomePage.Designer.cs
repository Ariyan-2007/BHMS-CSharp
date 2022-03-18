namespace Bachelor_s_Housing_Management_Application.Presentation_Layer
{
    partial class FOHomePage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logout = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.myAD = new System.Windows.Forms.Button();
            this.postAD = new System.Windows.Forms.Button();
            this.balancetxt = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.logout);
            this.groupBox1.Controls.Add(this.settings);
            this.groupBox1.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(364, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Location = new System.Drawing.Point(43, 57);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 1;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.Color.Black;
            this.settings.Location = new System.Drawing.Point(43, 28);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 0;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.myAD);
            this.groupBox2.Controls.Add(this.postAD);
            this.groupBox2.Location = new System.Drawing.Point(158, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 128);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // myAD
            // 
            this.myAD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAD.Location = new System.Drawing.Point(47, 75);
            this.myAD.Name = "myAD";
            this.myAD.Size = new System.Drawing.Size(112, 23);
            this.myAD.TabIndex = 1;
            this.myAD.Text = "My Advertisements";
            this.myAD.UseVisualStyleBackColor = true;
            this.myAD.Click += new System.EventHandler(this.myAD_Click);
            // 
            // postAD
            // 
            this.postAD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postAD.Location = new System.Drawing.Point(47, 35);
            this.postAD.Name = "postAD";
            this.postAD.Size = new System.Drawing.Size(112, 23);
            this.postAD.TabIndex = 0;
            this.postAD.Text = "Post Advertisement";
            this.postAD.UseVisualStyleBackColor = true;
            this.postAD.Click += new System.EventHandler(this.postAD_Click);
            // 
            // balancetxt
            // 
            this.balancetxt.AutoSize = true;
            this.balancetxt.BackColor = System.Drawing.Color.Transparent;
            this.balancetxt.Font = new System.Drawing.Font("Calisto MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancetxt.ForeColor = System.Drawing.Color.White;
            this.balancetxt.Location = new System.Drawing.Point(38, 86);
            this.balancetxt.Name = "balancetxt";
            this.balancetxt.Size = new System.Drawing.Size(48, 15);
            this.balancetxt.TabIndex = 9;
            this.balancetxt.Text = "Balance";
            // 
            // nametxt
            // 
            this.nametxt.AutoSize = true;
            this.nametxt.BackColor = System.Drawing.Color.Transparent;
            this.nametxt.Font = new System.Drawing.Font("Calisto MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.ForeColor = System.Drawing.Color.White;
            this.nametxt.Location = new System.Drawing.Point(37, 63);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(54, 23);
            this.nametxt.TabIndex = 8;
            this.nametxt.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // FOHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bachelor_s_Housing_Management_Application.Properties.Resources.BG_15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.balancetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label1);
            this.Name = "FOHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FOHomePage_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button myAD;
        private System.Windows.Forms.Button postAD;
        private System.Windows.Forms.Label balancetxt;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label label1;
    }
}
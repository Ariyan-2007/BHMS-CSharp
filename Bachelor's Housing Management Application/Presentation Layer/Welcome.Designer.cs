namespace Bachelor_s_Housing_Management_Application.Presentation_Layer
{
    partial class Welcome
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
            this.bachelor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flatOwner = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To \r\nBachelor\'s Housing Management \r\nApplication";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bachelor
            // 
            this.bachelor.Location = new System.Drawing.Point(26, 27);
            this.bachelor.Name = "bachelor";
            this.bachelor.Size = new System.Drawing.Size(143, 30);
            this.bachelor.TabIndex = 1;
            this.bachelor.Text = "Bachelor";
            this.bachelor.UseVisualStyleBackColor = true;
            this.bachelor.Click += new System.EventHandler(this.bachelor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.flatOwner);
            this.groupBox1.Controls.Add(this.bachelor);
            this.groupBox1.Location = new System.Drawing.Point(361, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select User";
            // 
            // flatOwner
            // 
            this.flatOwner.Location = new System.Drawing.Point(26, 72);
            this.flatOwner.Name = "flatOwner";
            this.flatOwner.Size = new System.Drawing.Size(143, 30);
            this.flatOwner.TabIndex = 2;
            this.flatOwner.Text = "Flat Owner";
            this.flatOwner.UseVisualStyleBackColor = true;
            this.flatOwner.Click += new System.EventHandler(this.flatOwner_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bachelor_s_Housing_Management_Application.Properties.Resources.BG_3;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Welcome_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bachelor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button flatOwner;
    }
}
namespace Bachelor_s_Housing_Management_Application.Presentation_Layer
{
    partial class CashIn
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
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.bKashRB = new System.Windows.Forms.RadioButton();
            this.rocketRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.select = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(20, 29);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(209, 20);
            this.amountBox.TabIndex = 0;
            this.amountBox.TextChanged += new System.EventHandler(this.amountBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(20, 72);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(209, 20);
            this.phoneNumberBox.TabIndex = 2;
            this.phoneNumberBox.TextChanged += new System.EventHandler(this.phoneNumberBox_TextChanged);
            // 
            // bKashRB
            // 
            this.bKashRB.AutoSize = true;
            this.bKashRB.BackColor = System.Drawing.Color.Transparent;
            this.bKashRB.Location = new System.Drawing.Point(110, 104);
            this.bKashRB.Name = "bKashRB";
            this.bKashRB.Size = new System.Drawing.Size(56, 17);
            this.bKashRB.TabIndex = 4;
            this.bKashRB.TabStop = true;
            this.bKashRB.Text = "BKash";
            this.bKashRB.UseVisualStyleBackColor = false;
            this.bKashRB.CheckedChanged += new System.EventHandler(this.bKashRB_CheckedChanged);
            // 
            // rocketRB
            // 
            this.rocketRB.AutoSize = true;
            this.rocketRB.BackColor = System.Drawing.Color.Transparent;
            this.rocketRB.Location = new System.Drawing.Point(172, 104);
            this.rocketRB.Name = "rocketRB";
            this.rocketRB.Size = new System.Drawing.Size(60, 17);
            this.rocketRB.TabIndex = 5;
            this.rocketRB.TabStop = true;
            this.rocketRB.Text = "Rocket";
            this.rocketRB.UseVisualStyleBackColor = false;
            this.rocketRB.CheckedChanged += new System.EventHandler(this.rocketRB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payment Method";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.select);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rocketRB);
            this.groupBox1.Controls.Add(this.bKashRB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phoneNumberBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.amountBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(172, 127);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(60, 21);
            this.select.TabIndex = 7;
            this.select.Text = "Confirm";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(202, 179);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(63, 20);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Verify";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(148, 179);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(48, 20);
            this.codeBox.TabIndex = 8;
            this.codeBox.TextChanged += new System.EventHandler(this.codeBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(110, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Code";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(271, 179);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(51, 20);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CashIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bachelor_s_Housing_Management_Application.Properties.Resources.BG_11;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.groupBox1);
            this.Name = "CashIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashIn_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.RadioButton bKashRB;
        private System.Windows.Forms.RadioButton rocketRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel;
    }
}

namespace Windows_OS
{
    partial class LoginSystem
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
            this.btn_anmelden = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_passwort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_anmelden
            // 
            this.btn_anmelden.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_anmelden.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_anmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anmelden.ForeColor = System.Drawing.Color.White;
            this.btn_anmelden.Location = new System.Drawing.Point(136, 100);
            this.btn_anmelden.Name = "btn_anmelden";
            this.btn_anmelden.Size = new System.Drawing.Size(176, 25);
            this.btn_anmelden.TabIndex = 0;
            this.btn_anmelden.Text = "Anmelden";
            this.btn_anmelden.UseVisualStyleBackColor = false;
            this.btn_anmelden.Click += new System.EventHandler(this.btn_anmelden_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.BackColor = System.Drawing.Color.SlateGray;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(3, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(142, 28);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(136, 22);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(176, 26);
            this.txt_username.TabIndex = 2;
            // 
            // txt_passwort
            // 
            this.txt_passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwort.Location = new System.Drawing.Point(136, 54);
            this.txt_passwort.Name = "txt_passwort";
            this.txt_passwort.Size = new System.Drawing.Size(176, 26);
            this.txt_passwort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passwort";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_anmelden);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_passwort);
            this.panel1.Location = new System.Drawing.Point(1055, 556);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 150);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Location = new System.Drawing.Point(12, 1392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 36);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Admin);
            this.panel3.Location = new System.Drawing.Point(168, 1392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 36);
            this.panel3.TabIndex = 8;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Admin.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(3, 3);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(142, 28);
            this.btn_Admin.TabIndex = 1;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // LoginSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2560, 1440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSystem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_anmelden;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_passwort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Admin;
    }
}
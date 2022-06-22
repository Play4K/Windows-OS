
namespace Windows_OS.WindowsSystem.Forms
{
    partial class SettingsMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.Tsp_MenuBar = new System.Windows.Forms.ToolStrip();
            this.Tsp_Close = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Minimize = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Label = new System.Windows.Forms.ToolStripLabel();
            this.xuiFlatProgressBar1 = new XanderUI.XUIFlatProgressBar();
            this.Lbl_Update = new System.Windows.Forms.Label();
            this.Lbl_ProfilName = new System.Windows.Forms.Label();
            this.Lbl_Programs = new System.Windows.Forms.Label();
            this.Lbl_SystemSecurity = new System.Windows.Forms.Label();
            this.Lbl_TimeRegion = new System.Windows.Forms.Label();
            this.Lbl_ApperanceSettings = new System.Windows.Forms.Label();
            this.Lbl_ProfilSettings = new System.Windows.Forms.Label();
            this.Pnl_Update = new System.Windows.Forms.Panel();
            this.Pnl_Programs = new System.Windows.Forms.Panel();
            this.Pnl_SecuritySettings = new System.Windows.Forms.Panel();
            this.Pbl_TimeRegion = new System.Windows.Forms.Panel();
            this.Pnl_ApperanceSettings = new System.Windows.Forms.Panel();
            this.Pnl_ProfilSettings = new System.Windows.Forms.Panel();
            this.Tsp_MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tsp_MenuBar
            // 
            this.Tsp_MenuBar.AutoSize = false;
            this.Tsp_MenuBar.BackColor = System.Drawing.Color.LightGray;
            this.Tsp_MenuBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tsp_MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tsp_MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsp_Close,
            this.Tsp_Minimize,
            this.Tsp_Label});
            this.Tsp_MenuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Tsp_MenuBar.Location = new System.Drawing.Point(0, 0);
            this.Tsp_MenuBar.Name = "Tsp_MenuBar";
            this.Tsp_MenuBar.Size = new System.Drawing.Size(900, 30);
            this.Tsp_MenuBar.TabIndex = 4;
            this.Tsp_MenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tsp_MenuBar_MouseDown);
            this.Tsp_MenuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tsp_MenuBar_MouseMove);
            // 
            // Tsp_Close
            // 
            this.Tsp_Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tsp_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsp_Close.Image = ((System.Drawing.Image)(resources.GetObject("Tsp_Close.Image")));
            this.Tsp_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsp_Close.Name = "Tsp_Close";
            this.Tsp_Close.Size = new System.Drawing.Size(23, 27);
            this.Tsp_Close.Text = "toolStripButton1";
            // 
            // Tsp_Minimize
            // 
            this.Tsp_Minimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tsp_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Tsp_Minimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsp_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Tsp_Minimize.Image")));
            this.Tsp_Minimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsp_Minimize.Name = "Tsp_Minimize";
            this.Tsp_Minimize.Size = new System.Drawing.Size(23, 27);
            this.Tsp_Minimize.Text = "toolStripButton1";
            // 
            // Tsp_Label
            // 
            this.Tsp_Label.Image = ((System.Drawing.Image)(resources.GetObject("Tsp_Label.Image")));
            this.Tsp_Label.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.Tsp_Label.Name = "Tsp_Label";
            this.Tsp_Label.Size = new System.Drawing.Size(94, 26);
            this.Tsp_Label.Text = "Einstellungen";
            // 
            // xuiFlatProgressBar1
            // 
            this.xuiFlatProgressBar1.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xuiFlatProgressBar1.BarThickness = 5;
            this.xuiFlatProgressBar1.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiFlatProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiFlatProgressBar1.InocmpletedColor = System.Drawing.Color.White;
            this.xuiFlatProgressBar1.Location = new System.Drawing.Point(0, 595);
            this.xuiFlatProgressBar1.MaxValue = 100;
            this.xuiFlatProgressBar1.Name = "xuiFlatProgressBar1";
            this.xuiFlatProgressBar1.Size = new System.Drawing.Size(900, 5);
            this.xuiFlatProgressBar1.TabIndex = 32;
            this.xuiFlatProgressBar1.Text = "xuiFlatProgressBar1";
            this.xuiFlatProgressBar1.Value = 100;
            // 
            // Lbl_Update
            // 
            this.Lbl_Update.AutoSize = true;
            this.Lbl_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Update.Location = new System.Drawing.Point(702, 303);
            this.Lbl_Update.Name = "Lbl_Update";
            this.Lbl_Update.Size = new System.Drawing.Size(62, 20);
            this.Lbl_Update.TabIndex = 31;
            this.Lbl_Update.Text = "Update";
            // 
            // Lbl_ProfilName
            // 
            this.Lbl_ProfilName.AutoSize = true;
            this.Lbl_ProfilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProfilName.ForeColor = System.Drawing.Color.SteelBlue;
            this.Lbl_ProfilName.Location = new System.Drawing.Point(338, 74);
            this.Lbl_ProfilName.Name = "Lbl_ProfilName";
            this.Lbl_ProfilName.Size = new System.Drawing.Size(220, 37);
            this.Lbl_ProfilName.TabIndex = 29;
            this.Lbl_ProfilName.Text = "Arsen Musaev";
            // 
            // Lbl_Programs
            // 
            this.Lbl_Programs.AutoSize = true;
            this.Lbl_Programs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Programs.Location = new System.Drawing.Point(702, 192);
            this.Lbl_Programs.Name = "Lbl_Programs";
            this.Lbl_Programs.Size = new System.Drawing.Size(96, 20);
            this.Lbl_Programs.TabIndex = 28;
            this.Lbl_Programs.Text = "Programme";
            // 
            // Lbl_SystemSecurity
            // 
            this.Lbl_SystemSecurity.AutoSize = true;
            this.Lbl_SystemSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SystemSecurity.Location = new System.Drawing.Point(165, 192);
            this.Lbl_SystemSecurity.Name = "Lbl_SystemSecurity";
            this.Lbl_SystemSecurity.Size = new System.Drawing.Size(116, 40);
            this.Lbl_SystemSecurity.TabIndex = 26;
            this.Lbl_SystemSecurity.Text = "System\r\nund Sicherheit";
            // 
            // Lbl_TimeRegion
            // 
            this.Lbl_TimeRegion.AutoSize = true;
            this.Lbl_TimeRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TimeRegion.Location = new System.Drawing.Point(449, 303);
            this.Lbl_TimeRegion.Name = "Lbl_TimeRegion";
            this.Lbl_TimeRegion.Size = new System.Drawing.Size(93, 40);
            this.Lbl_TimeRegion.TabIndex = 24;
            this.Lbl_TimeRegion.Text = "Zeit\r\nund Region";
            // 
            // Lbl_ApperanceSettings
            // 
            this.Lbl_ApperanceSettings.AutoSize = true;
            this.Lbl_ApperanceSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ApperanceSettings.Location = new System.Drawing.Point(165, 303);
            this.Lbl_ApperanceSettings.Name = "Lbl_ApperanceSettings";
            this.Lbl_ApperanceSettings.Size = new System.Drawing.Size(124, 40);
            this.Lbl_ApperanceSettings.TabIndex = 22;
            this.Lbl_ApperanceSettings.Text = "Darstellung\r\nund Anpassung\r\n";
            this.Lbl_ApperanceSettings.Click += new System.EventHandler(this.Apperance_Click);
            // 
            // Lbl_ProfilSettings
            // 
            this.Lbl_ProfilSettings.AutoSize = true;
            this.Lbl_ProfilSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProfilSettings.Location = new System.Drawing.Point(449, 192);
            this.Lbl_ProfilSettings.Name = "Lbl_ProfilSettings";
            this.Lbl_ProfilSettings.Size = new System.Drawing.Size(109, 40);
            this.Lbl_ProfilSettings.TabIndex = 20;
            this.Lbl_ProfilSettings.Text = "Profil\r\nEinstellungen";
            this.Lbl_ProfilSettings.Click += new System.EventHandler(this.Profil_Click);
            // 
            // Pnl_Update
            // 
            this.Pnl_Update.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_Update.BackgroundImage")));
            this.Pnl_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_Update.Location = new System.Drawing.Point(616, 295);
            this.Pnl_Update.Name = "Pnl_Update";
            this.Pnl_Update.Size = new System.Drawing.Size(80, 75);
            this.Pnl_Update.TabIndex = 30;
            // 
            // Pnl_Programs
            // 
            this.Pnl_Programs.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Programs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_Programs.BackgroundImage")));
            this.Pnl_Programs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_Programs.Location = new System.Drawing.Point(616, 184);
            this.Pnl_Programs.Name = "Pnl_Programs";
            this.Pnl_Programs.Size = new System.Drawing.Size(80, 75);
            this.Pnl_Programs.TabIndex = 27;
            // 
            // Pnl_SecuritySettings
            // 
            this.Pnl_SecuritySettings.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_SecuritySettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_SecuritySettings.BackgroundImage")));
            this.Pnl_SecuritySettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_SecuritySettings.Location = new System.Drawing.Point(79, 184);
            this.Pnl_SecuritySettings.Name = "Pnl_SecuritySettings";
            this.Pnl_SecuritySettings.Size = new System.Drawing.Size(80, 75);
            this.Pnl_SecuritySettings.TabIndex = 25;
            // 
            // Pbl_TimeRegion
            // 
            this.Pbl_TimeRegion.BackColor = System.Drawing.Color.Transparent;
            this.Pbl_TimeRegion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pbl_TimeRegion.BackgroundImage")));
            this.Pbl_TimeRegion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pbl_TimeRegion.Location = new System.Drawing.Point(363, 295);
            this.Pbl_TimeRegion.Name = "Pbl_TimeRegion";
            this.Pbl_TimeRegion.Size = new System.Drawing.Size(80, 75);
            this.Pbl_TimeRegion.TabIndex = 23;
            // 
            // Pnl_ApperanceSettings
            // 
            this.Pnl_ApperanceSettings.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_ApperanceSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_ApperanceSettings.BackgroundImage")));
            this.Pnl_ApperanceSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_ApperanceSettings.Location = new System.Drawing.Point(79, 295);
            this.Pnl_ApperanceSettings.Name = "Pnl_ApperanceSettings";
            this.Pnl_ApperanceSettings.Size = new System.Drawing.Size(80, 75);
            this.Pnl_ApperanceSettings.TabIndex = 21;
            this.Pnl_ApperanceSettings.Click += new System.EventHandler(this.Apperance_Click);
            // 
            // Pnl_ProfilSettings
            // 
            this.Pnl_ProfilSettings.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_ProfilSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_ProfilSettings.BackgroundImage")));
            this.Pnl_ProfilSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_ProfilSettings.Location = new System.Drawing.Point(363, 184);
            this.Pnl_ProfilSettings.Name = "Pnl_ProfilSettings";
            this.Pnl_ProfilSettings.Size = new System.Drawing.Size(80, 75);
            this.Pnl_ProfilSettings.TabIndex = 19;
            this.Pnl_ProfilSettings.Click += new System.EventHandler(this.Profil_Click);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiFlatProgressBar1);
            this.Controls.Add(this.Lbl_Update);
            this.Controls.Add(this.Pnl_Update);
            this.Controls.Add(this.Lbl_ProfilName);
            this.Controls.Add(this.Lbl_Programs);
            this.Controls.Add(this.Pnl_Programs);
            this.Controls.Add(this.Lbl_SystemSecurity);
            this.Controls.Add(this.Pnl_SecuritySettings);
            this.Controls.Add(this.Lbl_TimeRegion);
            this.Controls.Add(this.Pbl_TimeRegion);
            this.Controls.Add(this.Lbl_ApperanceSettings);
            this.Controls.Add(this.Pnl_ApperanceSettings);
            this.Controls.Add(this.Lbl_ProfilSettings);
            this.Controls.Add(this.Pnl_ProfilSettings);
            this.Controls.Add(this.Tsp_MenuBar);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(900, 600);
            this.Tsp_MenuBar.ResumeLayout(false);
            this.Tsp_MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tsp_MenuBar;
        private System.Windows.Forms.ToolStripButton Tsp_Close;
        private System.Windows.Forms.ToolStripButton Tsp_Minimize;
        private System.Windows.Forms.ToolStripLabel Tsp_Label;
        private XanderUI.XUIFlatProgressBar xuiFlatProgressBar1;
        private System.Windows.Forms.Label Lbl_Update;
        private System.Windows.Forms.Panel Pnl_Update;
        private System.Windows.Forms.Label Lbl_ProfilName;
        private System.Windows.Forms.Label Lbl_Programs;
        private System.Windows.Forms.Panel Pnl_Programs;
        private System.Windows.Forms.Label Lbl_SystemSecurity;
        private System.Windows.Forms.Panel Pnl_SecuritySettings;
        private System.Windows.Forms.Label Lbl_TimeRegion;
        private System.Windows.Forms.Panel Pbl_TimeRegion;
        private System.Windows.Forms.Label Lbl_ApperanceSettings;
        private System.Windows.Forms.Panel Pnl_ApperanceSettings;
        private System.Windows.Forms.Label Lbl_ProfilSettings;
        private System.Windows.Forms.Panel Pnl_ProfilSettings;
    }
}

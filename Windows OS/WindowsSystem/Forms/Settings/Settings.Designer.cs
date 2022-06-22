
namespace Windows_OS.WindowsSystem.Forms
{
    partial class Settings
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
            this.Pnl_Container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Pnl_Container
            // 
            this.Pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Container.Name = "Pnl_Container";
            this.Pnl_Container.Size = new System.Drawing.Size(900, 600);
            this.Pnl_Container.TabIndex = 19;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.Pnl_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Container;
    }
}

namespace Windows_OS.WindowsSystem.MainForm
{
    partial class windowsBoot
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
            this.components = new System.ComponentModel.Container();
            this.xui_pbar_loading = new XanderUI.XUIFlatProgressBar();
            this.lbl_windows = new System.Windows.Forms.Label();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.tmr_windowsBoot = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // xui_pbar_loading
            // 
            this.xui_pbar_loading.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xui_pbar_loading.BarThickness = 6;
            this.xui_pbar_loading.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xui_pbar_loading.InocmpletedColor = System.Drawing.Color.White;
            this.xui_pbar_loading.Location = new System.Drawing.Point(873, 704);
            this.xui_pbar_loading.MaxValue = 50;
            this.xui_pbar_loading.Name = "xui_pbar_loading";
            this.xui_pbar_loading.Size = new System.Drawing.Size(711, 10);
            this.xui_pbar_loading.TabIndex = 2;
            this.xui_pbar_loading.Text = "xuiFlatProgressBar1";
            this.xui_pbar_loading.Value = 0;
            // 
            // lbl_windows
            // 
            this.lbl_windows.AutoSize = true;
            this.lbl_windows.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windows.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_windows.Location = new System.Drawing.Point(1136, 533);
            this.lbl_windows.Name = "lbl_windows";
            this.lbl_windows.Size = new System.Drawing.Size(183, 33);
            this.lbl_windows.TabIndex = 0;
            this.lbl_windows.Text = "Windows OS";
            this.lbl_windows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.SlateGray;
            this.lbl_loading.Location = new System.Drawing.Point(1138, 592);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(72, 20);
            this.lbl_loading.TabIndex = 3;
            this.lbl_loading.Text = "STATUS";
            this.lbl_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_windowsBoot
            // 
            this.tmr_windowsBoot.Tick += new System.EventHandler(this.tmr_windowsBoot_Tick);
            // 
            // windowsBoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2560, 1440);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.xui_pbar_loading);
            this.Controls.Add(this.lbl_windows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "windowsBoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsLoading";
            this.Load += new System.EventHandler(this.windowsBoot_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowsBoot_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowsBoot_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIFlatProgressBar xui_pbar_loading;
        private System.Windows.Forms.Label lbl_windows;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Timer tmr_windowsBoot;
    }
}
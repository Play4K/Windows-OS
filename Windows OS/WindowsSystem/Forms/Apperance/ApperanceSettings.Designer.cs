
namespace Windows_OS.WindowsSystem.Forms
{
    partial class ApperanceSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApperanceSettings));
            this.xuiFlatProgressBar1 = new XanderUI.XUIFlatProgressBar();
            this.Tsp_MenuBar = new System.Windows.Forms.ToolStrip();
            this.Tsp_Close = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Minimize = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Label = new System.Windows.Forms.ToolStripLabel();
            this.Tsp_MenuBar.SuspendLayout();
            this.SuspendLayout();
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
            this.xuiFlatProgressBar1.TabIndex = 34;
            this.xuiFlatProgressBar1.Text = "xuiFlatProgressBar1";
            this.xuiFlatProgressBar1.Value = 100;
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
            this.Tsp_MenuBar.TabIndex = 33;
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
            this.Tsp_Close.Click += new System.EventHandler(this.Tsp_Close_Click);
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
            this.Tsp_Minimize.Click += new System.EventHandler(this.Tsp_Minimize_Click);
            // 
            // Tsp_Label
            // 
            this.Tsp_Label.Image = ((System.Drawing.Image)(resources.GetObject("Tsp_Label.Image")));
            this.Tsp_Label.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.Tsp_Label.Name = "Tsp_Label";
            this.Tsp_Label.Size = new System.Drawing.Size(80, 26);
            this.Tsp_Label.Text = "Apperance";
            // 
            // ApperanceSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiFlatProgressBar1);
            this.Controls.Add(this.Tsp_MenuBar);
            this.Name = "ApperanceSettings";
            this.Size = new System.Drawing.Size(900, 600);
            this.Tsp_MenuBar.ResumeLayout(false);
            this.Tsp_MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFlatProgressBar xuiFlatProgressBar1;
        private System.Windows.Forms.ToolStrip Tsp_MenuBar;
        private System.Windows.Forms.ToolStripButton Tsp_Close;
        private System.Windows.Forms.ToolStripButton Tsp_Minimize;
        private System.Windows.Forms.ToolStripLabel Tsp_Label;
    }
}

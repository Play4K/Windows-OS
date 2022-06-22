
namespace Windows_OS.WindowsSystem.Forms
{
    partial class Messenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messenger));
            this.Tsp_MenuBar = new System.Windows.Forms.ToolStrip();
            this.Tsp_Close = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Minimize = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Label = new System.Windows.Forms.ToolStripLabel();
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
            this.Tsp_MenuBar.Size = new System.Drawing.Size(800, 30);
            this.Tsp_MenuBar.TabIndex = 5;
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
            this.Tsp_Label.Size = new System.Drawing.Size(80, 26);
            this.Tsp_Label.Text = "Messenger";
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tsp_MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Messenger";
            this.Text = "Messenger";
            this.Tsp_MenuBar.ResumeLayout(false);
            this.Tsp_MenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tsp_MenuBar;
        private System.Windows.Forms.ToolStripButton Tsp_Close;
        private System.Windows.Forms.ToolStripButton Tsp_Minimize;
        private System.Windows.Forms.ToolStripLabel Tsp_Label;
    }
}
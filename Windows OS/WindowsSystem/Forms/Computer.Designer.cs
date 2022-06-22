
namespace Windows_OS.WindowsSystem.Forms
{
    partial class Computer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Computer));
            this.xuiFlatProgressBar1 = new XanderUI.XUIFlatProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tsp_MenuBar = new System.Windows.Forms.ToolStrip();
            this.Tsp_Close = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Minimize = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Label = new System.Windows.Forms.ToolStripLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Tsp_MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiFlatProgressBar1
            // 
            this.xuiFlatProgressBar1.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xuiFlatProgressBar1.BarThickness = 5;
            this.xuiFlatProgressBar1.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiFlatProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xuiFlatProgressBar1.InocmpletedColor = System.Drawing.Color.White;
            this.xuiFlatProgressBar1.Location = new System.Drawing.Point(0, 545);
            this.xuiFlatProgressBar1.MaxValue = 100;
            this.xuiFlatProgressBar1.Name = "xuiFlatProgressBar1";
            this.xuiFlatProgressBar1.Size = new System.Drawing.Size(800, 5);
            this.xuiFlatProgressBar1.TabIndex = 3;
            this.xuiFlatProgressBar1.Text = "xuiFlatProgressBar1";
            this.xuiFlatProgressBar1.Value = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(89, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 64);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "0 GB free of 0 GB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Local disk (C:)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(70, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(144, 16);
            this.progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(96, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Drives (2)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Location = new System.Drawing.Point(382, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 64);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(71, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "0 GB free of 0 GB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(71, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Volume (D:)";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(70, 22);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(144, 16);
            this.progressBar2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(187, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(620, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "_____________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(-4, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "_________";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(699, 22);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(4, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(45, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "-->";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dokumente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(458, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Desktop";
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
            this.Tsp_MenuBar.TabIndex = 17;
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
            this.Tsp_Label.Size = new System.Drawing.Size(77, 26);
            this.Tsp_Label.Text = "Computer";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(382, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 65);
            this.panel4.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(89, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 65);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.Tsp_MenuBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiFlatProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Computer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Tsp_MenuBar.ResumeLayout(false);
            this.Tsp_MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIFlatProgressBar xuiFlatProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip Tsp_MenuBar;
        private System.Windows.Forms.ToolStripButton Tsp_Close;
        private System.Windows.Forms.ToolStripButton Tsp_Minimize;
        private System.Windows.Forms.ToolStripLabel Tsp_Label;
    }
}
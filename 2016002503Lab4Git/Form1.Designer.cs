namespace _2016002503Lab4Git
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nestedForLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whileLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doWhileLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forEachLoopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLab4 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.taskListToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(233, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // taskListToolStripMenuItem
            // 
            this.taskListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forLoopToolStripMenuItem,
            this.nestedForLoopToolStripMenuItem,
            this.whileLoopToolStripMenuItem,
            this.doWhileLoopToolStripMenuItem,
            this.forEachLoopToolStripMenuItem});
            this.taskListToolStripMenuItem.Name = "taskListToolStripMenuItem";
            this.taskListToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.taskListToolStripMenuItem.Text = "Task List";
            // 
            // forLoopToolStripMenuItem
            // 
            this.forLoopToolStripMenuItem.Name = "forLoopToolStripMenuItem";
            this.forLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.forLoopToolStripMenuItem.Text = "For Loop";
            this.forLoopToolStripMenuItem.Click += new System.EventHandler(this.forLoopToolStripMenuItem_Click);
            // 
            // nestedForLoopToolStripMenuItem
            // 
            this.nestedForLoopToolStripMenuItem.Name = "nestedForLoopToolStripMenuItem";
            this.nestedForLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nestedForLoopToolStripMenuItem.Text = "Nested For Loop";
            this.nestedForLoopToolStripMenuItem.Click += new System.EventHandler(this.nestedForLoopToolStripMenuItem_Click);
            // 
            // whileLoopToolStripMenuItem
            // 
            this.whileLoopToolStripMenuItem.Name = "whileLoopToolStripMenuItem";
            this.whileLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.whileLoopToolStripMenuItem.Text = "While Loop";
            this.whileLoopToolStripMenuItem.Click += new System.EventHandler(this.whileLoopToolStripMenuItem_Click);
            // 
            // doWhileLoopToolStripMenuItem
            // 
            this.doWhileLoopToolStripMenuItem.Name = "doWhileLoopToolStripMenuItem";
            this.doWhileLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.doWhileLoopToolStripMenuItem.Text = "Do While Loop";
            this.doWhileLoopToolStripMenuItem.Click += new System.EventHandler(this.doWhileLoopToolStripMenuItem_Click);
            // 
            // forEachLoopToolStripMenuItem
            // 
            this.forEachLoopToolStripMenuItem.Name = "forEachLoopToolStripMenuItem";
            this.forEachLoopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.forEachLoopToolStripMenuItem.Text = "For Each Loop";
            this.forEachLoopToolStripMenuItem.Click += new System.EventHandler(this.forEachLoopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblLab4
            // 
            this.lblLab4.AutoSize = true;
            this.lblLab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab4.Location = new System.Drawing.Point(8, 34);
            this.lblLab4.Name = "lblLab4";
            this.lblLab4.Size = new System.Drawing.Size(218, 24);
            this.lblLab4.TabIndex = 1;
            this.lblLab4.Text = "Lab 4 Projects - Loops";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(16, 76);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(200, 200);
            this.txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 293);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblLab4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nestedForLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whileLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doWhileLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forEachLoopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblLab4;
        private System.Windows.Forms.TextBox txtOutput;
    }
}


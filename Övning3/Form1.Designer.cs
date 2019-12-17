namespace Övning3
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.väljFärgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljMappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.väljFärgToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(37, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Välj färg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.changeColor);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem1,
            this.väljTeckensnittToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 68);
            // 
            // väljFärgToolStripMenuItem1
            // 
            this.väljFärgToolStripMenuItem1.Name = "väljFärgToolStripMenuItem1";
            this.väljFärgToolStripMenuItem1.Size = new System.Drawing.Size(201, 32);
            this.väljFärgToolStripMenuItem1.Text = "Välj färg";
            this.väljFärgToolStripMenuItem1.Click += new System.EventHandler(this.changeColor);
            // 
            // väljTeckensnittToolStripMenuItem1
            // 
            this.väljTeckensnittToolStripMenuItem1.Name = "väljTeckensnittToolStripMenuItem1";
            this.väljTeckensnittToolStripMenuItem1.Size = new System.Drawing.Size(201, 32);
            this.väljTeckensnittToolStripMenuItem1.Text = "Välj teckensnitt";
            this.väljTeckensnittToolStripMenuItem1.Click += new System.EventHandler(this.changeFont);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Välj mapp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.changeFolder);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Välj teckensnitt";
            this.toolTip1.SetToolTip(this.button3, "Teckensnitt!!!");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.changeFont);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redigeraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem,
            this.väljMappToolStripMenuItem,
            this.väljTeckensnittToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // väljFärgToolStripMenuItem
            // 
            this.väljFärgToolStripMenuItem.Name = "väljFärgToolStripMenuItem";
            this.väljFärgToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.väljFärgToolStripMenuItem.Text = "Välj färg";
            this.väljFärgToolStripMenuItem.Click += new System.EventHandler(this.changeColor);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.väljMappToolStripMenuItem.Text = "Välj mapp";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.changeFolder);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.väljTeckensnittToolStripMenuItem.Text = "Välj teckensnitt";
            this.väljTeckensnittToolStripMenuItem.Click += new System.EventHandler(this.changeFont);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem2,
            this.väljTeckensnittToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(202, 68);
            // 
            // väljFärgToolStripMenuItem2
            // 
            this.väljFärgToolStripMenuItem2.Name = "väljFärgToolStripMenuItem2";
            this.väljFärgToolStripMenuItem2.Size = new System.Drawing.Size(240, 32);
            this.väljFärgToolStripMenuItem2.Text = "Välj färg";
            this.väljFärgToolStripMenuItem2.Click += new System.EventHandler(this.changeColor);
            // 
            // väljTeckensnittToolStripMenuItem2
            // 
            this.väljTeckensnittToolStripMenuItem2.Name = "väljTeckensnittToolStripMenuItem2";
            this.väljTeckensnittToolStripMenuItem2.Size = new System.Drawing.Size(240, 32);
            this.väljTeckensnittToolStripMenuItem2.Text = "Välj teckensnitt";
            this.väljTeckensnittToolStripMenuItem2.Click += new System.EventHandler(this.changeFont);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Teckensnitt";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 320);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljMappToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljTeckensnittToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem väljTeckensnittToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem väljTeckensnittToolStripMenuItem2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


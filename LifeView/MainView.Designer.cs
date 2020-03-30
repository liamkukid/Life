namespace LifeView
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.добавитьГлайдерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПолосуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСотыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПалкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.playToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГлайдерToolStripMenuItem,
            this.добавитьПолосуToolStripMenuItem,
            this.добавитьСотыToolStripMenuItem,
            this.добавитьПалкуToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // добавитьГлайдерToolStripMenuItem
            // 
            this.добавитьГлайдерToolStripMenuItem.Name = "добавитьГлайдерToolStripMenuItem";
            this.добавитьГлайдерToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьГлайдерToolStripMenuItem.Text = "Добавить глайдер";
            this.добавитьГлайдерToolStripMenuItem.Click += new System.EventHandler(this.addGliderToolStripMenuItem_Click);
            // 
            // добавитьПолосуToolStripMenuItem
            // 
            this.добавитьПолосуToolStripMenuItem.Name = "добавитьПолосуToolStripMenuItem";
            this.добавитьПолосуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьПолосуToolStripMenuItem.Text = "Добавить полосу";
            this.добавитьПолосуToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // добавитьСотыToolStripMenuItem
            // 
            this.добавитьСотыToolStripMenuItem.Name = "добавитьСотыToolStripMenuItem";
            this.добавитьСотыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьСотыToolStripMenuItem.Text = "Добавить соты";
            this.добавитьСотыToolStripMenuItem.Click += new System.EventHandler(this.добавитьСотыToolStripMenuItem_Click);
            // 
            // добавитьПалкуToolStripMenuItem
            // 
            this.добавитьПалкуToolStripMenuItem.Name = "добавитьПалкуToolStripMenuItem";
            this.добавитьПалкуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьПалкуToolStripMenuItem.Text = "Добавить палку";
            this.добавитьПалкуToolStripMenuItem.Click += new System.EventHandler(this.добавитьПалкуToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainView";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem добавитьГлайдерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПолосуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПалкуToolStripMenuItem;
    }
}
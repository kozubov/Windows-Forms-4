namespace WF_4_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Back1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Forward1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Back2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2_Forward2 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem1_Back3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_Forward3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 355);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(325, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(346, 355);
            this.listBox2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Back1,
            this.ToolStripMenuItem_Forward1});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // ToolStripMenuItem_Back1
            // 
            this.ToolStripMenuItem_Back1.Name = "ToolStripMenuItem_Back1";
            this.ToolStripMenuItem_Back1.Size = new System.Drawing.Size(113, 22);
            this.ToolStripMenuItem_Back1.Text = "Назад";
            // 
            // ToolStripMenuItem_Forward1
            // 
            this.ToolStripMenuItem_Forward1.Name = "ToolStripMenuItem_Forward1";
            this.ToolStripMenuItem_Forward1.Size = new System.Drawing.Size(113, 22);
            this.ToolStripMenuItem_Forward1.Text = "Вперед";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Back2,
            this.toolStripButton2_Forward2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Back2
            // 
            this.toolStripButton_Back2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Back2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Back2.Image")));
            this.toolStripButton_Back2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Back2.Name = "toolStripButton_Back2";
            this.toolStripButton_Back2.Size = new System.Drawing.Size(43, 22);
            this.toolStripButton_Back2.Text = "Назад";
            // 
            // toolStripButton2_Forward2
            // 
            this.toolStripButton2_Forward2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2_Forward2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2_Forward2.Image")));
            this.toolStripButton2_Forward2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2_Forward2.Name = "toolStripButton2_Forward2";
            this.toolStripButton2_Forward2.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton2_Forward2.Text = "Вперед";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1_Back3,
            this.ToolStripMenuItem1_Forward3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // ToolStripMenuItem1_Back3
            // 
            this.ToolStripMenuItem1_Back3.Name = "ToolStripMenuItem1_Back3";
            this.ToolStripMenuItem1_Back3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ToolStripMenuItem1_Back3.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItem1_Back3.Text = "Назад";
            // 
            // ToolStripMenuItem1_Forward3
            // 
            this.ToolStripMenuItem1_Forward3.Name = "ToolStripMenuItem1_Forward3";
            this.ToolStripMenuItem1_Forward3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ToolStripMenuItem1_Forward3.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItem1_Forward3.Text = "Вперед";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Back1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Forward1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Back2;
        private System.Windows.Forms.ToolStripButton toolStripButton2_Forward2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_Back3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_Forward3;
    }
}


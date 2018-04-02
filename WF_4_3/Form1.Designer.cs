namespace WF_4_3
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
            this.textBox_AddMenuItem = new System.Windows.Forms.TextBox();
            this.textBox_AddMenuSubItem = new System.Windows.Forms.TextBox();
            this.button_AddMenuItem = new System.Windows.Forms.Button();
            this.button_AddMenuSubItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_AddMenuItem
            // 
            this.textBox_AddMenuItem.Location = new System.Drawing.Point(52, 168);
            this.textBox_AddMenuItem.Name = "textBox_AddMenuItem";
            this.textBox_AddMenuItem.Size = new System.Drawing.Size(146, 20);
            this.textBox_AddMenuItem.TabIndex = 0;
            // 
            // textBox_AddMenuSubItem
            // 
            this.textBox_AddMenuSubItem.Location = new System.Drawing.Point(52, 203);
            this.textBox_AddMenuSubItem.Name = "textBox_AddMenuSubItem";
            this.textBox_AddMenuSubItem.Size = new System.Drawing.Size(146, 20);
            this.textBox_AddMenuSubItem.TabIndex = 1;
            // 
            // button_AddMenuItem
            // 
            this.button_AddMenuItem.Location = new System.Drawing.Point(218, 166);
            this.button_AddMenuItem.Name = "button_AddMenuItem";
            this.button_AddMenuItem.Size = new System.Drawing.Size(117, 23);
            this.button_AddMenuItem.TabIndex = 2;
            this.button_AddMenuItem.Text = "+ Пункт меню";
            this.button_AddMenuItem.UseVisualStyleBackColor = true;
            this.button_AddMenuItem.Click += new System.EventHandler(this.button_AddMenuItem_Click);
            // 
            // button_AddMenuSubItem
            // 
            this.button_AddMenuSubItem.Location = new System.Drawing.Point(218, 204);
            this.button_AddMenuSubItem.Name = "button_AddMenuSubItem";
            this.button_AddMenuSubItem.Size = new System.Drawing.Size(117, 23);
            this.button_AddMenuSubItem.TabIndex = 3;
            this.button_AddMenuSubItem.Text = "+ Подпункт меню";
            this.button_AddMenuSubItem.UseVisualStyleBackColor = true;
            this.button_AddMenuSubItem.Click += new System.EventHandler(this.button_AddMenuSubItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 261);
            this.Controls.Add(this.button_AddMenuSubItem);
            this.Controls.Add(this.button_AddMenuItem);
            this.Controls.Add(this.textBox_AddMenuSubItem);
            this.Controls.Add(this.textBox_AddMenuItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AddMenuItem;
        private System.Windows.Forms.TextBox textBox_AddMenuSubItem;
        private System.Windows.Forms.Button button_AddMenuItem;
        private System.Windows.Forms.Button button_AddMenuSubItem;
    }
}


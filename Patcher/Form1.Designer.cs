namespace Pulsive_Crack
{
    partial class Pulsive_Patcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pulsive_Patcher));
            this.Patch_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Patch_BTN
            // 
            this.Patch_BTN.AutoEllipsis = true;
            this.Patch_BTN.BackColor = System.Drawing.Color.Green;
            this.Patch_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Patch_BTN.Enabled = false;
            this.Patch_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Patch_BTN.FlatAppearance.BorderSize = 0;
            this.Patch_BTN.Font = new System.Drawing.Font("Urdu Typesetting", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Patch_BTN.Location = new System.Drawing.Point(12, 12);
            this.Patch_BTN.Name = "Patch_BTN";
            this.Patch_BTN.Size = new System.Drawing.Size(170, 120);
            this.Patch_BTN.TabIndex = 0;
            this.Patch_BTN.Text = "Patch";
            this.Patch_BTN.UseVisualStyleBackColor = false;
            this.Patch_BTN.Click += new System.EventHandler(this.Patch_BTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Urdu Typesetting", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 120);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Path";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Made by NASC";
            // 
            // Pulsive_Patcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(436, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Patch_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pulsive_Patcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pulsive Patcher";
            this.Load += new System.EventHandler(this.Pulsive_Patcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Patch_BTN;
        private Button button1;
        private Label label1;
    }
}
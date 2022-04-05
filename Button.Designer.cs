﻿
namespace DataJuggler.Win.Controls
{
    partial class Button
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
            this.InnerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InnerButton
            // 
            this.InnerButton.BackColor = System.Drawing.Color.Transparent;
            this.InnerButton.BackgroundImage = global::DataJuggler.Win.Controls.Properties.Resources.WoodButtonWidth640;
            this.InnerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InnerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerButton.FlatAppearance.BorderSize = 0;
            this.InnerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.InnerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.InnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InnerButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InnerButton.Location = new System.Drawing.Point(0, 0);
            this.InnerButton.Name = "InnerButton";
            this.InnerButton.Size = new System.Drawing.Size(120, 44);
            this.InnerButton.TabIndex = 0;
            this.InnerButton.Text = "Click Me";
            this.InnerButton.UseVisualStyleBackColor = false;
            this.InnerButton.Click += new System.EventHandler(this.InnerButton_Click);
            this.InnerButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.InnerButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.InnerButton);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(120, 44);
            this.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.FontChanged += new System.EventHandler(this.Button_FontChanged);
            this.ForeColorChanged += new System.EventHandler(this.Button_ForeColorChanged);
            this.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InnerButton;
    }
}


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
            InnerButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // InnerButton
            // 
            InnerButton.BackColor = System.Drawing.Color.Transparent;
            InnerButton.BackgroundImage = Properties.Resources.GlassButtonBlack;
            InnerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            InnerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            InnerButton.FlatAppearance.BorderSize = 0;
            InnerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            InnerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            InnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            InnerButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            InnerButton.Location = new System.Drawing.Point(0, 0);
            InnerButton.Name = "InnerButton";
            InnerButton.Size = new System.Drawing.Size(120, 44);
            InnerButton.TabIndex = 0;
            InnerButton.Text = "Click Me";
            InnerButton.UseVisualStyleBackColor = false;
            InnerButton.Click += InnerButton_Click;
            InnerButton.MouseEnter += Button_Enter;
            InnerButton.MouseLeave += Button_Leave;
            // 
            // Button
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(InnerButton);
            Name = "Button";
            Size = new System.Drawing.Size(120, 44);
            EnabledChanged += Button_EnabledChanged;
            FontChanged += Button_FontChanged;
            ForeColorChanged += Button_ForeColorChanged;
            MouseEnter += Button_Enter;
            MouseLeave += Button_Leave;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button InnerButton;
    }
}

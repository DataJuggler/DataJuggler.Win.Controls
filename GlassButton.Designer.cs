namespace DataJuggler.Win.Controls
{
    partial class GlassButton
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
            Label = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Label
            // 
            Label.Dock = System.Windows.Forms.DockStyle.Fill;
            Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Label.ForeColor = System.Drawing.Color.GhostWhite;
            Label.Location = new System.Drawing.Point(0, 0);
            Label.Name = "Label";
            Label.Size = new System.Drawing.Size(120, 44);
            Label.TabIndex = 0;
            Label.Text = "[Button Text]";
            Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label.Enter += Label_Enter;
            Label.Leave += Label_Leave;
            // 
            // GlassButton
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImage = Properties.Resources.GlassButtonBlack;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Controls.Add(Label);
            Name = "GlassButton";
            Size = new System.Drawing.Size(120, 44);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label Label;
    }
}

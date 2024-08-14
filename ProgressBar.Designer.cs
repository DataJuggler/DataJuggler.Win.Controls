namespace DataJuggler.Win.Controls
{
    partial class ProgressBar
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
            ValuePanel = new Objects.PanelExtender();
            SuspendLayout();
            // 
            // ValuePanel
            // 
            ValuePanel.Dock = System.Windows.Forms.DockStyle.Left;
            ValuePanel.Location = new System.Drawing.Point(0, 0);
            ValuePanel.Name = "ValuePanel";
            ValuePanel.Size = new System.Drawing.Size(200, 22);
            ValuePanel.TabIndex = 0;
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(ValuePanel);
            DoubleBuffered = true;
            Name = "ProgressBar";
            Size = new System.Drawing.Size(758, 22);
            ForeColorChanged += ProgressBar_ForeColorChanged;
            ResumeLayout(false);
        }

        #endregion

        private Objects.PanelExtender ValuePanel;
    }
}

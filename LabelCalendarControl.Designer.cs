namespace DataJuggler.Win.Controls
{
    partial class LabelCalendarControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private new System.ComponentModel.IContainer components = null;

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
            this.SelectionButton = new DataJuggler.Win.Controls.Button();
            this.SuspendLayout();
            // 
            // SelectionButton
            // 
            this.SelectionButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectionButton.ButtonText = "...";
            this.SelectionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectionButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SelectionButton.Location = new System.Drawing.Point(819, 1);
            this.SelectionButton.Margin = new System.Windows.Forms.Padding(5);
            this.SelectionButton.MaximumSize = new System.Drawing.Size(48, 36);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(48, 36);
            this.SelectionButton.TabIndex = 19;
            this.SelectionButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // LabelCalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectionButton);
            this.Name = "LabelCalendarControl";
            this.Size = new System.Drawing.Size(867, 214);
            this.Controls.SetChildIndex(this.SelectionButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectionButton;
    }
}

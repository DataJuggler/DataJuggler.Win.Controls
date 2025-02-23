

#region using statements


#endregion

namespace DataJuggler.Win.Controls
{

    #region class LabelTextBoxControl
    /// <summary>
    /// This class is used to display a Label and a LabelTextBox for editing.
    /// </summary>
    partial class LabelTextBoxControl
    {
        
        #region Private Variables
        internal System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.Panel TextBoxTopMarginPanel;
        internal System.Windows.Forms.Panel TextBoxBottomMarginPanel;
        internal System.Windows.Forms.Panel BottomMarginPanel;
        internal System.Windows.Forms.Panel LeftPanel;
        internal System.Windows.Forms.Label Label;
        internal System.Windows.Forms.Panel LabelRightMargin;
        internal System.Windows.Forms.Panel LabelTopMarginPanel;
        internal System.Windows.Forms.Panel LabelBottomMarginPanel;
        internal System.Windows.Forms.TextBox TextBox;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
        #endregion

        #region InitializeComponent()
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxTopMarginPanel = new System.Windows.Forms.Panel();
            TextBoxBottomMarginPanel = new System.Windows.Forms.Panel();
            BottomMarginPanel = new System.Windows.Forms.Panel();
            LeftPanel = new System.Windows.Forms.Panel();
            Label = new System.Windows.Forms.Label();
            LabelRightMargin = new System.Windows.Forms.Panel();
            LabelTopMarginPanel = new System.Windows.Forms.Panel();
            LabelBottomMarginPanel = new System.Windows.Forms.Panel();
            TextBox = new System.Windows.Forms.TextBox();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxTopMarginPanel
            // 
            TextBoxTopMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            TextBoxTopMarginPanel.Location = new System.Drawing.Point(0, 0);
            TextBoxTopMarginPanel.Name = "TextBoxTopMarginPanel";
            TextBoxTopMarginPanel.Size = new System.Drawing.Size(360, 1);
            TextBoxTopMarginPanel.TabIndex = 6;
            // 
            // TextBoxBottomMarginPanel
            // 
            TextBoxBottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            TextBoxBottomMarginPanel.Location = new System.Drawing.Point(0, 31);
            TextBoxBottomMarginPanel.Name = "TextBoxBottomMarginPanel";
            TextBoxBottomMarginPanel.Size = new System.Drawing.Size(360, 1);
            TextBoxBottomMarginPanel.TabIndex = 8;
            // 
            // BottomMarginPanel
            // 
            BottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            BottomMarginPanel.Location = new System.Drawing.Point(0, 31);
            BottomMarginPanel.Name = "BottomMarginPanel";
            BottomMarginPanel.Size = new System.Drawing.Size(360, 0);
            BottomMarginPanel.TabIndex = 14;
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(Label);
            LeftPanel.Controls.Add(LabelRightMargin);
            LeftPanel.Controls.Add(LabelTopMarginPanel);
            LeftPanel.Controls.Add(LabelBottomMarginPanel);
            LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            LeftPanel.Location = new System.Drawing.Point(0, 1);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new System.Drawing.Size(160, 30);
            LeftPanel.TabIndex = 17;
            // 
            // Label
            // 
            Label.Dock = System.Windows.Forms.DockStyle.Fill;
            Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            Label.Location = new System.Drawing.Point(0, 0);
            Label.Name = "Label";
            Label.Size = new System.Drawing.Size(158, 30);
            Label.TabIndex = 18;
            Label.Text = "[LabelText]";
            Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelRightMargin
            // 
            LabelRightMargin.Dock = System.Windows.Forms.DockStyle.Right;
            LabelRightMargin.Location = new System.Drawing.Point(158, 0);
            LabelRightMargin.Name = "LabelRightMargin";
            LabelRightMargin.Size = new System.Drawing.Size(2, 30);
            LabelRightMargin.TabIndex = 17;
            // 
            // LabelTopMarginPanel
            // 
            LabelTopMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            LabelTopMarginPanel.Location = new System.Drawing.Point(0, 0);
            LabelTopMarginPanel.Name = "LabelTopMarginPanel";
            LabelTopMarginPanel.Size = new System.Drawing.Size(160, 0);
            LabelTopMarginPanel.TabIndex = 7;
            // 
            // LabelBottomMarginPanel
            // 
            LabelBottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            LabelBottomMarginPanel.Location = new System.Drawing.Point(0, 30);
            LabelBottomMarginPanel.Name = "LabelBottomMarginPanel";
            LabelBottomMarginPanel.Size = new System.Drawing.Size(160, 0);
            LabelBottomMarginPanel.TabIndex = 5;
            // 
            // TextBox
            // 
            TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            TextBox.Font = new System.Drawing.Font("Calibri", 12F);
            TextBox.Location = new System.Drawing.Point(160, 1);
            TextBox.Name = "TextBox";
            TextBox.Size = new System.Drawing.Size(200, 27);
            TextBox.TabIndex = 18;
            TextBox.TextChanged += TextBox_TextChanged;
            // 
            // LabelTextBoxControl
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.Transparent;
            Controls.Add(TextBox);
            Controls.Add(LeftPanel);
            Controls.Add(BottomMarginPanel);
            Controls.Add(TextBoxBottomMarginPanel);
            Controls.Add(TextBoxTopMarginPanel);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            Name = "LabelTextBoxControl";
            Size = new System.Drawing.Size(360, 32);
            EnabledChanged += LabelTextBoxControl_EnabledChanged;
            LeftPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        #endregion

    }
    #endregion

}

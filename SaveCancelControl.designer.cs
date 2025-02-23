namespace DataJuggler.Win.Controls
{
    partial class SaveCancelControl
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.RightMarginPanel = new System.Windows.Forms.Panel();
            this.CancelSaveButton = new DataJuggler.Win.Controls.Button();
            this.FillerPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new DataJuggler.Win.Controls.Button();
            this.FillerPanel2 = new System.Windows.Forms.Panel();
            this.SaveAndCloseButton = new DataJuggler.Win.Controls.Button();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(494, 8);
            this.TopPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 44);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(494, 8);
            this.BottomPanel.TabIndex = 1;
            // 
            // RightMarginPanel
            // 
            this.RightMarginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMarginPanel.Location = new System.Drawing.Point(486, 8);
            this.RightMarginPanel.Name = "RightMarginPanel";
            this.RightMarginPanel.Size = new System.Drawing.Size(8, 36);
            this.RightMarginPanel.TabIndex = 2;
            // 
            // CancelSaveButton
            // 
            this.CancelSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelSaveButton.ButtonText = "Cancel";
            this.CancelSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSaveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelSaveButton.ForeColor = System.Drawing.Color.Black;
            this.CancelSaveButton.Location = new System.Drawing.Point(389, 8);
            this.CancelSaveButton.Margin = new System.Windows.Forms.Padding(14, 7, 14, 7);
            this.CancelSaveButton.Name = "CancelSaveButton";
            this.CancelSaveButton.Size = new System.Drawing.Size(97, 36);
            this.CancelSaveButton.TabIndex = 12;
            this.CancelSaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.CancelSaveButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.CancelSaveButton.Click += new System.EventHandler(this.CancelSave_Click);
            // 
            // FillerPanel
            // 
            this.FillerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FillerPanel.Location = new System.Drawing.Point(381, 8);
            this.FillerPanel.Name = "FillerPanel";
            this.FillerPanel.Size = new System.Drawing.Size(8, 36);
            this.FillerPanel.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(293, 8);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 36);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.SaveButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FillerPanel2
            // 
            this.FillerPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.FillerPanel2.Location = new System.Drawing.Point(285, 8);
            this.FillerPanel2.Name = "FillerPanel2";
            this.FillerPanel2.Size = new System.Drawing.Size(8, 36);
            this.FillerPanel2.TabIndex = 19;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveAndCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveAndCloseButton.ButtonText = "Save && Close";
            this.SaveAndCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveAndCloseButton.ForeColor = System.Drawing.Color.Black;
            this.SaveAndCloseButton.Location = new System.Drawing.Point(145, 8);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(140, 36);
            this.SaveAndCloseButton.TabIndex = 20;
            this.SaveAndCloseButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // SaveCancelControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.FillerPanel2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FillerPanel);
            this.Controls.Add(this.CancelSaveButton);
            this.Controls.Add(this.RightMarginPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SaveCancelControl";
            this.Size = new System.Drawing.Size(494, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel RightMarginPanel;
        private Button CancelSaveButton;
        private System.Windows.Forms.Panel FillerPanel;
        private Button SaveButton;
        private System.Windows.Forms.Panel FillerPanel2;
        private Button SaveAndCloseButton;
    }
}

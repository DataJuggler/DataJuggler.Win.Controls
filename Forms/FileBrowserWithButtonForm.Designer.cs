
namespace DataJuggler.Win.Controls.Forms
{
    partial class FileBrowserWithButtonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBrowserWithButtonForm));
            this.FileBrowserControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ProcessFileButton = new DataJuggler.Win.Controls.Button();
            this.SuspendLayout();
            // 
            // FileBrowserControl
            // 
            this.FileBrowserControl.BackColor = System.Drawing.Color.Transparent;
            this.FileBrowserControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.FileBrowserControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("FileBrowserControl.ButtonImage")));
            this.FileBrowserControl.ButtonWidth = 48;
            this.FileBrowserControl.DarkMode = false;
            this.FileBrowserControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.FileBrowserControl.Editable = true;
            this.FileBrowserControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.FileBrowserControl.Filter = null;
            this.FileBrowserControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileBrowserControl.HideBrowseButton = false;
            this.FileBrowserControl.LabelBottomMargin = 0;
            this.FileBrowserControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.FileBrowserControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FileBrowserControl.LabelText = "File Path:";
            this.FileBrowserControl.LabelTopMargin = 0;
            this.FileBrowserControl.LabelWidth = 112;
            this.FileBrowserControl.Location = new System.Drawing.Point(45, 58);
            this.FileBrowserControl.Name = "FileBrowserControl";
            this.FileBrowserControl.OnTextChangedListener = null;
            this.FileBrowserControl.OpenCallback = null;
            this.FileBrowserControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FileBrowserControl.SelectedPath = null;
            this.FileBrowserControl.Size = new System.Drawing.Size(705, 32);
            this.FileBrowserControl.StartPath = null;
            this.FileBrowserControl.TabIndex = 0;
            this.FileBrowserControl.TextBoxBottomMargin = 0;
            this.FileBrowserControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.FileBrowserControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.FileBrowserControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileBrowserControl.TextBoxTopMargin = 0;
            this.FileBrowserControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ProcessFileButton
            // 
            this.ProcessFileButton.BackColor = System.Drawing.Color.Transparent;
            this.ProcessFileButton.ButtonText = "Start";
            this.ProcessFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessFileButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcessFileButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ProcessFileButton.Location = new System.Drawing.Point(618, 148);
            this.ProcessFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessFileButton.Name = "ProcessFileButton";
            this.ProcessFileButton.Size = new System.Drawing.Size(132, 48);
            this.ProcessFileButton.TabIndex = 1;
            this.ProcessFileButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.ProcessFileButton.Click += new System.EventHandler(this.ProcessFileButton_Click);
            // 
            // FileBrowserWithButtonForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::DataJuggler.Win.Controls.Properties.Resources.Deep_Black;
            this.ClientSize = new System.Drawing.Size(784, 231);
            this.Controls.Add(this.ProcessFileButton);
            this.Controls.Add(this.FileBrowserControl);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileBrowserWithButtonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Browser With Button";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextBoxBrowserControl FileBrowserControl;
        private Button ProcessFileButton;
    }
}
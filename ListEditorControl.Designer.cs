namespace DataJuggler.Win.Controls
{
    partial class ListEditorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListEditorControl));
            BottomMarginPanel = new Objects.PanelExtender();
            TopMarginPanel = new Objects.PanelExtender();
            LeftMarginPanel = new Objects.PanelExtender();
            ListEditorPanel = new Objects.PanelExtender();
            ListBox = new System.Windows.Forms.ListBox();
            ButtonPanel = new Objects.PanelExtender();
            DeleteButton = new System.Windows.Forms.Button();
            EditButton = new System.Windows.Forms.Button();
            AddButton = new System.Windows.Forms.Button();
            AllItemsLabel = new System.Windows.Forms.Label();
            SeperatorPanel = new Objects.PanelExtender();
            SelectedControlPanel = new Objects.PanelExtender();
            EditControlPanel = new Objects.PanelExtender();
            SelectedItemLabel = new System.Windows.Forms.Label();
            SavePanel = new Objects.PanelExtender();
            RightMarginPanel = new Objects.PanelExtender();
            ListEditorPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SelectedControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BottomMarginPanel
            // 
            BottomMarginPanel.BackColor = System.Drawing.Color.Transparent;
            BottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            BottomMarginPanel.Location = new System.Drawing.Point(0, 304);
            BottomMarginPanel.Name = "BottomMarginPanel";
            BottomMarginPanel.Size = new System.Drawing.Size(320, 16);
            BottomMarginPanel.TabIndex = 13;
            // 
            // TopMarginPanel
            // 
            TopMarginPanel.BackColor = System.Drawing.Color.Transparent;
            TopMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            TopMarginPanel.Location = new System.Drawing.Point(0, 0);
            TopMarginPanel.Name = "TopMarginPanel";
            TopMarginPanel.Size = new System.Drawing.Size(320, 16);
            TopMarginPanel.TabIndex = 7;
            // 
            // LeftMarginPanel
            // 
            LeftMarginPanel.BackColor = System.Drawing.Color.Transparent;
            LeftMarginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            LeftMarginPanel.Location = new System.Drawing.Point(0, 16);
            LeftMarginPanel.Name = "LeftMarginPanel";
            LeftMarginPanel.Size = new System.Drawing.Size(16, 288);
            LeftMarginPanel.TabIndex = 19;
            // 
            // ListEditorPanel
            // 
            ListEditorPanel.BackColor = System.Drawing.Color.Transparent;
            ListEditorPanel.Controls.Add(ListBox);
            ListEditorPanel.Controls.Add(ButtonPanel);
            ListEditorPanel.Controls.Add(AllItemsLabel);
            ListEditorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            ListEditorPanel.Location = new System.Drawing.Point(16, 16);
            ListEditorPanel.Name = "ListEditorPanel";
            ListEditorPanel.Size = new System.Drawing.Size(286, 288);
            ListEditorPanel.TabIndex = 21;
            // 
            // ListBox
            // 
            ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 18;
            ListBox.Location = new System.Drawing.Point(0, 20);
            ListBox.Name = "ListBox";
            ListBox.Size = new System.Drawing.Size(286, 218);
            ListBox.TabIndex = 20;
            ListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(DeleteButton);
            ButtonPanel.Controls.Add(EditButton);
            ButtonPanel.Controls.Add(AddButton);
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonPanel.Location = new System.Drawing.Point(0, 238);
            ButtonPanel.MaximumSize = new System.Drawing.Size(0, 50);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(286, 50);
            ButtonPanel.TabIndex = 16;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = System.Drawing.Color.Transparent;
            DeleteButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("DeleteButton.BackgroundImage");
            DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            DeleteButton.Location = new System.Drawing.Point(191, 9);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(84, 36);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.EnabledChanged += Button_EnableChanged;
            DeleteButton.Click += DeleteButton_Click;
            DeleteButton.MouseEnter += Button_Enter;
            DeleteButton.MouseLeave += Button_Leave;
            // 
            // EditButton
            // 
            EditButton.BackColor = System.Drawing.Color.Transparent;
            EditButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("EditButton.BackgroundImage");
            EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            EditButton.Location = new System.Drawing.Point(101, 9);
            EditButton.Name = "EditButton";
            EditButton.Size = new System.Drawing.Size(84, 36);
            EditButton.TabIndex = 7;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.EnabledChanged += Button_EnableChanged;
            EditButton.Click += EditButton_Click;
            EditButton.MouseEnter += Button_Enter;
            EditButton.MouseLeave += Button_Leave;
            // 
            // AddButton
            // 
            AddButton.BackColor = System.Drawing.Color.Transparent;
            AddButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("AddButton.BackgroundImage");
            AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AddButton.Location = new System.Drawing.Point(11, 9);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(84, 36);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.EnabledChanged += Button_EnableChanged;
            AddButton.Click += AddButton_Click;
            AddButton.MouseEnter += Button_Enter;
            AddButton.MouseLeave += Button_Leave;
            // 
            // AllItemsLabel
            // 
            AllItemsLabel.BackColor = System.Drawing.Color.Transparent;
            AllItemsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            AllItemsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AllItemsLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            AllItemsLabel.Location = new System.Drawing.Point(0, 0);
            AllItemsLabel.Name = "AllItemsLabel";
            AllItemsLabel.Size = new System.Drawing.Size(286, 20);
            AllItemsLabel.TabIndex = 18;
            AllItemsLabel.Text = "All Items";
            AllItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeperatorPanel
            // 
            SeperatorPanel.BackColor = System.Drawing.Color.Transparent;
            SeperatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            SeperatorPanel.Location = new System.Drawing.Point(302, 16);
            SeperatorPanel.Name = "SeperatorPanel";
            SeperatorPanel.Size = new System.Drawing.Size(16, 288);
            SeperatorPanel.TabIndex = 22;
            // 
            // SelectedControlPanel
            // 
            SelectedControlPanel.BackColor = System.Drawing.Color.Transparent;
            SelectedControlPanel.Controls.Add(EditControlPanel);
            SelectedControlPanel.Controls.Add(SelectedItemLabel);
            SelectedControlPanel.Controls.Add(SavePanel);
            SelectedControlPanel.Controls.Add(RightMarginPanel);
            SelectedControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectedControlPanel.Location = new System.Drawing.Point(318, 16);
            SelectedControlPanel.Name = "SelectedControlPanel";
            SelectedControlPanel.Size = new System.Drawing.Size(2, 288);
            SelectedControlPanel.TabIndex = 23;
            SelectedControlPanel.Visible = false;
            // 
            // EditControlPanel
            // 
            EditControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            EditControlPanel.Location = new System.Drawing.Point(0, 20);
            EditControlPanel.Name = "EditControlPanel";
            EditControlPanel.Size = new System.Drawing.Size(0, 220);
            EditControlPanel.TabIndex = 11;
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.BackColor = System.Drawing.Color.Transparent;
            SelectedItemLabel.Dock = System.Windows.Forms.DockStyle.Top;
            SelectedItemLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            SelectedItemLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            SelectedItemLabel.Location = new System.Drawing.Point(0, 0);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new System.Drawing.Size(0, 20);
            SelectedItemLabel.TabIndex = 10;
            SelectedItemLabel.Text = "Selected Item";
            SelectedItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SavePanel
            // 
            SavePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            SavePanel.Location = new System.Drawing.Point(0, 240);
            SavePanel.Name = "SavePanel";
            SavePanel.Size = new System.Drawing.Size(0, 48);
            SavePanel.TabIndex = 8;
            // 
            // RightMarginPanel
            // 
            RightMarginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            RightMarginPanel.Location = new System.Drawing.Point(-14, 0);
            RightMarginPanel.Name = "RightMarginPanel";
            RightMarginPanel.Size = new System.Drawing.Size(16, 288);
            RightMarginPanel.TabIndex = 3;
            // 
            // ListEditorControl
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BlackImage;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Controls.Add(SelectedControlPanel);
            Controls.Add(SeperatorPanel);
            Controls.Add(ListEditorPanel);
            Controls.Add(LeftMarginPanel);
            Controls.Add(BottomMarginPanel);
            Controls.Add(TopMarginPanel);
            DoubleBuffered = true;
            Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "ListEditorControl";
            Size = new System.Drawing.Size(320, 320);
            ListEditorPanel.ResumeLayout(false);
            ButtonPanel.ResumeLayout(false);
            SelectedControlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Objects.PanelExtender TopMarginPanel;
        private Objects.PanelExtender BottomMarginPanel;
        private Objects.PanelExtender LeftMarginPanel;
        private Objects.PanelExtender ListEditorPanel;
        private System.Windows.Forms.Label AllItemsLabel;
        private Objects.PanelExtender ButtonPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private Objects.PanelExtender SeperatorPanel;
        private Objects.PanelExtender SelectedControlPanel;
        private Objects.PanelExtender EditControlPanel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private Objects.PanelExtender SavePanel;
        private Objects.PanelExtender RightMarginPanel;
        private System.Windows.Forms.ListBox ListBox;
    }
}

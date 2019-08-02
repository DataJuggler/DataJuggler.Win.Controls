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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TopMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.SelectedControlPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.EditControlPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.SavePanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.BottomMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.RightMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.panelExtender1 = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.AllItemsLabel = new System.Windows.Forms.Label();
            this.SelectedControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 18;
            this.ListBox.Location = new System.Drawing.Point(19, 39);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(264, 382);
            this.ListBox.TabIndex = 2;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(19, 427);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 36);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.EnabledChanged += new System.EventHandler(this.Button_EnableChanged);
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.AddButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(109, 427);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(84, 36);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.EnabledChanged += new System.EventHandler(this.Button_EnableChanged);
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this.EditButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.EditButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(199, 427);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 36);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.EnabledChanged += new System.EventHandler(this.Button_EnableChanged);
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // TopMarginPanel
            // 
            this.TopMarginPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMarginPanel.Location = new System.Drawing.Point(0, 0);
            this.TopMarginPanel.Name = "TopMarginPanel";
            this.TopMarginPanel.Size = new System.Drawing.Size(720, 16);
            this.TopMarginPanel.TabIndex = 7;
            // 
            // SelectedControlPanel
            // 
            this.SelectedControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.SelectedControlPanel.Controls.Add(this.EditControlPanel);
            this.SelectedControlPanel.Controls.Add(this.SavePanel);
            this.SelectedControlPanel.Controls.Add(this.BottomMarginPanel);
            this.SelectedControlPanel.Controls.Add(this.RightMarginPanel);
            this.SelectedControlPanel.Controls.Add(this.SelectedItemLabel);
            this.SelectedControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectedControlPanel.Location = new System.Drawing.Point(304, 16);
            this.SelectedControlPanel.Name = "SelectedControlPanel";
            this.SelectedControlPanel.Size = new System.Drawing.Size(416, 464);
            this.SelectedControlPanel.TabIndex = 8;
            // 
            // EditControlPanel
            // 
            this.EditControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditControlPanel.Location = new System.Drawing.Point(0, 20);
            this.EditControlPanel.Name = "EditControlPanel";
            this.EditControlPanel.Size = new System.Drawing.Size(400, 370);
            this.EditControlPanel.TabIndex = 9;
            // 
            // SavePanel
            // 
            this.SavePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SavePanel.Location = new System.Drawing.Point(0, 390);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(400, 66);
            this.SavePanel.TabIndex = 8;
            // 
            // BottomMarginPanel
            // 
            this.BottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMarginPanel.Location = new System.Drawing.Point(0, 456);
            this.BottomMarginPanel.Name = "BottomMarginPanel";
            this.BottomMarginPanel.Size = new System.Drawing.Size(400, 8);
            this.BottomMarginPanel.TabIndex = 4;
            // 
            // RightMarginPanel
            // 
            this.RightMarginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMarginPanel.Location = new System.Drawing.Point(400, 20);
            this.RightMarginPanel.Name = "RightMarginPanel";
            this.RightMarginPanel.Size = new System.Drawing.Size(16, 444);
            this.RightMarginPanel.TabIndex = 3;
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectedItemLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedItemLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SelectedItemLabel.Location = new System.Drawing.Point(0, 0);
            this.SelectedItemLabel.MaximumSize = new System.Drawing.Size(300, 20);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(300, 20);
            this.SelectedItemLabel.TabIndex = 2;
            this.SelectedItemLabel.Text = "Selected Item";
            this.SelectedItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelExtender1
            // 
            this.panelExtender1.BackColor = System.Drawing.Color.Transparent;
            this.panelExtender1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelExtender1.Location = new System.Drawing.Point(0, 16);
            this.panelExtender1.Name = "panelExtender1";
            this.panelExtender1.Size = new System.Drawing.Size(16, 464);
            this.panelExtender1.TabIndex = 10;
            // 
            // AllItemsLabel
            // 
            this.AllItemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.AllItemsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllItemsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllItemsLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AllItemsLabel.Location = new System.Drawing.Point(16, 16);
            this.AllItemsLabel.Name = "AllItemsLabel";
            this.AllItemsLabel.Size = new System.Drawing.Size(288, 20);
            this.AllItemsLabel.TabIndex = 11;
            this.AllItemsLabel.Text = "All Items";
            this.AllItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.AllItemsLabel);
            this.Controls.Add(this.panelExtender1);
            this.Controls.Add(this.SelectedControlPanel);
            this.Controls.Add(this.TopMarginPanel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ListBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListEditorControl";
            this.Size = new System.Drawing.Size(720, 480);
            this.SelectedControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private Objects.PanelExtender TopMarginPanel;
        private Objects.PanelExtender SelectedControlPanel;
        private Objects.PanelExtender BottomMarginPanel;
        private Objects.PanelExtender RightMarginPanel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private Objects.PanelExtender panelExtender1;
        private System.Windows.Forms.Label AllItemsLabel;
        private Objects.PanelExtender EditControlPanel;
        private Objects.PanelExtender SavePanel;
    }
}

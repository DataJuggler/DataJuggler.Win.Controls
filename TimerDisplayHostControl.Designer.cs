namespace DataJuggler.Win.Controls
{
    partial class TimerDisplayHostControl
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
            this.SecondsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.MinutesControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StartAtLabel = new System.Windows.Forms.Label();
            this.ReverseCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.HoursControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StopButton = new DataJuggler.Win.Controls.Button();
            this.StartButton = new DataJuggler.Win.Controls.Button();
            this.DisplayTimer = new DataJuggler.Win.Controls.TimerDisplay();
            this.SuspendLayout();
            // 
            // SecondsControl
            // 
            this.SecondsControl.BackColor = System.Drawing.Color.Transparent;
            this.SecondsControl.BottomMargin = 0;
            this.SecondsControl.Editable = true;
            this.SecondsControl.Encrypted = false;
            this.SecondsControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondsControl.LabelBottomMargin = 0;
            this.SecondsControl.LabelColor = System.Drawing.Color.Black;
            this.SecondsControl.LabelFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecondsControl.LabelText = "Seconds:";
            this.SecondsControl.LabelTopMargin = 0;
            this.SecondsControl.LabelWidth = 100;
            this.SecondsControl.Location = new System.Drawing.Point(85, 234);
            this.SecondsControl.MultiLine = false;
            this.SecondsControl.Name = "SecondsControl";
            this.SecondsControl.OnTextChangedListener = null;
            this.SecondsControl.PasswordMode = false;
            this.SecondsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SecondsControl.Size = new System.Drawing.Size(178, 32);
            this.SecondsControl.TabIndex = 15;
            this.SecondsControl.TextBoxBottomMargin = 0;
            this.SecondsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.SecondsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.SecondsControl.TextBoxFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondsControl.TextBoxTopMargin = 0;
            this.SecondsControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.SecondsControl.Visible = false;
            // 
            // MinutesControl
            // 
            this.MinutesControl.BackColor = System.Drawing.Color.Transparent;
            this.MinutesControl.BottomMargin = 0;
            this.MinutesControl.Editable = true;
            this.MinutesControl.Encrypted = false;
            this.MinutesControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinutesControl.LabelBottomMargin = 0;
            this.MinutesControl.LabelColor = System.Drawing.Color.Black;
            this.MinutesControl.LabelFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinutesControl.LabelText = "Minutes:";
            this.MinutesControl.LabelTopMargin = 0;
            this.MinutesControl.LabelWidth = 100;
            this.MinutesControl.Location = new System.Drawing.Point(85, 194);
            this.MinutesControl.MultiLine = false;
            this.MinutesControl.Name = "MinutesControl";
            this.MinutesControl.OnTextChangedListener = null;
            this.MinutesControl.PasswordMode = false;
            this.MinutesControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MinutesControl.Size = new System.Drawing.Size(178, 32);
            this.MinutesControl.TabIndex = 14;
            this.MinutesControl.TextBoxBottomMargin = 0;
            this.MinutesControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MinutesControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MinutesControl.TextBoxFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinutesControl.TextBoxTopMargin = 0;
            this.MinutesControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.MinutesControl.Visible = false;
            // 
            // StartAtLabel
            // 
            this.StartAtLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartAtLabel.ForeColor = System.Drawing.Color.Black;
            this.StartAtLabel.Location = new System.Drawing.Point(100, 124);
            this.StartAtLabel.Name = "StartAtLabel";
            this.StartAtLabel.Size = new System.Drawing.Size(95, 20);
            this.StartAtLabel.TabIndex = 13;
            this.StartAtLabel.Text = "Start At:";
            this.StartAtLabel.Visible = false;
            // 
            // ReverseCheckBox
            // 
            this.ReverseCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ReverseCheckBox.CheckBoxHorizontalOffSet = 0;
            this.ReverseCheckBox.CheckBoxVerticalOffSet = 3;
            this.ReverseCheckBox.CheckChangedListener = null;
            this.ReverseCheckBox.Checked = false;
            this.ReverseCheckBox.Editable = true;
            this.ReverseCheckBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReverseCheckBox.LabelColor = System.Drawing.Color.Black;
            this.ReverseCheckBox.LabelFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReverseCheckBox.LabelText = "Reverse:";
            this.ReverseCheckBox.LabelWidth = 100;
            this.ReverseCheckBox.Location = new System.Drawing.Point(32, 89);
            this.ReverseCheckBox.Name = "ReverseCheckBox";
            this.ReverseCheckBox.Size = new System.Drawing.Size(280, 26);
            this.ReverseCheckBox.TabIndex = 12;
            this.ReverseCheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            // 
            // HoursControl
            // 
            this.HoursControl.BackColor = System.Drawing.Color.Transparent;
            this.HoursControl.BottomMargin = 0;
            this.HoursControl.Editable = true;
            this.HoursControl.Encrypted = false;
            this.HoursControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoursControl.LabelBottomMargin = 0;
            this.HoursControl.LabelColor = System.Drawing.Color.Black;
            this.HoursControl.LabelFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HoursControl.LabelText = "Hour:";
            this.HoursControl.LabelTopMargin = 0;
            this.HoursControl.LabelWidth = 100;
            this.HoursControl.Location = new System.Drawing.Point(85, 154);
            this.HoursControl.MultiLine = false;
            this.HoursControl.Name = "HoursControl";
            this.HoursControl.OnTextChangedListener = null;
            this.HoursControl.PasswordMode = false;
            this.HoursControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HoursControl.Size = new System.Drawing.Size(178, 32);
            this.HoursControl.TabIndex = 11;
            this.HoursControl.TextBoxBottomMargin = 0;
            this.HoursControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.HoursControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.HoursControl.TextBoxFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoursControl.TextBoxTopMargin = 0;
            this.HoursControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.HoursControl.Visible = false;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.ButtonText = "Stop";
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StopButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StopButton.Location = new System.Drawing.Point(397, 27);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(120, 48);
            this.StopButton.TabIndex = 10;
            this.StopButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.ButtonText = "Start";
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StartButton.Location = new System.Drawing.Point(269, 27);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 48);
            this.StartButton.TabIndex = 9;
            this.StartButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DisplayTimer
            // 
            this.DisplayTimer.BackColor = System.Drawing.Color.Black;
            this.DisplayTimer.EndTime = new System.DateTime(((long)(0)));
            this.DisplayTimer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayTimer.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DisplayTimer.LastSecond = 0;
            this.DisplayTimer.Location = new System.Drawing.Point(30, 23);
            this.DisplayTimer.Name = "DisplayTimer";
            this.DisplayTimer.Reverse = false;
            this.DisplayTimer.Size = new System.Drawing.Size(212, 57);
            this.DisplayTimer.StartAtTime = new System.DateTime(((long)(0)));
            this.DisplayTimer.StartTime = new System.DateTime(((long)(0)));
            this.DisplayTimer.Status = DataJuggler.Win.Controls.Enumerations.TimerStatusEnum.NotStarted;
            this.DisplayTimer.StopAtZero = false;
            this.DisplayTimer.TabIndex = 8;
            // 
            // TimerDisplayHostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SecondsControl);
            this.Controls.Add(this.MinutesControl);
            this.Controls.Add(this.StartAtLabel);
            this.Controls.Add(this.ReverseCheckBox);
            this.Controls.Add(this.HoursControl);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DisplayTimer);
            this.Name = "TimerDisplayHostControl";
            this.Size = new System.Drawing.Size(562, 290);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextBoxControl SecondsControl;
        private LabelTextBoxControl MinutesControl;
        private System.Windows.Forms.Label StartAtLabel;
        private LabelCheckBoxControl ReverseCheckBox;
        private LabelTextBoxControl HoursControl;
        private Button StopButton;
        private Button StartButton;
        private TimerDisplay DisplayTimer;
    }
}

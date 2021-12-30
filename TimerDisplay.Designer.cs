namespace DataJuggler.Win.Controls
{
    partial class TimerDisplay
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
            this.components = new System.ComponentModel.Container();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.DisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimerLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.Location = new System.Drawing.Point(0, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(240, 60);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "0:00:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimerLabel.SizeChanged += new System.EventHandler(this.TimerLabel_SizeChanged);
            // 
            // DisplayTimer
            // 
            this.DisplayTimer.Tick += new System.EventHandler(this.DisplayTimer_Tick);
            // 
            // TimerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.TimerLabel);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Name = "TimerDisplay";
            this.Size = new System.Drawing.Size(240, 60);
            this.ForeColorChanged += new System.EventHandler(this.TimerDisplay_ForeColorChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer DisplayTimer;
    }
}

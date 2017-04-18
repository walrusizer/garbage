namespace _10secondclick
{
    partial class Form1
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
            this.kpsText = new System.Windows.Forms.Label();
            this.timeDownDisplay = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Label();
            this.keysText = new System.Windows.Forms.Label();
            this.bpmText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kpsText
            // 
            this.kpsText.AutoSize = true;
            this.kpsText.Font = new System.Drawing.Font("Arial", 20F);
            this.kpsText.ForeColor = System.Drawing.Color.Lime;
            this.kpsText.Location = new System.Drawing.Point(260, 29);
            this.kpsText.Name = "kpsText";
            this.kpsText.Size = new System.Drawing.Size(99, 32);
            this.kpsText.TabIndex = 0;
            this.kpsText.Text = "KPS: 0";
            this.kpsText.Click += new System.EventHandler(this.kpsText_Click);
            // 
            // timeDownDisplay
            // 
            this.timeDownDisplay.AutoSize = true;
            this.timeDownDisplay.Font = new System.Drawing.Font("Arial", 15F);
            this.timeDownDisplay.ForeColor = System.Drawing.Color.Lime;
            this.timeDownDisplay.Location = new System.Drawing.Point(276, 88);
            this.timeDownDisplay.Name = "timeDownDisplay";
            this.timeDownDisplay.Size = new System.Drawing.Size(60, 23);
            this.timeDownDisplay.TabIndex = 1;
            this.timeDownDisplay.Text = "10:00";
            this.timeDownDisplay.Click += new System.EventHandler(this.timeDownDisplay_Click);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.startButton.Font = new System.Drawing.Font("Arial", 15F);
            this.startButton.ForeColor = System.Drawing.Color.Lime;
            this.startButton.Location = new System.Drawing.Point(282, 239);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(59, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start!";
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // keysText
            // 
            this.keysText.AutoSize = true;
            this.keysText.Font = new System.Drawing.Font("Arial", 15F);
            this.keysText.ForeColor = System.Drawing.Color.Lime;
            this.keysText.Location = new System.Drawing.Point(236, 61);
            this.keysText.Name = "keysText";
            this.keysText.Size = new System.Drawing.Size(156, 23);
            this.keysText.TabIndex = 3;
            this.keysText.Text = "Keys Pressed: 0";
            // 
            // bpmText
            // 
            this.bpmText.AutoSize = true;
            this.bpmText.Font = new System.Drawing.Font("Arial", 15F);
            this.bpmText.ForeColor = System.Drawing.Color.Lime;
            this.bpmText.Location = new System.Drawing.Point(25, 29);
            this.bpmText.Name = "bpmText";
            this.bpmText.Size = new System.Drawing.Size(76, 23);
            this.bpmText.TabIndex = 4;
            this.bpmText.Text = "BPM: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(649, 476);
            this.Controls.Add(this.bpmText);
            this.Controls.Add(this.keysText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeDownDisplay);
            this.Controls.Add(this.kpsText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kpsText;
        private System.Windows.Forms.Label timeDownDisplay;
        private System.Windows.Forms.Label startButton;
        private System.Windows.Forms.Label keysText;
        private System.Windows.Forms.Label bpmText;
    }
}


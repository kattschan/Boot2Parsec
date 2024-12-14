namespace WinFormsB2PShell
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
            this.greeting = new System.Windows.Forms.Label();
            this.launcherButton = new System.Windows.Forms.Button();
            this.logOff = new System.Windows.Forms.Button();
            this.lockButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shutDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(12, 9);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(221, 37);
            this.greeting.TabIndex = 0;
            this.greeting.Text = "Good Morning";
            // 
            // launcherButton
            // 
            this.launcherButton.AutoSize = true;
            this.launcherButton.Location = new System.Drawing.Point(19, 49);
            this.launcherButton.Name = "launcherButton";
            this.launcherButton.Padding = new System.Windows.Forms.Padding(1);
            this.launcherButton.Size = new System.Drawing.Size(75, 25);
            this.launcherButton.TabIndex = 1;
            this.launcherButton.Text = "button1";
            this.launcherButton.UseVisualStyleBackColor = true;
            this.launcherButton.Click += new System.EventHandler(this.launcherButton_Click);
            // 
            // logOff
            // 
            this.logOff.Location = new System.Drawing.Point(18, 98);
            this.logOff.Name = "logOff";
            this.logOff.Padding = new System.Windows.Forms.Padding(1);
            this.logOff.Size = new System.Drawing.Size(75, 23);
            this.logOff.TabIndex = 2;
            this.logOff.Text = "Log Off";
            this.logOff.UseVisualStyleBackColor = true;
            this.logOff.Click += new System.EventHandler(this.logOff_Click);
            // 
            // lockButton
            // 
            this.lockButton.Location = new System.Drawing.Point(99, 98);
            this.lockButton.Name = "lockButton";
            this.lockButton.Padding = new System.Windows.Forms.Padding(1);
            this.lockButton.Size = new System.Drawing.Size(75, 23);
            this.lockButton.TabIndex = 3;
            this.lockButton.Text = "Lock";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Power Options";
            // 
            // shutDown
            // 
            this.shutDown.Location = new System.Drawing.Point(180, 98);
            this.shutDown.Name = "shutDown";
            this.shutDown.Padding = new System.Windows.Forms.Padding(1);
            this.shutDown.Size = new System.Drawing.Size(75, 23);
            this.shutDown.TabIndex = 5;
            this.shutDown.Text = "Shut Down";
            this.shutDown.UseVisualStyleBackColor = true;
            this.shutDown.Click += new System.EventHandler(this.shutDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shutDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lockButton);
            this.Controls.Add(this.logOff);
            this.Controls.Add(this.launcherButton);
            this.Controls.Add(this.greeting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button launcherButton;
        private System.Windows.Forms.Button logOff;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button shutDown;
    }
}


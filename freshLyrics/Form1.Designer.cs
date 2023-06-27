namespace freshLyrics
{
    partial class LyricFetcher
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
            this.overwrite = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.get = new System.Windows.Forms.Button();
            this.trackName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // overwrite
            // 
            this.overwrite.AutoSize = true;
            this.overwrite.Location = new System.Drawing.Point(7, 3);
            this.overwrite.Name = "overwrite";
            this.overwrite.Size = new System.Drawing.Size(71, 17);
            this.overwrite.TabIndex = 0;
            this.overwrite.Text = "Overwrite";
            this.overwrite.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 97);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(191, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1;
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(130, 12);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(73, 66);
            this.get.TabIndex = 2;
            this.get.Text = "GetLyrics";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // trackName
            // 
            this.trackName.AutoSize = true;
            this.trackName.Location = new System.Drawing.Point(16, 81);
            this.trackName.MaximumSize = new System.Drawing.Size(190, 14);
            this.trackName.Name = "trackName";
            this.trackName.Size = new System.Drawing.Size(0, 13);
            this.trackName.TabIndex = 3;
            this.trackName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.overwrite);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 66);
            this.panel1.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "AZLyrics.com";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lyrics Wikia";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // LyricFetcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 143);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackName);
            this.Controls.Add(this.get);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LyricFetcher";
            this.Text = "LyricFetcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox overwrite;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Label trackName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;


    }
}


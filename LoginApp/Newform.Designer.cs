namespace LoginApp
{
    partial class Newform
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
            this.btnclose = new System.Windows.Forms.Button();
            this.lboxLoggedIn = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(35, 352);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(235, 51);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lboxLoggedIn
            // 
            this.lboxLoggedIn.FormattingEnabled = true;
            this.lboxLoggedIn.Location = new System.Drawing.Point(35, 30);
            this.lboxLoggedIn.Name = "lboxLoggedIn";
            this.lboxLoggedIn.Size = new System.Drawing.Size(235, 316);
            this.lboxLoggedIn.TabIndex = 1;
            // 
            // Newform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 426);
            this.Controls.Add(this.lboxLoggedIn);
            this.Controls.Add(this.btnclose);
            this.Name = "Newform";
            this.Text = "Newform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ListBox lboxLoggedIn;
    }
}
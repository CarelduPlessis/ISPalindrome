namespace ISPalindrome
{
    partial class ISPalindrome
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
            this.btnCheckPalindrome = new System.Windows.Forms.Button();
            this.tbxUserInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckPalindrome
            // 
            this.btnCheckPalindrome.Location = new System.Drawing.Point(293, 306);
            this.btnCheckPalindrome.Name = "btnCheckPalindrome";
            this.btnCheckPalindrome.Size = new System.Drawing.Size(180, 76);
            this.btnCheckPalindrome.TabIndex = 0;
            this.btnCheckPalindrome.Text = "Check Palindrome";
            this.btnCheckPalindrome.UseVisualStyleBackColor = true;
            this.btnCheckPalindrome.Click += new System.EventHandler(this.btnCheckPalindrome_Click);
            // 
            // tbxUserInput
            // 
            this.tbxUserInput.Location = new System.Drawing.Point(225, 47);
            this.tbxUserInput.Name = "tbxUserInput";
            this.tbxUserInput.Size = new System.Drawing.Size(311, 22);
            this.tbxUserInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check Word is Palindrome:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(344, 161);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(55, 17);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "Results";
            // 
            // ISPalindrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUserInput);
            this.Controls.Add(this.btnCheckPalindrome);
            this.Name = "ISPalindrome";
            this.Text = "IS Palindrome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckPalindrome;
        private System.Windows.Forms.TextBox tbxUserInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
    }
}


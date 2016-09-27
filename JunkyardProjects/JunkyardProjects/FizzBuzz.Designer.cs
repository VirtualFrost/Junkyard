namespace JunkyardProjects
{
    partial class FizzBuzz
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
            this.fizzbuzzBtn = new System.Windows.Forms.Button();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fizzbuzzBtn
            // 
            this.fizzbuzzBtn.Location = new System.Drawing.Point(46, 115);
            this.fizzbuzzBtn.Name = "fizzbuzzBtn";
            this.fizzbuzzBtn.Size = new System.Drawing.Size(96, 32);
            this.fizzbuzzBtn.TabIndex = 0;
            this.fizzbuzzBtn.Text = "Fizz Buzz!";
            this.fizzbuzzBtn.UseVisualStyleBackColor = true;
            this.fizzbuzzBtn.Click += new System.EventHandler(this.fizzbuzzBtn_Click);
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(180, 0);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(134, 264);
            this.displayListBox.TabIndex = 1;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 89);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(162, 20);
            this.inputTextBox.TabIndex = 2;
            // 
            // FizzBuzz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 265);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.fizzbuzzBtn);
            this.Name = "FizzBuzz";
            this.Text = "FizzBuzz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fizzbuzzBtn;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}
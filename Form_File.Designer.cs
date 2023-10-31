namespace Interpret_Interface
{
    partial class Form_File
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
            this.Text_FileContents = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Text_FileContents
            // 
            this.Text_FileContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_FileContents.Location = new System.Drawing.Point(18, 18);
            this.Text_FileContents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_FileContents.Name = "Text_FileContents";
            this.Text_FileContents.Size = new System.Drawing.Size(1162, 660);
            this.Text_FileContents.TabIndex = 0;
            this.Text_FileContents.Text = "";
            // 
            // Form_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Text_FileContents);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_File";
            this.Text = "TransferWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Text_FileContents;
    }
}
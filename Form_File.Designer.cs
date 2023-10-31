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
            this.Button_Send = new System.Windows.Forms.Button();
            this.Button_Receive = new System.Windows.Forms.Button();
            this.Dropdown_DataType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Text_FileContents
            // 
            this.Text_FileContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_FileContents.Location = new System.Drawing.Point(12, 12);
            this.Text_FileContents.Name = "Text_FileContents";
            this.Text_FileContents.Size = new System.Drawing.Size(776, 397);
            this.Text_FileContents.TabIndex = 0;
            this.Text_FileContents.Text = "";
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(713, 415);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(75, 23);
            this.Button_Send.TabIndex = 1;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Button_Receive
            // 
            this.Button_Receive.Location = new System.Drawing.Point(632, 415);
            this.Button_Receive.Name = "Button_Receive";
            this.Button_Receive.Size = new System.Drawing.Size(75, 23);
            this.Button_Receive.TabIndex = 2;
            this.Button_Receive.Text = "Receive";
            this.Button_Receive.UseVisualStyleBackColor = true;
            this.Button_Receive.Click += new System.EventHandler(this.Button_Receive_Click);
            // 
            // Dropdown_DataType
            // 
            this.Dropdown_DataType.FormattingEnabled = true;
            this.Dropdown_DataType.Items.AddRange(new object[] {
            "Waypoints",
            "Route",
            "Track"});
            this.Dropdown_DataType.Location = new System.Drawing.Point(505, 415);
            this.Dropdown_DataType.Name = "Dropdown_DataType";
            this.Dropdown_DataType.Size = new System.Drawing.Size(121, 21);
            this.Dropdown_DataType.TabIndex = 3;
            // 
            // Form_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dropdown_DataType);
            this.Controls.Add(this.Button_Receive);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.Text_FileContents);
            this.Name = "Form_File";
            this.Text = "TransferWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Text_FileContents;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Button Button_Receive;
        private System.Windows.Forms.ComboBox Dropdown_DataType;
    }
}
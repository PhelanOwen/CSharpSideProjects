namespace WindowsFormsApplication1
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
            this.ChooseFile = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseFile
            // 
            this.ChooseFile.AccessibleName = "ChooseFile";
            this.ChooseFile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ChooseFile.Location = new System.Drawing.Point(197, 226);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(90, 23);
            this.ChooseFile.TabIndex = 0;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.AccessibleName = "fileTextBox";
            this.fileTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileTextBox.Location = new System.Drawing.Point(12, 12);
            this.fileTextBox.Multiline = true;
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileTextBox.Size = new System.Drawing.Size(460, 208);
            this.fileTextBox.TabIndex = 2;
            this.fileTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AccessibleName = "ChooseFile";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.ChooseFile);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Text Displayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.TextBox fileTextBox;
    }
}


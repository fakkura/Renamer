namespace Renamer
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
            this.startButton = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileList = new Renamer.DirectorySearcher();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(491, 410);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(12, 412);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(473, 20);
            this.pathText.TabIndex = 2;
            this.pathText.WordWrap = false;
            this.pathText.Click += new System.EventHandler(this.pathText_Click);
            // 
            // fileList
            // 
            this.fileList.Location = new System.Drawing.Point(12, 12);
            this.fileList.Name = "fileList";
            this.fileList.SearchCriteria = null;
            this.fileList.Size = new System.Drawing.Size(554, 392);
            this.fileList.TabIndex = 3;
            this.fileList.SearchComplete += new System.EventHandler(this.fileList_SearchComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 437);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private DirectorySearcher fileList;
    }
}


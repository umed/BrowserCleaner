namespace Cleaner
{
    partial class MainForm
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
            this.cleanersCB = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.filesToRemoveLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cleanersCB
            // 
            this.cleanersCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cleanersCB.FormattingEnabled = true;
            this.cleanersCB.Location = new System.Drawing.Point(12, 12);
            this.cleanersCB.Name = "cleanersCB";
            this.cleanersCB.Size = new System.Drawing.Size(761, 21);
            this.cleanersCB.TabIndex = 0;
            this.cleanersCB.SelectedIndexChanged += new System.EventHandler(this.cleanersCB_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(779, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // filesToRemoveLB
            // 
            this.filesToRemoveLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesToRemoveLB.FormattingEnabled = true;
            this.filesToRemoveLB.Location = new System.Drawing.Point(12, 39);
            this.filesToRemoveLB.Name = "filesToRemoveLB";
            this.filesToRemoveLB.Size = new System.Drawing.Size(842, 316);
            this.filesToRemoveLB.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 371);
            this.Controls.Add(this.filesToRemoveLB);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cleanersCB);
            this.Name = "MainForm";
            this.Text = "Browser Cleaner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cleanersCB;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox filesToRemoveLB;
    }
}


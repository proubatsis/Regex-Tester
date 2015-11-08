namespace Regex_Tester
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.matchedListView = new System.Windows.Forms.ListView();
            this.groupHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matchButton = new System.Windows.Forms.Button();
            this.matchHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(30, 12);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(56, 20);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input:";
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(13, 44);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(73, 20);
            this.patternLabel.TabIndex = 1;
            this.patternLabel.Text = "Pattern:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(93, 9);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(457, 26);
            this.inputTextBox.TabIndex = 2;
            // 
            // patternTextBox
            // 
            this.patternTextBox.Location = new System.Drawing.Point(93, 41);
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(457, 26);
            this.patternTextBox.TabIndex = 3;
            // 
            // matchedListView
            // 
            this.matchedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matchHeader,
            this.groupHeader,
            this.valueHeader});
            this.matchedListView.Location = new System.Drawing.Point(17, 115);
            this.matchedListView.Name = "matchedListView";
            this.matchedListView.Size = new System.Drawing.Size(533, 305);
            this.matchedListView.TabIndex = 4;
            this.matchedListView.UseCompatibleStateImageBehavior = false;
            this.matchedListView.View = System.Windows.Forms.View.Details;
            // 
            // groupHeader
            // 
            this.groupHeader.Text = "Group";
            this.groupHeader.Width = 75;
            // 
            // valueHeader
            // 
            this.valueHeader.Text = "Value";
            this.valueHeader.Width = 359;
            // 
            // matchButton
            // 
            this.matchButton.Location = new System.Drawing.Point(17, 74);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(533, 35);
            this.matchButton.TabIndex = 5;
            this.matchButton.Text = "Regex.Match()";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // matchHeader
            // 
            this.matchHeader.Text = "Match #";
            this.matchHeader.Width = 83;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 432);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.matchedListView);
            this.Controls.Add(this.patternTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.inputLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Regex Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.ListView matchedListView;
        private System.Windows.Forms.ColumnHeader groupHeader;
        private System.Windows.Forms.ColumnHeader valueHeader;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.ColumnHeader matchHeader;
    }
}


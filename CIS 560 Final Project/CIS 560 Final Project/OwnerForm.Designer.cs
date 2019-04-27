namespace CIS_560_Final_Project
{
    partial class uxOwnerForm
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
            this.uxAddOwnerButton = new System.Windows.Forms.Button();
            this.uxPhoneLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxLastNameLabel = new System.Windows.Forms.Label();
            this.uxHappinessLabel = new System.Windows.Forms.Label();
            this.uxPhoneTextBox = new System.Windows.Forms.TextBox();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastNameTextBox = new System.Windows.Forms.TextBox();
            this.uxPercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxOwnerContainer = new System.Windows.Forms.GroupBox();
            this.uxOwnerListBox = new System.Windows.Forms.ListBox();
            this.uxInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxPercentNumericUpDown)).BeginInit();
            this.uxOwnerContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxAddOwnerButton
            // 
            this.uxAddOwnerButton.Location = new System.Drawing.Point(12, 12);
            this.uxAddOwnerButton.Name = "uxAddOwnerButton";
            this.uxAddOwnerButton.Size = new System.Drawing.Size(182, 39);
            this.uxAddOwnerButton.TabIndex = 4;
            this.uxAddOwnerButton.Text = "Add Owner";
            this.uxAddOwnerButton.UseVisualStyleBackColor = true;
            this.uxAddOwnerButton.Click += new System.EventHandler(this.UxAddOwnerButton_Click);
            // 
            // uxPhoneLabel
            // 
            this.uxPhoneLabel.AutoSize = true;
            this.uxPhoneLabel.Location = new System.Drawing.Point(6, 22);
            this.uxPhoneLabel.Name = "uxPhoneLabel";
            this.uxPhoneLabel.Size = new System.Drawing.Size(45, 13);
            this.uxPhoneLabel.TabIndex = 2;
            this.uxPhoneLabel.Text = "Phone#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // uxLastNameLabel
            // 
            this.uxLastNameLabel.AutoSize = true;
            this.uxLastNameLabel.Location = new System.Drawing.Point(5, 67);
            this.uxLastNameLabel.Name = "uxLastNameLabel";
            this.uxLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.uxLastNameLabel.TabIndex = 2;
            this.uxLastNameLabel.Text = "Last Name";
            // 
            // uxHappinessLabel
            // 
            this.uxHappinessLabel.AutoSize = true;
            this.uxHappinessLabel.Location = new System.Drawing.Point(5, 94);
            this.uxHappinessLabel.Name = "uxHappinessLabel";
            this.uxHappinessLabel.Size = new System.Drawing.Size(57, 13);
            this.uxHappinessLabel.TabIndex = 2;
            this.uxHappinessLabel.Text = "Happiness";
            // 
            // uxPhoneTextBox
            // 
            this.uxPhoneTextBox.Location = new System.Drawing.Point(69, 19);
            this.uxPhoneTextBox.Name = "uxPhoneTextBox";
            this.uxPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxPhoneTextBox.TabIndex = 2;
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(69, 42);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(100, 20);
            this.uxFirstName.TabIndex = 2;
            // 
            // uxLastNameTextBox
            // 
            this.uxLastNameTextBox.Location = new System.Drawing.Point(69, 67);
            this.uxLastNameTextBox.Name = "uxLastNameTextBox";
            this.uxLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxLastNameTextBox.TabIndex = 2;
            // 
            // uxPercentNumericUpDown
            // 
            this.uxPercentNumericUpDown.Location = new System.Drawing.Point(69, 92);
            this.uxPercentNumericUpDown.Name = "uxPercentNumericUpDown";
            this.uxPercentNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.uxPercentNumericUpDown.TabIndex = 2;
            // 
            // uxAddButton
            // 
            this.uxAddButton.Location = new System.Drawing.Point(94, 118);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddButton.TabIndex = 2;
            this.uxAddButton.Text = "Add";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.UxAddButton_Click);
            // 
            // uxOwnerContainer
            // 
            this.uxOwnerContainer.Controls.Add(this.uxAddButton);
            this.uxOwnerContainer.Controls.Add(this.uxPercentNumericUpDown);
            this.uxOwnerContainer.Controls.Add(this.uxLastNameTextBox);
            this.uxOwnerContainer.Controls.Add(this.uxFirstName);
            this.uxOwnerContainer.Controls.Add(this.uxPhoneTextBox);
            this.uxOwnerContainer.Controls.Add(this.uxHappinessLabel);
            this.uxOwnerContainer.Controls.Add(this.uxLastNameLabel);
            this.uxOwnerContainer.Controls.Add(this.label2);
            this.uxOwnerContainer.Controls.Add(this.uxPhoneLabel);
            this.uxOwnerContainer.Enabled = false;
            this.uxOwnerContainer.Location = new System.Drawing.Point(12, 58);
            this.uxOwnerContainer.Name = "uxOwnerContainer";
            this.uxOwnerContainer.Size = new System.Drawing.Size(182, 153);
            this.uxOwnerContainer.TabIndex = 5;
            this.uxOwnerContainer.TabStop = false;
            this.uxOwnerContainer.Text = "New Owner";
            // 
            // uxOwnerListBox
            // 
            this.uxOwnerListBox.FormattingEnabled = true;
            this.uxOwnerListBox.Location = new System.Drawing.Point(201, 38);
            this.uxOwnerListBox.Name = "uxOwnerListBox";
            this.uxOwnerListBox.Size = new System.Drawing.Size(215, 173);
            this.uxOwnerListBox.TabIndex = 6;
            // 
            // uxInstructions
            // 
            this.uxInstructions.AutoSize = true;
            this.uxInstructions.Location = new System.Drawing.Point(201, 12);
            this.uxInstructions.Name = "uxInstructions";
            this.uxInstructions.Size = new System.Drawing.Size(136, 13);
            this.uxInstructions.TabIndex = 7;
            this.uxInstructions.Text = "Click owner for a list of pets";
            // 
            // uxOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 221);
            this.Controls.Add(this.uxInstructions);
            this.Controls.Add(this.uxOwnerListBox);
            this.Controls.Add(this.uxOwnerContainer);
            this.Controls.Add(this.uxAddOwnerButton);
            this.Name = "uxOwnerForm";
            this.Text = "Pet Owners";
            ((System.ComponentModel.ISupportInitialize)(this.uxPercentNumericUpDown)).EndInit();
            this.uxOwnerContainer.ResumeLayout(false);
            this.uxOwnerContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddOwnerButton;
        private System.Windows.Forms.Label uxPhoneLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxLastNameLabel;
        private System.Windows.Forms.Label uxHappinessLabel;
        private System.Windows.Forms.TextBox uxPhoneTextBox;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxLastNameTextBox;
        private System.Windows.Forms.NumericUpDown uxPercentNumericUpDown;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.GroupBox uxOwnerContainer;
        private System.Windows.Forms.ListBox uxOwnerListBox;
        private System.Windows.Forms.Label uxInstructions;
    }
}